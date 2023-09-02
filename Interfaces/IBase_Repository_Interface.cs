namespace Veterinary_CRUD_App.Interfaces
{
    // Declare a internal generic interface named 'IBase_Repository_Interface'.
    // Being 'internal', it is accessible only within the assembly it's declared in.
    // The generic type parameter 'T_Model' allows this interface to work with any model type.
    // The IBase_Repository_Interface<T_Model> interface essentially serves as a blueprint for the basic CRUD (Create, Read, Update, Delete) operations that any data repository should perform.
    // Implementing this interface ensures that classes provide implementations for the fundamental operations that are typically performed on a collection or database.
    // By being generic, this interface offers flexibility and can be used across various model types without having to redefine a separate interface for each model type.
    internal interface IBase_Repository_Interface<T_Model>
    {
        // FUNCTION DECLARATIONS:

        // Add a new item to the repository (usually a database or a collection).
        // 'T_Model model' is the item of type T_Model to be added.
        void Add(T_Model model);

        // Update or edit an existing item in the repository.
        // 'T_Model model' is the item of type T_Model to be edited.
        void Edit(T_Model model);

        // Delete an item from the repository based on its unique identifier.
        // 'int model_id' is the unique identifier of the item to be deleted.
        void Delete(int model_id);

        // Retrieve all items from the repository.
        // Returns an IEnumerable collection of items of type T_Model.
        IEnumerable<T_Model> Get_All();

        // Retrieve items from the repository based on a specific value (like a keyword or a filter).
        // 'string value' represents the value to search for.
        // Returns an IEnumerable collection of items of type T_Model that match the search criteria.
        IEnumerable<T_Model> Get_By_Value(string value);

        // Retrieve a single item from the repository based on its unique identifier.
        // 'int item_id' is the unique identifier of the desired item.
        // Returns the item of type T_Model if found, null otherwise.
        T_Model Get_By_Id(int item_id);
    }
}