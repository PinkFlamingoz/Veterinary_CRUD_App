namespace Veterinary_CRUD_App.Presenters.Common
{
    // Custom event arguments for events that support cancellation.
    // This class is derived from the standard Event Args.
    // It includes a property "Cancel" which allows event subscribers to indicate that some subsequent process or action (usually the default one in the context of the event) should be cancelled.
    public class Cancelable_Event_Args : EventArgs
    {
        // Gets or sets a value indicating whether the operation or action associated with the event should be cancelled.
        public bool Cancel { get; set; }
    }
}