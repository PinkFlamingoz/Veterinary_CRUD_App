using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Interfaces.Owner
{
    // Declare an internal interface named 'IOwner_View_Interface'.
    // This interface inherits from 'IBase_View_Interface', implying that any class implementing 'IOwner_View_Interface' must also provide implementations for members declared in 'IBase_View_Interface'.
    internal interface IOwner_View_Interface : IBase_View_Interface
    {
        // OWNER-SPECIFIC PROPERTIES:
        // The[Resettable] attribute(custom) indicates that the value of this property can be reset to some default state.

        // An identifier for the OWNER.
        [Resettable]
        int I_owner_id { get; set; }

        // Owners name
        [Resettable]
        string I_owner_name { get; set; }

        // Owners phone number
        [Resettable]
        string I_owner_phone { get; set; }

        // Owners email
        [Resettable]
        string I_owner_email { get; set; }
    }
}