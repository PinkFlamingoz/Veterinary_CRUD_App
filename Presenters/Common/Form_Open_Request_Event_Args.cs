namespace Veterinary_CRUD_App.Presenters.Common
{
    // Event arguments class specifically for requesting the opening of a form.
    // This class encapsulates necessary details to initialize and present a specific form, including its associated repository and presenter types.
    public class Form_Open_Request_Event_Args : EventArgs
    {
        // Gets the optional unique ID related to the form's data item (useful for edit scenarios).
        public int? Id { get; }

        // Gets the Type of the form to be opened.
        public Type Form_Type { get; }

        // Gets the Type of the repository responsible for handling data for the form.
        public Type Repository_Type { get; }

        // Gets the Type of the presenter associated with the form.
        // The presenter typically handles the logic for the form's operations.
        public Type Presenter_Type { get; }

        // Constructor to initialize the event arguments with all necessary data.
        public Form_Open_Request_Event_Args(int? id, Type form_type, Type repository_type, Type presenter_type)
        {
            Id = id;
            Form_Type = form_type;
            Repository_Type = repository_type;
            Presenter_Type = presenter_type;
        }

        // Overloaded constructor that initializes the event arguments without an ID.
        // Useful for scenarios where a specific data item's ID isn't needed (args.g., adding a new item).
        public Form_Open_Request_Event_Args(Type form_type, Type repository_type, Type presenter_type)
        : this(null, form_type, repository_type, presenter_type)
        {
        }
    }
}