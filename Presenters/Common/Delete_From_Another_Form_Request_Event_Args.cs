namespace Veterinary_CRUD_App.Presenters.Common
{
    // Event arguments class specifically for requesting the deletion of a data item from another form.
    // This class contains the necessary data to identify and process the delete request, such as the ID of the item to be deleted and the type of the repository handling the data.
    public class Delete_From_Another_Form_Request_Event_Args : EventArgs
    {
        // Gets the unique ID of the item to be deleted.
        public int Id { get; }

        // Gets the Type of the repository responsible for handling the deletion.
        // This provides context on where or how the item should be deleted from the data source.
        public Type Repository_Type { get; }

        // Constructor to initialize the event arguments with the necessary data.
        public Delete_From_Another_Form_Request_Event_Args(int id, Type repository_type)
        {
            Id = id;
            Repository_Type = repository_type;
        }
    }
}