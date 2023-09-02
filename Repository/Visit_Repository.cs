using Microsoft.Extensions.Configuration;
using System.Data;
using Veterinary_CRUD_App.Interfaces.Visits;
using Veterinary_CRUD_App.Models;

namespace Veterinary_CRUD_App.Repository
{
    internal class Visit_Repository : Base_Repository<Visit_Model>, IVisit_Repository_Interface
    {
        // Constructor
        public Visit_Repository(IConfiguration configuration) : base(configuration)
        {
        }

        // Add
        public void Add(Visit_Model visit_model)
        {
            string query = @"INSERT INTO Vet_Visit (pet_id, visit_type, visit_date, visit_description) " +
                            "VALUES (@pet_id, @visit_type, @visit_date, @visit_description)";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@pet_id", (SqlDbType.Int, visit_model.GET_pet_id) },
                { "@visit_type", (SqlDbType.NVarChar, visit_model.GET_visit_type) },
                { "@visit_date", (SqlDbType.DateTime, visit_model.GET_visit_date) },
                { "@visit_description", (SqlDbType.NVarChar, visit_model.GET_visit_description) }
            };

            Execute_Non_Query(query, parameters);
        }

        // Delete
        public void Delete(int visit_id)
        {
            string query = "DELETE " +
                           "FROM Vet_Visit " +
                           "WHERE visit_id = @visit_id";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@visit_id", (SqlDbType.Int, visit_id) }
            };

            Execute_Non_Query(query, parameters); // Assuming you have a method like this to execute the query.
        }

        // Edit
        public void Edit(Visit_Model visit_model)
        {
            string query = @"UPDATE Vet_Visit " +
                            "SET pet_id = @pet_id, " +
                                "visit_type = @visit_type, " +
                                "visit_date = @visit_date, " +
                                "visit_description = @visit_description " +
                            "WHERE visit_id = @visit_id";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@visit_id", (SqlDbType.Int, visit_model.GET_visit_id) },
                { "@pet_id", (SqlDbType.Int, visit_model.GET_pet_id) },
                { "@visit_type", (SqlDbType.NVarChar, visit_model.GET_visit_type) },
                { "@visit_date", (SqlDbType.DateTime, visit_model.GET_visit_date) },
                { "@visit_description", (SqlDbType.NVarChar, visit_model.GET_visit_description) }
            };

            Execute_Non_Query(query, parameters);
        }

        // Get everything
        public IEnumerable<Visit_Model> Get_All()
        {
            string query = @"SELECT Vet_Visit.*, Pet.pet_name " +
                            "FROM Vet_Visit " +
                            "INNER JOIN Pet ON Vet_Visit.pet_id = Pet.pet_id " +
                            "ORDER BY Vet_Visit.visit_id DESC";

            return Get<Visit_Model>(query);
        }

        // Get everything by search value
        public IEnumerable<Visit_Model> Get_By_Value(string value)
        {
            string query = @"SELECT Vet_Visit.*, Pet.pet_name " +
                            "FROM Vet_Visit " +
                            "INNER JOIN Pet ON Vet_Visit.pet_id = Pet.pet_id " +
                            "WHERE Pet.pet_name LIKE @string_value OR Vet_Visit.visit_type LIKE @string_value " +
                            "ORDER BY Vet_Visit.visit_id DESC";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@string_value", (SqlDbType.VarChar, $"%{value}%") }
            };

            return Get<Visit_Model>(query, parameters, value);
        }

        // Get all pets
        public IEnumerable<Pet_Model> Get_All_Pets()
        {
            string query = @"SELECT pet_id, pet_name " +
                            "FROM Pet " +
                            "ORDER BY pet_id DESC";

            return Get<Pet_Model>(query);
        }

        // Get everything for a specific id
        public Visit_Model Get_By_Id(int visit_id)
        {
            string query = @"SELECT * " +
                            "FROM Vet_Visit " +
                            "WHERE visit_id = @visit_id";

            var parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@visit_id", (SqlDbType.Int, visit_id) }
            };

            var results = Get<Visit_Model>(query, parameters);

            return results.FirstOrDefault() ?? new Visit_Model();
        }
    }
}