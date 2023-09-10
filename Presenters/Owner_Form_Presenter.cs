using Veterinary_CRUD_App.Interfaces.Owner;
using Veterinary_CRUD_App.Models;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Presenters
{
    internal class Owner_Form_Presenter : Base_Form_Presenter<Owner_Model, IOwner_View_Interface, IOwner_Repository_Interface>
    {
        // Constructor
        public Owner_Form_Presenter(IOwner_View_Interface view, IOwner_Repository_Interface repository)
        : base(view, repository)
        {
            // Grid view configurations ------------------------------------------------------------------------------------------

            var main_grid_view = new Data_Grid_View_Configuration
            {
                Key = "main_grid_view_owner",
                Data_Grid_View_Control = view.I_main_data_grid_view,
                Load_Function = () => repository.Get_All().Cast<object>(),
                Columns_To_Hide = new List<string>
                {
                    "GET_id",
                }
            };
            Register_Grid_View(main_grid_view);
            Current_binding_source_key = "main_grid_view_owner";
            view.I_Data_Grid_View_Key = "main_grid_view_owner";

            var pets_of_owner_grid_view = new Data_Grid_View_Configuration
            {
                Key = "pets_of_owner_grid_view",
                Data_Grid_View_Control = view.I_details_data_grid_view ?? throw new InvalidOperationException("Details Data Grid View is not initialized."),
                Load_Function = () =>
                {
                    if (Shared_State.Current_item_id.HasValue)
                    {
                        return repository.Get_All_Pets_For_Owner(Shared_State.Current_item_id.Value).Cast<object>();
                    }
                    // If Current_item_id is null or not set, try using the selected item
                    var item = Get_Current_Selected_Item_From_Data_Grid_View(out bool is_item_selectet);
                    if (is_item_selectet)
                    {
                        return repository.Get_All_Pets_For_Owner(item.GET_owner_id).Cast<object>();
                    }
                    // If both are null, return an empty list
                    return new List<object>();
                },

                Columns_To_Hide = new List<string>
                {
                    "GET_owner_id",
                    "GET_owner_name",
                    "GET_pet_picture",
                    "GET_id",
                }
            };
            Register_Grid_View(pets_of_owner_grid_view);

            // Grid view configurations ------------------------------------------------------------------------------------------

            Initialize_Form_Presenter();
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Override the Edit Item function from the base form presenter
        protected override void Edit_Item(object? sender, Cancelable_Event_Args e)
        {
            base.Edit_Item(sender, e);
            if (e.Cancel) return;
            Load_Specific_Data_Grid_View("pets_of_owner_grid_view");
        }

        // Override the Open Form function from the base form presenter
        protected override void Open_Form(int? item_id, Type form_type, Type repository_type, Type presenter_type)
        {
            base.Open_Form(item_id, form_type, repository_type, presenter_type);

            if (item_id.HasValue)
            {
                Load_Specific_Data_Grid_View("pet_visits_grid_view");
            }
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}