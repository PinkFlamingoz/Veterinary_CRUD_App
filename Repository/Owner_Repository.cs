using Microsoft.Extensions.Configuration;
using System.Data;
using Veterinary_CRUD_App.Interfaces.Owner;
using Veterinary_CRUD_App.Models;

namespace Veterinary_CRUD_App.Repository
{
    internal class Owner_Repository : Base_Repository<Owner_Model>, IOwner_Repository_Interface
    {
        // Constructor
        public Owner_Repository(IConfiguration configuration) : base(configuration)
        {
        }

        // Add
        public void Add(Owner_Model owner_model)
        {
            string query = @"INSERT INTO Owners (owner_name, owner_phone, owner_email) " +
                            "VALUES (@owner_name, @owner_phone, @owner_email)";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_name", (SqlDbType.NVarChar, owner_model.GET_owner_name) },
                { "@owner_phone", (SqlDbType.NVarChar, owner_model.GET_owner_phone) },
                { "@owner_email", (SqlDbType.NVarChar, owner_model.GET_owner_email) }
            };

            Execute_Non_Query(query, parameters);
        }

        // Delete
        public void Delete(int owner_id)
        {
            // First, delete vet visits associated with the owner's pets
            string vet_visit_query = @"DELETE " +
                                      "FROM Vet_Visit " +
                                      "WHERE pet_id " +
                                      "IN (SELECT pet_id FROM Pet WHERE owner_id = @owner_id)";

            var vet_visit_parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_id", (SqlDbType.Int, owner_id) }
            };

            Execute_Non_Query(vet_visit_query, vet_visit_parameters);

            // Then, delete the owner's pets
            string pet_query = "DELETE " +
                               "FROM Pet " +
                               "WHERE owner_id = @owner_id";

            var pet_parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_id", (SqlDbType.Int, owner_id) }
            };

            Execute_Non_Query(pet_query, pet_parameters);

            // Finally, delete the owner
            string owner_query = "DELETE " +
                                 "FROM Owners " +
                                 "WHERE owner_id = @owner_id";

            var owner_parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_id", (SqlDbType.Int, owner_id) }
            };

            Execute_Non_Query(owner_query, owner_parameters);
        }

        // Edit
        public void Edit(Owner_Model owner_model)
        {
            string query = @"UPDATE Owners " +
                            "SET owner_name = @owner_name, " +
                                "owner_phone = @owner_phone, " +
                                "owner_email = @owner_email " +
                            "WHERE owner_id = @owner_id";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_id", (SqlDbType.Int, owner_model.GET_owner_id) },
                { "@owner_name", (SqlDbType.NVarChar, owner_model.GET_owner_name) },
                { "@owner_phone", (SqlDbType.NVarChar, owner_model.GET_owner_phone) },
                { "@owner_email", (SqlDbType.NVarChar, owner_model.GET_owner_email) }
            };

            Execute_Non_Query(query, parameters);
        }

        // Get everything
        public IEnumerable<Owner_Model> Get_All()
        {
            string query = @"SELECT * " +
                            "FROM Owners";

            return Get<Owner_Model>(query);
        }

        // Get everything by search value
        public IEnumerable<Owner_Model> Get_By_Value(string value)
        {
            string query = @"SELECT * " +
                           "FROM Owners " +
                           "WHERE owner_name LIKE @string_value OR " +
                                 "owner_phone LIKE @string_value OR " +
                                 "owner_email LIKE @string_value";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@string_value", (SqlDbType.VarChar, $"%{value}%") }
            };

            return Get<Owner_Model>(query, parameters, value);
        }

        // Get all the pets of an owner
        public IEnumerable<Pet_Model> Get_All_Pets_For_Owner(int specific_owner_id)
        {
            string query = @"SELECT * " +
                            "FROM Pet " +
                            "WHERE owner_id = @owner_id " +
                            "ORDER BY pet_age DESC";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_id", (SqlDbType.Int, specific_owner_id) }
            };

            return Get<Pet_Model>(query, parameters);
        }

        // Get everything for a specific id
        public Owner_Model Get_By_Id(int owner_id)
        {
            string query = @"SELECT * " +
                            "FROM Owners " +
                            "WHERE owner_id = @owner_id";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@owner_id", (SqlDbType.Int, owner_id) }
            };

            var results = Get<Owner_Model>(query, parameters);

            return results.FirstOrDefault() ?? new Owner_Model();
        }
    }
}