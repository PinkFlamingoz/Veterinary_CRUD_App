namespace Veterinary_CRUD_App.Presenters.Common
{
    // Specifies that the custom attribute can only be applied to properties and each property can have only one instance of this attribute.
    // We use this so we can tag variables that can be reseted aka set to their default state
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ResettableAttribute : Attribute
    {
    }
}