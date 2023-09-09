namespace Veterinary_CRUD_App.Presenters.Common
{
    // This class is used to encapsulate meta-information related to a DataGridView.
    // This metadata typically includes information about the binding source associated with the DataGridView and
    // configuration details to customize the DataGridView behavior.
    public class Data_Grid_View_Tag
    {
        // This property represents a key that identifies the binding source associated with the DataGridView.
        public string? Binding_Source_Key { get; set; }

        // This property holds the configuration settings used to customize the DataGridView's behavior.
        public Data_Grid_View_Configuration? Configuration { get; set; }
    }
}