namespace Veterinary_CRUD_App.Presenters.Common
{
    // This class is used to encapsulate meta-information related to a Data Grid View.
    // This metadata typically includes information about the Binding Source associated with the Data Grid View and
    // configuration details to customize the Data Grid View behavior.
    public class Data_Grid_View_Tag
    {
        // This property represents a key that identifies the Binding Source associated with the Data Grid View.
        public string? Binding_Source_Key { get; set; }

        // This property holds the configuration settings used to customize the Data Grid View behavior.
        public Data_Grid_View_Configuration? Configuration { get; set; }
    }
}