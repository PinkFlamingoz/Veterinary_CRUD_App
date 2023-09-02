namespace Veterinary_CRUD_App.Presenters.Common
{
    //  Configuration class that encapsulates settings and functionality for a Data Grid View control.
    // This class provides settings for setting up and customizing Data Grid View controls in the application.
    public class Data_Grid_View_Configuration
    { 
        // The unique key associated with the Data Grid View.
        // Useful for identifying and differentiating between multiple Data Grid View controls.
        public required string Key { get; set; }

        // The Data Grid View control associated with this configuration.
        public required DataGridView Data_Grid_View_Control { get; set; }

        // The function to load data into the Data Grid View.
        // This delegate (or function pointer) points to the method that fetches the data to be populated into the Data Grid View.
        public required Func<IEnumerable<object>> Load_Function { get; set; }

        // A list of column names to hide in the Data Grid View.
        // Allows for specific columns to be hidden from view when rendering the Data Grid View.
        public required List<string> Columns_To_Hide { get; set; }
    }
}