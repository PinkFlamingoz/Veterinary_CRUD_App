using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Veterinary_CRUD_App.Interfaces;

namespace Veterinary_CRUD_App.Models
{
    // The Pet_Model class represents the data structure for a pet.
    // The class implements the IIdentifiable interface thats used to get the current selected item id.
    // This class, Pet_Model, is designed to represent a Pet with several attributes.
    // It also has properties with get and set accessors for each attribute.
    // The properties have several data annotations (attributes) applied to them for various purposes:
    // - DisplayName: Determines the display name when bound to UI controls.
    // - Required: Indicates that the field must be provided.
    // - StringLength: Restricts the length of the string data.
    // - Range: Restricts the possible range of values.
    // - RegularExpression: Ensures the data matches a specific pattern.
    //  By using these annotations, the application can validate the data for each pet and provide meaningful error messages if the data doesn't meet the criteria.
    public class Pet_Model : IIdentifiable
    {
        // Private fields that will hold the pet's data

        private int pet_id;
        private int owner_id;
        private string pet_owner_name = string.Empty;
        private string pet_name = string.Empty;
        private string pet_type = string.Empty;
        private string pet_color = string.Empty;
        private int pet_age;
        private string pet_sex = string.Empty;
        private DateTime pet_birthdate;
        private string? pet_picture = null;

        // Get the current id
        public int GET_id
        {
            get => GET_pet_id;
            set => GET_pet_id = value;
        }

        // The pet's unique ID.
        [DisplayName("Pet ID")]
        public int GET_pet_id
        {
            get => pet_id;
            set => pet_id = value;
        }

        // The owner's unique ID.
        [DisplayName("Owner ID")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid owner. A pet must have a valid owner.")]
        public int GET_owner_id
        {
            get => owner_id;
            set => owner_id = value;
        }

        // The owner's name for display only, no validation needed.
        [DisplayName("Owner Name")]
        public string GET_owner_name
        {
            get => pet_owner_name;
            set => pet_owner_name = value;
        }

        // The pet's name. This is a required field.
        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet name is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pet name must be between 2 and 50 characters!")]
        public string GET_pet_name
        {
            get => pet_name;
            set => pet_name = value;
        }

        // The pet's type. This is a required field.
        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pet type must be between 2 and 50 characters!")]
        public string GET_pet_type
        {
            get => pet_type;
            set => pet_type = value;
        }

        // The pet's color. This is a required field.
        [DisplayName("Pet Color")]
        [Required(ErrorMessage = "Pet color is a must!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Pet color must be between 2 and 50 characters!")]
        public string GET_pet_color
        {
            get => pet_color;
            set => pet_color = value;
        }

        // The pet's age. This is a required field.
        [DisplayName("Pet Age")]
        [Required(ErrorMessage = "Pet age is a must!")]
        [Range(1, 100, ErrorMessage = "Pet age must be between 1 and 100!")]
        public int GET_pet_age
        {
            get => pet_age;
            set => pet_age = value;
        }

        // The pet's sex. This is a required field.
        [DisplayName("Pet Sex")]
        [Required(ErrorMessage = "Pet sex is a must!")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Pet sex must be between 1 letter long!")]
        [RegularExpression("^[MmFf]$", ErrorMessage = "Pet sex must be either M or F (case insensitive).")]
        public string GET_pet_sex
        {
            get => pet_sex;
            set => pet_sex = value.ToUpperInvariant();
        }

        // The pet's birthdate. This is a required field.
        [DisplayName("Pet Birth Date")]
        [Required(ErrorMessage = "Pet Birthday is a must!")]
        public DateTime GET_pet_birthdate
        {
            get => pet_birthdate;
            set => pet_birthdate = value;
        }

        // The path to the pet's picture. This is a required field.
        [DisplayName("Pet Picture")]
        [StringLength(255, ErrorMessage = "Path to picture too long!")]
        public string? GET_pet_picture
        {
            get => pet_picture;
            set => pet_picture = value;
        }
    }
}