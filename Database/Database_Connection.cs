using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Veterinary_CRUD_App.Database
{
    // An 'abstract' class named 'Database_Connection' serves as a foundation for database-related operations.
    // Being 'abstract', it's intended to be inherited by other classes rather than being instantiated directly.
    internal abstract class Database_Connection
    {
        // A 'readonly' string property that holds the connection string value to the database.
        // 'readonly' means its value can only be set in the constructor and won't change afterward.
        protected readonly string connection_string;

        // Constructor for the 'Database_Connection' class.
        // It initializes the connection string based on the given configuration.
        protected Database_Connection(IConfiguration configuration)
        {
            // Here, we're trying to retrieve the connection string named "MyDatabase" from the provided configuration. If it's not found (i.args., null), an exception is thrown to indicate that the connection string wasn't initialized.
            connection_string = configuration.GetConnectionString("MyDatabase") ?? throw new InvalidOperationException("Connection string is not initialized in the configuration.");
        }

        // A 'protected' method to create and return an SQL connection.
        // Being 'protected', it's only accessible within this class or by derived classes.
        protected SqlConnection Get_Connection()
        {
            // Instantiates and returns a new SqlConnection object using the previously initialized connection string.
            return new SqlConnection(connection_string);
        }
    }
}