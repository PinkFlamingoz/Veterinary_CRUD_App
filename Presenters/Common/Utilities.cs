using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Veterinary_CRUD_App.Presenters.Common
{
    internal class Utilities
    {
        // A static cache that keeps a dictionary of types and their property info for quicker retrieval.
        private static readonly Dictionary<Type, PropertyInfo[]> property_cache = new();

        // This method copies properties from one object (from_object) to another (to_object).
        public static void Assign_Properties<TFrom, TTo>(TFrom from_object, TTo to_object)
        {
            // Attempt to retrieve the property information of `TFrom` from the cache.
            if (!property_cache.TryGetValue(typeof(TFrom), out var from_properties))
            {
                // If not found in the cache, use reflection to get all properties of `TFrom`.
                from_properties = typeof(TFrom).GetProperties();
                // Cache the property information for future use.
                property_cache[typeof(TFrom)] = from_properties;
            }

            // Attempt to retrieve the property information of `TTo` from the cache.
            if (!property_cache.TryGetValue(typeof(TTo), out var to_properties_array))
            {
                // If not found in the cache, use reflection to get all properties of `TTo`.
                to_properties_array = typeof(TTo).GetProperties();
                // Cache the property information for future use.
                property_cache[typeof(TTo)] = to_properties_array;
            }

            // Convert the properties of `TTo` into a dictionary for faster lookups.
            var to_properties = to_properties_array.ToDictionary(p => p.Name);

            // Define the naming conventions for property mapping between source and destination.
            var naming_convetions = new Dictionary<string, string>()
            {
                { "I_", "GET_" }
            };

            // Loop through each property in the source object (`from_object`).
            foreach (var from_property in from_properties)
            {
                var target_property_name = from_property.Name;

                // Adjust the name of the source property based on the defined naming conventions.
                foreach (var convention in naming_convetions)
                {
                    if (from_property.Name.StartsWith(convention.Key))
                    {
                        target_property_name = target_property_name.Replace(convention.Key, convention.Value);
                    }
                    else if (from_property.Name.StartsWith(convention.Value))
                    {
                        target_property_name = target_property_name.Replace(convention.Value, convention.Key);
                    }
                }

                // Check if the destination object (`to_object`) has a property with the mapped name.
                if (!to_properties.TryGetValue(target_property_name, out var to_property))
                {
                    Console.WriteLine($"Property {target_property_name} not found in {typeof(TTo).Name}.");
                    continue; // Skip to next iteration if not found.
                }

                // Ensure the property in the destination object is writable.
                if (!to_property.CanWrite)
                {
                    Console.WriteLine($"Property {target_property_name} is not writable in {typeof(TTo).Name}.");
                    continue; // Skip to next iteration if not writable.
                }

                // Get the value from the current property of the source object.
                object? value = from_property.GetValue(from_object, null);

                // Handle potential type mismatches between source and destination properties.
                if (value == null)
                {
                    // If source value is null, ensure the destination property can accept null values.
                    if (!Is_Nullable(to_property.PropertyType))
                    {
                        Console.WriteLine($"Cannot assign null value to non-nullable property {target_property_name} in {typeof(TTo).Name}.");
                        continue;
                    }
                }
                else if (to_property.PropertyType != from_property.PropertyType)
                {
                    // If source value is a string and destination is an enum, try to parse the string to the enum type.
                    if (to_property.PropertyType.IsEnum && value is string string_enum_value)
                    {
                        value = Enum.Parse(to_property.PropertyType, string_enum_value);
                    }
                    // If destination property expects a string, convert source value to string.
                    else if (to_property.PropertyType == typeof(string))
                    {
                        value = value.ToString();
                    }
                }

                // Attempt to assign the value to the destination property.
                try
                {
                    to_property.SetValue(to_object, value, null);
                }
                catch (Exception ex)
                {
                    // If there's any error during assignment, log it.
                    Console.WriteLine($"Error setting property {target_property_name} in {typeof(TTo).Name}: {ex.Message}");
                }
            }
        }


        // Helper function to check if a type is nullable.
        private static bool Is_Nullable(Type type)
        {
            return !type.IsValueType || Nullable.GetUnderlyingType(type) != null;
        }

        // This function maps a SQL Data Reader to a list of models.
        public static List<T_Model> Map_Reader<T_Model>(SqlDataReader reader) where T_Model : new()
        {
            // Initialize a list to hold the models that will be created from the data reader.
            var model_list = new List<T_Model>();

            // A dictionary to map column names from the data reader to the properties of the model.
            // This allows faster data assignments as we read through the data reader.
            var column_mapping = new Dictionary<string, PropertyInfo>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                // For each column in the data reader, create a name following the format "GET_" + [Column Name in lowercase].
                var property_name = "GET_" + reader.GetName(i).ToLower();

                // Check if a property with this name exists in the model type. If it does, add to the mapping.
                var property_info = typeof(T_Model).GetProperty(property_name, BindingFlags.Public | BindingFlags.Instance);
                if (property_info != null)
                {
                    column_mapping.Add(reader.GetName(i), property_info);
                }
            }

            // As long as there are more rows in the data reader, read the next row.
            while (reader.Read())
            {
                // Create a new instance of the model type.
                var model = new T_Model();
                foreach (var column in column_mapping)
                {
                    // For each mapped column, retrieve the value from the data reader.
                    var value_from_database = reader[column.Key];

                    // If the value is not DB null (a database representation of null), set this value to the corresponding property in the model.
                    if (value_from_database != DBNull.Value)
                    {
                        column.Value.SetValue(model, value_from_database);
                    }
                }
                // Add the populated model to the list.
                model_list.Add(model);
            }

            // Return the list of populated models.
            return model_list;
        }

        // This method resets properties of an object marked with a specific attribute.
        public static void Reset_Properties<T_Model>(T_Model obj)
        {
            // Get all properties of the object that are marked with the ResettableAttribute.
            var properties = typeof(T_Model).GetProperties().Where(p => Attribute.IsDefined(p, typeof(ResettableAttribute)));

            foreach (var property in properties)
            {
                // For each such property, get the default value (null for reference types or the default for value types).
                var default_value = (property.PropertyType.IsValueType ? Activator.CreateInstance(property.PropertyType) : null);

                // Set the property to this default value.
                property.SetValue(obj, default_value);
            }
        }

        // This function retrieves the application configuration from "appsettings.json".
        public static IConfiguration Get_Configuration()
        {
            // Create a configuration builder.
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Set the base path to the current directory.
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);  // Add "appsettings.json" as a source.

            // Build and return the configuration.
            return builder.Build();
        }
    }
}