using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Veterinary_CRUD_App.Database;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Repository
{
    // This is an abstract generic class that represents a base for all the repositories in the system.
    // The generic parameter T_Model will represent the data model that a specific repository deals with.
    // It inherits from Database_Connection, which provides methods and properties for interacting with the database.
    internal abstract class Base_Repository<T_Model> : Database_Connection where T_Model : new()
    {
        // Constructor
        // The constructor takes in an IConfiguration object, which is used to read application settings, like database connection strings.
        // It passes this object to the base constructor (Database_Connection).
        public Base_Repository(IConfiguration configuration) : base(configuration)
        {
        }

        // None query operations
        // This method is used for executing SQL operations that do not return any data, such as INSERT, UPDATE, or DELETE commands.
        // It accepts a SQL query as a string and a dictionary of parameters.
        // It creates a new database connection, opens it, and prepares a command using the provided query and parameters.
        // command.ExecuteNonQuery(); executes the command.
        // There's a series of exception handlers to catch and handle possible errors gracefully, logging them to the console.
        public void Execute_Non_Query(string query, Dictionary<string, (SqlDbType, object)> parameters)
        {
            try
            {
                using var connection = Get_Connection();
                connection.Open();

                using var command = new SqlCommand(query, connection);
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value.Item1) { Value = parameter.Value.Item2 });
                }

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"An error occurred while communicating with the database: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"An error occurred with the database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        // Query operations
        // This is a more general-purpose method meant for executing SQL SELECT queries and mapping the results to a list of objects of type T.
        // It accepts a SQL query string, an optional dictionary of parameters, and an optional value for filtering.
        // It checks if the given value is whitespace or null, and if so, it throws an exception.
        // Like the Execute_Non_Query method, it establishes a connection, prepares a command, and adds parameters.
        // It then uses command.ExecuteReader(); to execute the command and retrieve a SqlDataReader, which is a forward-only cursor that reads rows from SQL Server.
        // The Utilities.Map_Reader<T>(reader) is a utility function that maps the rows from the SqlDataReader to a list of objects of type T.
        // If there's an exception, appropriate messages are logged, and an empty list is returned.
        protected IEnumerable<T> Get<T>(string query, Dictionary<string, (SqlDbType, object)>? parameters = null, string? value = null) where T : new()
        {
            if (value != null && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Search value cannot be null or whitespace.", nameof(value));
            }

            try
            {
                using var connection = Get_Connection();
                connection.Open();

                using var command = new SqlCommand(query, connection);

                // Add parameters if they are provided
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value.Item1) { Value = parameter.Value.Item2 ?? DBNull.Value });
                    }
                }

                using var reader = command.ExecuteReader();

                return Utilities.Map_Reader<T>(reader);
            }
            catch (SqlException ex)
            {
                // SQL exceptions are related to issues with SQL commands, such as syntax errors or missing tables/columns
                Console.WriteLine($"An error occurred while communicating with the database: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                // InvalidOperationExceptions are thrown when trying to do something that the current state of the object does not allow
                Console.WriteLine($"An error occurred with the database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catching any other types of exceptions
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            return Enumerable.Empty<T>(); // Return an empty list if there are any exceptions
        }
    }
}