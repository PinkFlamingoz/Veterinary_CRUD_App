using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Interfaces.Visits
{
    // Declare an internal interface named 'IVisit_View_Interface'.
    // This interface inherits from 'IBase_View_Interface', implying that any class implementing 'IVisit_View_Interface' must also provide implementations for members declared in 'IBase_View_Interface'.
    internal interface IVisit_View_Interface : IBase_View_Interface
    {
        // VISIT-SPECIFIC PROPERTIES:
        // The[Resettable] attribute(custom) indicates that the value of this property can be reset to some default state.

        // An identifier for the visit.
        [Resettable]
        int I_visit_id { get; set; }

        // An identifier for the pet associated with this visit.
        [Resettable]
        int I_pet_id { get; set; }

        // Type of the visit, args.g., "Regular Checkup", "Emergency", etc.
        [Resettable]
        string I_visit_type { get; set; }

        // The date of the visit.
        [Resettable]
        DateTime I_visit_date { get; set; }

        // A detailed description of the visit, args.g., the reason for the visit or the treatment provided.
        [Resettable]
        string I_visit_description { get; set; }

        // A ComboBox control property that is used to select or display the name of the pet associated with this visit.
        ComboBox I_visit_pet_name_cb { get; set; }
    }
}