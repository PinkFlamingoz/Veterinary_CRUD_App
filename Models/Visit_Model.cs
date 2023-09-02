using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Veterinary_CRUD_App.Interfaces;

namespace Veterinary_CRUD_App.Models
{
    // The Visit_Model class represents the data structure for a visit.
    // The class implements the IIdentifiable interface thats used to get the current selected item id.
    // This class, Visit_Model, is designed to represent a visit with several attributes.
    // It also has properties with get and set accessors for each attribute.
    // The properties have several data annotations (attributes) applied to them for various purposes:
    // - DisplayName: Determines the display name when bound to UI controls.
    // - Required: Indicates that the field must be provided.
    // - StringLength: Restricts the length of the string data.
    // - Range: Restricts the possible range of values.
    // - RegularExpression: Ensures the data matches a specific pattern.
    //  By using these annotations, the application can validate the data for each pet and provide meaningful error messages if the data doesn't meet the criteria.
    public class Visit_Model : IIdentifiable
    {
        // Private fields that will hold the visits's data

        private int visit_id;
        private int pet_id;
        private string pet_name = string.Empty;
        private string visit_type = string.Empty;
        private DateTime visit_date;
        private string visit_description = string.Empty;

        // Get the current id
        public int GET_id
        {
            get => GET_visit_id;
            set => GET_visit_id = value;
        }

        // The visit's unique ID.
        [DisplayName("Visit ID")]
        public int GET_visit_id
        {
            get => visit_id;
            set => visit_id = value;
        }

        // The pet's unique ID.
        [DisplayName("Pet ID")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid pet. A visit must have a valid pet.")]
        public int GET_pet_id
        {
            get => pet_id;
            set => pet_id = value;
        }

        // The pets's name for display only, no validation needed.
        [DisplayName("Pet Name")]
        public string GET_pet_name
        {
            get => pet_name;
            set => pet_name = value;
        }

        // The type of the visit. This is a required field.
        [DisplayName("Visit Type")]
        [Required(ErrorMessage = "Pet Visit Type is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Visit type must be between 2 and 50 characters!")]
        public string GET_visit_type
        {
            get => visit_type;
            set => visit_type = value;
        }

        // The date of the visit. This is a required field.
        [DisplayName("Visit Date")]
        [Required(ErrorMessage = "Pet Visit Date is a must!")]
        public DateTime GET_visit_date
        {
            get => visit_date;
            set => visit_date = value;
        }

        // The description of the visit. This is a required field.
        [DisplayName("Visit Description")]
        [Required(ErrorMessage = "Pet Visit Description is a must!")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Minimum description of 10 characters!")]
        public string GET_visit_description
        {
            get => visit_description;
            set => visit_description = value;
        }
    }
}