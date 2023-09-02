using System.ComponentModel;
using Veterinary_CRUD_App.Interfaces.Visits;
using Veterinary_CRUD_App.Models;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Presenters
{
    internal class Visit_Form_Presenter : Base_Form_Presenter<Visit_Model, IVisit_View_Interface, IVisit_Repository_Interface>
    {
        public Visit_Form_Presenter(IVisit_View_Interface view, IVisit_Repository_Interface repository)
        : base(view, repository)
        {
            // Grid view configurations ------------------------------------------------------------------------------------------

            var main_grid_view = new Data_Grid_View_Configuration
            {
                Key = "main_grid_view_visit",
                Data_Grid_View_Control = view.I_main_data_grid_view,
                Load_Function = () => repository.Get_All().Cast<object>(),
                Columns_To_Hide = new List<string>
                {
                    "GET_pet_id",
                    "GET_id",
                }
            };
            Register_Grid_View(main_grid_view);
            Current_binding_source_key = "main_grid_view_visit";

            // Grid view configurations ------------------------------------------------------------------------------------------

            // Combo Box configurations ------------------------------------------------------------------------------------------

            var pets_combo_box = new Combo_Box_Configuration
            {
                Key = "pets_combo_box",
                Combo_Box_Control = view.I_visit_pet_name_cb,
                Load_Function = () =>
                {
                    var pets = new BindingList<Pet_Model>(repository.Get_All_Pets().ToList());
                    var combo_box_items = new List<Custom_Combo_Box>
                    {
                        new Custom_Combo_Box() { Name = "--Select a Pet--", ID = 0 }
                    };

                    combo_box_items.AddRange(pets.Select(pet => new Custom_Combo_Box
                    {
                        Name = pet.GET_pet_name,
                        ID = pet.GET_pet_id
                    }));

                    return combo_box_items;
                }
            };
            Register_ComboBox(pets_combo_box);

            // Combo Box configurations ------------------------------------------------------------------------------------------

            Initialize_Form_Presenter();
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Override the Open Form function from the base form presenter
        protected override void Open_Form(int? item_id, Type form_type, Type repository_type, Type presenter_type)
        {
            base.Open_Form(item_id, form_type, repository_type, presenter_type);
            if (item_id.HasValue)
            {
                Load_Specific_Grid("pet_visits_grid_view");
            }
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}