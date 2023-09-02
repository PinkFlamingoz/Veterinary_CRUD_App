namespace Veterinary_CRUD_App.Presenters.Common
{
    // Configuration class that encapsulates settings and functionality for a Combo Box control.
    // This class serves as a blueprint for setting up Combo Box controls in the application, providing a way to map a key to a specific Combo Box control and specify the function that loads its items.
    public class Combo_Box_Configuration
    {
        // The unique key associated with the Combo Box.
        // Useful for identifying and differentiating between multiple Combo Box controls.
        public required string Key { get; set; }

        // The Combo Box control associated with this configuration.
        public required ComboBox Combo_Box_Control { get; set; }

        // The function that loads the items into the Combo Box.
        // This delegate (or function pointer) provides a way to specify which method will be called to load the Combo Box items.
        // The function should return a collection of Custom_Combo_Box items.
        public required Func<IEnumerable<Custom_Combo_Box>> Load_Function { get; set; }
    }
}