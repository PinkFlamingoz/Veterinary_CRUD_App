using System.ComponentModel;
using Veterinary_CRUD_App.Interfaces.Pets;
using Veterinary_CRUD_App.Models;
using Veterinary_CRUD_App.Presenters.Common;
using Veterinary_CRUD_App.Views;

namespace Veterinary_CRUD_App.Presenters
{
    internal class Pet_Form_Presenter : Base_Form_Presenter<Pet_Model, IPet_View_Interface, IPet_Repository_Interface>
    {
        public Pet_Form_Presenter(IPet_View_Interface view, IPet_Repository_Interface repository)
        : base(view, repository)
        {
            // Grid view configurations ------------------------------------------------------------------------------------------

            var main_grid_view = new Data_Grid_View_Configuration
            {
                Key = "main_grid_view_pet",
                Data_Grid_View_Control = view.I_main_data_grid_view,
                Load_Function = () => repository.Get_All().Cast<object>(),
                Columns_To_Hide = new List<string>
                {
                    "GET_pet_picture",
                    "GET_owner_id",
                    "GET_id",
                }
            };
            Register_Grid_View(main_grid_view);
            Current_binding_source_key = "main_grid_view_pet";
            view.I_Data_Grid_View_Key = "main_grid_view_pet";

            var pet_visits_grid_view = new Data_Grid_View_Configuration
            {
                Key = "pet_visits_grid_view",
                Data_Grid_View_Control = view.I_details_data_grid_view ?? throw new InvalidOperationException("Details data grid view is not initialized."),
                Load_Function = () =>
                {
                    if (Shared_State.Current_item_id.HasValue)
                    {
                        return repository.Get_All_Visits_For_Pet(Shared_State.Current_item_id.Value).Cast<object>();
                    }
                    // If Current_item_id is null or not set, try using the selected item
                    var item = Get_Current_Selected_Item_From_Data_Grid_View(out bool is_item_selectet);
                    if (is_item_selectet)
                    {
                        return repository.Get_All_Visits_For_Pet(item.GET_pet_id).Cast<object>();
                    }
                    // If both are null, return an empty list
                    return new List<object>();
                },

                Columns_To_Hide = new List<string>
                {
                    "GET_pet_id",
                    "GET_pet_name",
                    "GET_id",
                }
            };
            Register_Grid_View(pet_visits_grid_view);

            // Grid view configurations ------------------------------------------------------------------------------------------

            // Combo Box configurations ------------------------------------------------------------------------------------------

            var owner_combo_box = new Combo_Box_Configuration
            {
                Key = "owner_combo_box",
                Combo_Box_Control = view.I_pet_owner_name_cb,
                Load_Function = () =>
                {
                    var owners = new BindingList<Owner_Model>(repository.Get_All_Owners().ToList());
                    var combo_box_items = new List<Custom_Combo_Box>
                    {
                       new Custom_Combo_Box() { Name = "--Select an Option--", Id = 0}
                    };

                    combo_box_items.AddRange(owners.Select(owner => new Custom_Combo_Box
                    {
                        Name = owner.GET_owner_name,
                        Id = owner.GET_owner_id
                    }));

                    return combo_box_items;
                }
            };
            Register_ComboBox(owner_combo_box);

            // Combo Box configurations ------------------------------------------------------------------------------------------

            Initialize_Form_Presenter();
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events
        protected override void Subscribe_Events_To_Functions()
        {
            base.Subscribe_Events_To_Functions();

            view_interface.Add_Image_Event += Add_Image;
        }

        // Unsubscribe buttons from events
        protected override void Unsubscribe_Events_To_Functions()
        {
            base.Unsubscribe_Events_To_Functions();

            view_interface.Add_Image_Event -= Add_Image;
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Override the Edit Item function from the base form presenter
        protected override void Edit_Item(object? sender, Cancelable_Event_Args e)
        {
            base.Edit_Item(sender, e);
            if (e.Cancel) return;

            Load_Specific_Grid("pet_visits_grid_view");
        }

        // Override the Open Form function from the base form presenter
        protected override void Open_Form(int? item_id, Type form_type, Type repository_type, Type presenter_type)
        {
            base.Open_Form(item_id, form_type, repository_type, presenter_type);

            if (item_id.HasValue)
            {
                switch (form_type.Name)
                {
                    case nameof(Owner_Form):
                        Load_Specific_Grid("pets_of_owner_grid_view");
                        break;

                    default:
                        break;
                }
            }
        }

        // Event functions ---------------------------------------------------------------------------------------------------

        // Add an image for the pet ------------------------------------------

        // Constants
        // image_filter: It's a filter string used for the open file dialog to restrict the files to be displayed (only image files like jpg, jpeg, png, bmp).
        // relative_image_folder: Relative path where the selected images should be stored in relation to the application's startup path.
        // database_image_folder: Name of the folder that the application's database might use to retrieve the images.

        private const string image_filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
        private const string relative_image_folder = @"..\..\..\Resources\Images\Pet_Images";
        private const string database_image_folder = "Pet_Images";

        // Show image selection dialog and return selected path
        // This method opens a file selection dialog that is pre-filtered to only show image files.
        // If the user selects an image and presses 'OK', it returns the full path of the selected image.
        // If the user cancels the dialog or doesn't select an image, it returns an empty string.
        private static string Show_Image_Dialog()
        {
            using (OpenFileDialog open_file_dialog = new OpenFileDialog())
            {
                open_file_dialog.Title = "Select a pet image";
                open_file_dialog.Filter = image_filter;
                open_file_dialog.Multiselect = false;

                if (open_file_dialog.ShowDialog() == DialogResult.OK)
                {
                    return open_file_dialog.FileName;
                }
            }

            return string.Empty;
        }

        // Ensure destination folder exists and return destination path
        // It creates the destination folder if it doesn't exist, using the relative path (relative_image_folder).
        // Then, it returns the intended path where the selected image should be copied in the application's directory.
        private static string Prepare_Destination_Path(string selected_image_path)
        {
            string destination_folder = Path.Combine(Application.StartupPath, relative_image_folder);

            if (!Directory.Exists(destination_folder))
            {
                Directory.CreateDirectory(destination_folder);
            }

            return Path.Combine(destination_folder, Path.GetFileName(selected_image_path));
        }

        // Copy selected image to destination path
        // This method attempts to copy the selected image from its original location to the intended folder (destination).
        // If there's any exception (error) during copying, it logs that exception to the console.
        private static void Copy_Image_To_Destination_Folder(string sourcePath, string destinationPath)
        {
            try
            {
                File.Copy(sourcePath, destinationPath);
            }
            catch (Exception ex)
            {
                // Log or handle any errors that occur during file copy
                Console.WriteLine($"Error copying file: {ex.Message}");
            }
        }

        // Main method to add an image
        // First, it prompts the user to select an image using the Show_Image_Dialog method.
        // If a valid image path is returned (i.e., the user selected an image), it prepares the destination path.
        // Then, it checks if an image with the same name already exists in the destination folder.
        // If not, it copies the image to the destination folder.
        // After successfully copying the image, it updates a view's interface (seemingly a form or a control in a UI) to display the copied image.
        private void Add_Image(object? sender, EventArgs e)
        {
            string selected_image_path = Show_Image_Dialog();

            if (!string.IsNullOrEmpty(selected_image_path))
            {
                string destination_path = Prepare_Destination_Path(selected_image_path);

                if (!File.Exists(destination_path))
                {
                    Copy_Image_To_Destination_Folder(selected_image_path, destination_path);

                    string relative_path = Path.Combine(database_image_folder, Path.GetFileName(selected_image_path));
                    view_interface.I_pet_picture = relative_path;
                }
                else
                {
                    MessageBox.Show(Messages.Image_Exists_Response, Messages.Image_Exists, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Add an image for the pet ------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}