using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Interfaces
{
    // Declaring an internal interface named "IBase_View_Interface".
    // Being 'internal', it is accessible only within the assembly it's declared in.
    // The interface IBase_View_Interface provides a contract or a blueprint that concrete classes should follow if they decide to implement this interface.
    // In a typical Model-View-Presenter(MVP) or Model-View-Controller(MVC) pattern, this interface would likely serve as the base for various views(or UI forms/screens) in the application.
    // It offers essential properties and methods for data display, user interaction, and event handling.
    internal interface IBase_View_Interface
    {
        // PROPERTY DECLARATIONS:

        // Represents the primary DataGridView (a UI control used to display data in a grid format).
        DataGridView I_main_data_grid_view { get; set; }

        // Represents a secondary DataGridView, showing detailed info related to the primary grid.
        DataGridView? I_details_data_grid_view { get; set; }

        // Represents the search value entered by the user for filtering data.
        string I_search_value { get; set; }

        // Indicates if the current operation is in edit mode or not.
        bool I_is_edit { get; set; }

        // Used to store or display a message, to provide feedback to the user.
        string I_message { get; set; }

        // Get the main Data Grid View key
        string I_Data_Grid_View_Key { get; set; }

        // EVENT DECLARATIONS:

        // Event triggered when a search operation is initiated.
        event EventHandler? Search_Event;

        // Event triggered when adding a new record.
        event EventHandler? Add_New_Event;

        // Event triggered when editing an existing record.
        event EventHandler<Cancelable_Event_Args>? Edit_Event;

        // Event triggered when saving a record.
        event EventHandler<Cancelable_Event_Args>? Save_Event;

        // Event triggered when deleting a record.
        event EventHandler<Cancelable_Event_Args>? Delete_Event;

        // Event triggered to cancel an ongoing operation.
        event EventHandler? Cancel_Event;

        // Event triggered to request opening of another form or window.
        event Action<Form_Open_Request_Event_Args>? Open_Form_Event;

        // Event triggered to request deletion of an item from another form or window.
        event Action<Delete_From_Another_Form_Request_Event_Args>? Delete_Item_From_Another_Form_Event;

        // Event used for validating the selection within a Combo Box (a dropdown list UI control).
        event Func<ComboBox, bool>? Validate_Combo_Box_Selection_Event;

        // FUNCTION DECLARATIONS:

        // Hide specific columns in the given Data Grid View.
        // This is useful for hiding data columns that the user doesn't need to see.
        void Hide_Data_Grid_View_Columns(DataGridView target_data_grid_view, IEnumerable<string> column_names);

        // Display the main page tab.
        void Show_List_Tab_Page();

        // Display details of a selected record, aka show the second page tab.
        void Show_Details_Tab_Page(string title = "");

        // Display the Data Grid View, making it visible.
        void Show_Data_Grid_View_Details();

        // Hide the Data Grid View, making it invisible.
        void Hide_Data_Grid_View_Details();

        //Display the user interface, making it visible.
        void Show();
    }
}