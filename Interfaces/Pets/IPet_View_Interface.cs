using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Interfaces.Pets
{
    // Declare an internal interface named 'IPet_View_Interface'.
    // This interface inherits from 'IBase_View_Interface', meaning any class implementing 'IPet_View_Interface' should also provide implementations for methods and properties defined in 'IBase_View_Interface'.
    internal interface IPet_View_Interface : IBase_View_Interface
    {
        // PET-SPECIFIC PROPERTIES:
        // The[Resettable] attribute(custom) indicates that the value of this property can be reset to some default state.

        // An identifier for the pet.
        [Resettable]
        int I_pet_id { get; set; }

        // An identifier for the pet's owner.
        [Resettable]
        int I_owner_id { get; set; }

        // Pet's name.
        [Resettable]
        string I_pet_name { get; set; }

        // Type or breed of the pet.
        [Resettable]
        string I_pet_type { get; set; }

        // Color of the pet.
        [Resettable]
        string I_pet_color { get; set; }

        // Age of the pet.
        [Resettable]
        int I_pet_age { get; set; }

        // Sex/gender of the pet.
        [Resettable]
        string I_pet_sex { get; set; }

        // Birthdate of the pet.
        [Resettable]
        DateTime I_pet_birthdate { get; set; }

        // File path or URL to the pet's picture.
        [Resettable]
        string I_pet_picture { get; set; }

        // Represents a Combo Box control to select/display the owner's name.
        MaterialSkin.Controls.MaterialComboBox I_pet_owner_name_cb { get; set; }

        // EVENT DECLARATIONS:

        // Event triggered when there's a request to add an image (for the pet).
        event EventHandler? Add_Image_Event;
    }
}