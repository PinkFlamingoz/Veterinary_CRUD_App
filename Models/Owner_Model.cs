using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Veterinary_CRUD_App.Interfaces;

namespace Veterinary_CRUD_App.Models
{
    // The Owner_Model class represents the data structure for a owner.
    // The class implements the IIdentifiable interface thats used to get the current selected item id.
    // This class, Owner_Model, is designed to represent a owner with several attributes.
    // It also has properties with get and set accessors for each attribute.
    // The properties have several data annotations (attributes) applied to them for various purposes:
    // - DisplayName: Determines the display name when bound to UI controls.
    // - Required: Indicates that the field must be provided.
    // - StringLength: Restricts the length of the string data.
    // - Range: Restricts the possible range of values.
    // - RegularExpression: Ensures the data matches a specific pattern.
    //  By using these annotations, the application can validate the data for each pet and provide meaningful error messages if the data doesn't meet the criteria.
    public class Owner_Model : IIdentifiable
    {
        //  Private fields that will hold the owners's data

        private int owner_id;
        private string owner_name = string.Empty;
        private string owner_phone = string.Empty;
        private string owner_email = string.Empty;

        // Get the current id
        public int GET_id
        {
            get => GET_owner_id;
            set => GET_owner_id = value;
        }

        // The owner's unique ID.
        [DisplayName("Owner ID")]
        public int GET_owner_id
        {
            get => owner_id;
            set => owner_id = value;
        }

        // The owner's name. This is a required field.
        [DisplayName("Owner Name")]
        [Required(ErrorMessage = "Owner name is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Owner name must be between 2 and 50 characters!")]
        public string GET_owner_name
        {
            get => owner_name;
            set => owner_name = value;
        }

        // The owner's phone number. This is a required field.
        [DisplayName("Owner Phone")]
        [Required(ErrorMessage = "Owner phone is a must!")]
        [StringLength(20, ErrorMessage = "Owner phone must be less than 20 characters!")]
        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Invalid phone number")]
        public string GET_owner_phone
        {
            get => owner_phone;
            set => owner_phone = value;
        }

        // The owner's email. This is a required field.
        [DisplayName("Owner Email")]
        [Required(ErrorMessage = "Owner email is a must!")]
        [StringLength(100, ErrorMessage = "Owner email must be less than 100 characters!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string GET_owner_email
        {
            get => owner_email;
            set => owner_email = value;
        }
    }
}