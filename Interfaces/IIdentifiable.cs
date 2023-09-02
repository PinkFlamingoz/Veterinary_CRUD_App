namespace Veterinary_CRUD_App.Interfaces
{
    // This interface aims to ensure that any class implementing it will have a GET_id property.
    public interface IIdentifiable
    {
        // A property signature for the current id of an item.
        // Any class that implements this interface is expected to provide an implementation for this property.
        int GET_id { get; set; }
    }
}