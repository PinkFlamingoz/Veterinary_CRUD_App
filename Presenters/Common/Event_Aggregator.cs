namespace Veterinary_CRUD_App.Presenters.Common
{
    // The Event_Aggregator class acts as a central hub for events within the application.
    // This class is typically used in applications to decouple different components, allowing them to communicate with each other without directly referencing each other.
    public class Event_Aggregator
    {
        // Singleton instance of the Event_Aggregator.
        // Ensures there's only one centralized instance of this class throughout the application.
        public static readonly Event_Aggregator Instance = new();

        // Event that's raised when there's a request to open a form.
        public event EventHandler<Form_Open_Request_Event_Args>? Request_Open_Form;

        // Method to raise the Request_Open_Form event.
        // Other components can call this method to signal that a form should be opened.
        public void Raise_Request_Open_Form(Form_Open_Request_Event_Args args)
        {
            Request_Open_Form?.Invoke(this, args);
        }
    }
}