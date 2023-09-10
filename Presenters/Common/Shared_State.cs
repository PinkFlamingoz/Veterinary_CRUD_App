namespace Veterinary_CRUD_App.Presenters.Common
{
    // A static class to store shared/global state for the application.
    public static class Shared_State
    {
        // Boolean flag indicating if the application is in "edit" mode.
        public static bool Is_edit { get; set; }

        // The ID of the currently selected or edited item.
        public static int? Current_item_id { get; set; }

        // A collection that maps string keys to Binding Source objects.
        // Associating named data sources to their respective grid views.
        public static Dictionary<string, BindingSource> Data_Grid_View_Binding_sources { get; set; } = new Dictionary<string, BindingSource>();

        // A collection that maps string keys to functions that return collections of objects.
        // Loading data into the data grid views.
        public static Dictionary<string, Func<IEnumerable<object>>> Data_Grid_View_Load_functions { get; set; } = new Dictionary<string, Func<IEnumerable<object>>>();

        // A list containing Data Grid View objects that are currently subscribed to events.
        // Facilitates centralized management and unsubscription from events.
        public static List<DataGridView> Subscribed_Data_Grid_Views { get; set; } = new List<DataGridView>();

        // A collection that maps string keys to Combo_Box_Configuration objects.
        // Configurations/settings associated with Combo Boxes in the application.
        public static Dictionary<string, Combo_Box_Configuration> Combo_Box_Configurations { get; private set; } = new Dictionary<string, Combo_Box_Configuration>();
    }
}