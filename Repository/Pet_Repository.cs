using Microsoft.Extensions.Configuration;
using System.Data;
using Veterinary_CRUD_App.Interfaces.Pets;
using Veterinary_CRUD_App.Models;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Repository
{
    internal class Pet_Repository : Base_Repository<Pet_Model>, IPet_Repository_Interface
    {
        // Constructor
        public Pet_Repository(IConfiguration configuration) : base(configuration)
        {
        }

        // Add
        public void Add(Pet_Model pet_model)
        {
            string query = @"INSERT INTO Pet (owner_id, pet_name, pet_type, pet_color, pet_age, pet_sex, pet_birthdate, pet_picture)
                            VALUES (@owner_id, @pet_name, @pet_type, @pet_color, @pet_age, @pet_sex, @pet_birthdate, @pet_picture) ";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_id", (SqlDbType.Int, pet_model.GET_owner_id) },
                { "@pet_name", (SqlDbType.NVarChar, pet_model.GET_pet_name) },
                { "@pet_type", (SqlDbType.NVarChar, pet_model.GET_pet_type) },
                { "@pet_color", (SqlDbType.NVarChar, pet_model.GET_pet_color) },
                { "@pet_age", (SqlDbType.Int, pet_model.GET_pet_age) },
                { "@pet_sex", (SqlDbType.NVarChar, pet_model.GET_pet_sex) },
                { "@pet_birthdate", (SqlDbType.DateTime, pet_model.GET_pet_birthdate) },
                { "@pet_picture", (SqlDbType.NVarChar, string.IsNullOrEmpty(pet_model.GET_pet_picture) ? (object)DBNull.Value : pet_model.GET_pet_picture) }
            };

            Execute_Non_Query(query, parameters);
        }

        // Delete
        public void Delete(int pet_id)
        {
            // First, delete associated vet visits
            string vet_visit_query = "DELETE " +
                                     "FROM Vet_Visit " +
                                     "WHERE pet_id = @pet_id";

            var vet_visit_parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@pet_id", (SqlDbType.Int, pet_id) }
            };

            Execute_Non_Query(vet_visit_query, vet_visit_parameters);

            // Then, delete the pet
            string pet_query = "DELETE " +
                               "FROM Pet " +
                               "WHERE pet_id = @pet_id";

            var pet_parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@pet_id", (SqlDbType.Int, pet_id) }
            };

            Execute_Non_Query(pet_query, pet_parameters);
        }

        // Edit
        public void Edit(Pet_Model pet_model)
        {
            string query = @"UPDATE Pet " +
                            "SET owner_id = @owner_id, " +
                                "pet_name = @pet_name, " +
                                "pet_type = @pet_type, " +
                                "pet_color = @pet_color, " +
                                "pet_age = @pet_age, " +
                                "pet_sex = @pet_sex, " +
                                "pet_birthdate = @pet_birthdate, " +
                                "pet_picture = @pet_picture " +
                            "WHERE pet_id = @pet_id";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@pet_id", (SqlDbType.Int, pet_model.GET_pet_id) },
                { "@owner_id", (SqlDbType.Int, pet_model.GET_owner_id) },
                { "@pet_name", (SqlDbType.NVarChar, pet_model.GET_pet_name) },
                { "@pet_type", (SqlDbType.NVarChar, pet_model.GET_pet_type) },
                { "@pet_color", (SqlDbType.NVarChar, pet_model.GET_pet_color) },
                { "@pet_age", (SqlDbType.Int, pet_model.GET_pet_age) },
                { "@pet_sex", (SqlDbType.NVarChar, pet_model.GET_pet_sex) },
                { "@pet_birthdate", (SqlDbType.DateTime, pet_model.GET_pet_birthdate) },
                { "@pet_picture", (SqlDbType.NVarChar, string.IsNullOrEmpty(pet_model.GET_pet_picture) ? (object)DBNull.Value : pet_model.GET_pet_picture) }
            };

            Execute_Non_Query(query, parameters);
        }

        // Get everything
        public IEnumerable<Pet_Model> Get_All()
        {
            string query = @"SELECT Pet.*, Owners.owner_name " +
                            "FROM Pet INNER JOIN Owners ON Pet.owner_id = Owners.owner_id " +
                            "ORDER BY Pet.pet_id DESC";

            return Get<Pet_Model>(query);
        }

        // Get everything by search value
        public IEnumerable<Pet_Model> Get_By_Value(string value)
        {
            string query = @"SELECT Pet.*, Owners.owner_name " +
                           "FROM Pet " +
                           "INNER JOIN Owners ON Pet.owner_id = Owners.owner_id " +
                           "WHERE (pet_id = @int_value OR " +
                                  "pet_name LIKE @string_value OR " +
                                  "pet_type LIKE @string_value OR " +
                                  "pet_color LIKE @string_value OR " +
                                  "pet_age = @int_value OR " +
                                  "pet_sex LIKE @string_value OR " +
                                  "Owners.owner_name LIKE @string_value) " +
                           "ORDER BY pet_id DESC";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@string_value", (SqlDbType.VarChar, $"%{value}%") }
            };

            if (int.TryParse(value, out int int_value))
            {
                parameters.Add("@int_value", (SqlDbType.Int, int_value));
            }
            else
            {
                parameters.Add("@int_value", (SqlDbType.Int, DBNull.Value));
            }

            return Get<Pet_Model>(query, parameters, value);
        }

        // Get all owners
        public IEnumerable<Owner_Model> Get_All_Owners()
        {
            string query = @"SELECT owner_id, owner_name " +
                            "FROM Owners " +
                            "ORDER BY owner_name ASC";
            return Get<Owner_Model>(query);
        }

        // Get all the visits for a pet
        public IEnumerable<Visit_Model> Get_All_Visits_For_Pet(int specific_pet_id)
        {
            string query = @"SELECT * " +
                            "FROM Vet_Visit " +
                            "WHERE pet_id = @pet_id " +
                            "ORDER BY visit_date DESC";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@pet_id", (SqlDbType.Int, specific_pet_id) }
            };

            return Get<Visit_Model>(query, parameters);
        }

        // Get everything for a specific id
        public Pet_Model Get_By_Id(int pet_id)
        {
            string query = @"SELECT * " +
                            "FROM Pet " +
                            "WHERE pet_id = @pet_id";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@pet_id", (SqlDbType.Int, pet_id) }
            };

            var results = Get<Pet_Model>(query, parameters);

            return results.FirstOrDefault() ?? new Pet_Model();
        }
    }
}