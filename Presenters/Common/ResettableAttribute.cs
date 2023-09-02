namespace Veterinary_CRUD_App.Presenters.Common
{
    // Specifies that the custom attribute can only be applied to properties and each property can have only one instance of this attribute.
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ResettableAttribute : Attribute
    {
    }
}
