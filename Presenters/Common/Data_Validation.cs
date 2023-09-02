using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Veterinary_CRUD_App.Presenters.Common
{
    // Utility class responsible for validating data against DataAnnotations.
    public class Data_Validation
    {
        // Validates the provided data model against its DataAnnotations.
        // If the data is invalid, it throws a ValidationException with the list of error messages.
        public static void Validate_Data(object model)
        {
            // List to store validation results.
            List<ValidationResult> results = new();

            // Context for the model to be validated.
            ValidationContext context = new(model);

            // Attempt to validate the model.
            // If validation succeeds, 'is_valid' will be true. Otherwise, it will be false.
            bool is_valid = Validator.TryValidateObject(model, context, results, true);

            // If the model is valid, simply return.
            if (is_valid) return;

            // If the code reaches here, there are validation errors.
            // We build an error message string from the validation results.
            StringBuilder error_message_builder = new();
            foreach (var item in results)
            {
                error_message_builder.AppendLine(item.ErrorMessage);
            }

            // Throw an exception with the constructed error message.
            throw new ValidationException(error_message_builder.ToString());
        }
    }
}
