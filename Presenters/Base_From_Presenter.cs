using System.Reflection;
using Veterinary_CRUD_App.Interfaces;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Presenters
{
    internal abstract class Base_Form_Presenter<T_Model, T_View_Interface, T_Repository_Interface>
    where T_Model : class, IIdentifiable, new()
    where T_View_Interface : class, IBase_View_Interface
    where T_Repository_Interface : class, IBase_Repository_Interface<T_Model>
    {
        // Common values

        protected readonly T_View_Interface view_interface;
        protected readonly T_Repository_Interface repository_interface;
        private IEnumerable<T_Model>? item_list;

        // Used for setting the initial binding source key on initialization and then getting the current selected one
        protected string Current_binding_source_key { get; set; } = string.Empty;

        // Constructor
        protected Base_Form_Presenter(T_View_Interface view_interface, T_Repository_Interface repository_interface)
        {
            this.view_interface = view_interface;
            this.repository_interface = repository_interface;
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Initialize function for the derived classes to call
        protected void Initialize_Form_Presenter()
        {
            Subscribe_Events_To_Functions();
            Load_Specific_Grid(Current_binding_source_key);
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events
        // # OVERRIDEN IN THE DERIVED CLASSES
        protected virtual void Subscribe_Events_To_Functions()
        {
            view_interface.Search_Event += Search_Item;
            view_interface.Add_New_Event += Add_New_Item;
            view_interface.Edit_Event += Edit_Item;
            view_interface.Delete_Event += Delete_Item;
            view_interface.Save_Event += Save_Item;
            view_interface.Cancel_Event += Cancel_Action;
            view_interface.Open_Form_Event += Open_Form;
            view_interface.Delete_Item_From_Another_Form_Event += Delete_Item_From_Another_Form;
            view_interface.Validate_Combo_Box_Selection_Event += Is_Valid_Selection_Combo_Box;
            if (view_interface is Form form_view)
            {
                form_view.FormClosed += On_Form_Closed;
            }
        }

        // Unsubscribe buttons from events
        // # OVERRIDEN IN THE DERIVED CLASSES
        protected virtual void Unsubscribe_Events_To_Functions()
        {
            view_interface.Search_Event -= Search_Item;
            view_interface.Add_New_Event -= Add_New_Item;
            view_interface.Edit_Event -= Edit_Item;
            view_interface.Delete_Event -= Delete_Item;
            view_interface.Save_Event -= Save_Item;
            view_interface.Cancel_Event -= Cancel_Action;
            view_interface.Open_Form_Event -= Open_Form;
            view_interface.Delete_Item_From_Another_Form_Event -= Delete_Item_From_Another_Form;
            view_interface.Validate_Combo_Box_Selection_Event -= Is_Valid_Selection_Combo_Box;

            foreach (var grid_view in Shared_State.Subscribed_Grid_Views)
            {
                Unsubscribe_From_Data_Binding_Complete(grid_view);
                Unsubscribe_From_Grid_View_Selection_Changed(grid_view);
            }

            if (view_interface is Form form_view)
            {
                form_view.FormClosed -= On_Form_Closed;
            }
        }

        // On form Close unsubscribe the events
        private void On_Form_Closed(object? sender, FormClosedEventArgs args)
        {
            if (sender is Form)
            {
                Unsubscribe_Events_To_Functions();
            }
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Helper functions --------------------------------------------------------------------------------------------------

        // Get a binding source
        // Get_Binding_Source: This method tries to get a BindingSource object by a given key from a dictionary.
        // If the key is found, it returns the corresponding BindingSource.
        // If not, it throws an exception.
        private static BindingSource Get_Binding_Source(string key)
        {
            if (Shared_State.Data_Grid_View_Binding_sources.TryGetValue(key, out var binding_source))
            {
                return binding_source;
            }
            throw new KeyNotFoundException($"BindingSource with key '{key}' not found.");
        }

        // Get the current selected item from the Data Grid View
        // Get_Current_Selected_Item_From_Data_Grid_View: Returns the currently selected item from a DataGridView bound to a specific BindingSource.
        // If no valid item is selected or the selected item is not of the expected type T_Model, a warning is shown to the user and the item_selected flag is set to false.
        protected T_Model Get_Current_Selected_Item_From_Data_Grid_View(out bool item_selected)
        {
            if (Get_Binding_Source(Current_binding_source_key).Current is not T_Model selected_item)
            {
                MessageBox.Show(Messages.Select_Warning, Messages.Warning_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                item_selected = false;
                return new T_Model();
            }

            item_selected = true;
            return selected_item;
        }

        // Load the item to the view
        // Load_Item_To_View: Assigns the properties of the given T_Model item to the view interface, essentially populating the view with data from the selected item.
        protected void Load_Item_To_View(T_Model item)
        {
            Utilities.Assign_Properties(item, view_interface);
        }

        // Helper functions --------------------------------------------------------------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Shared helper functions --------------------------------

        // Clear the view aka reset the properties on the page details tab
        private void Clear_View()
        {
            Current_binding_source_key = view_interface.I_Data_Grid_View_Key;
            Utilities.Reset_Properties(view_interface);
        }

        // Confirm deletion option
        private static bool Confirm_Deletion()
        {
            var answer = MessageBox.Show(Messages.Delete_confirmation, Messages.Warning_title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return answer == DialogResult.Yes;
        }

        // Shared helper functions --------------------------------

        // Search a specific item then load it on the data grid view
        // Search_Item: Based on the search value provided in the view interface, this method either searches for items matching the value or fetches all items.
        // The results are then bound to the DataGridView.
        private void Search_Item(object? sender, EventArgs args)
        {
            bool empty = string.IsNullOrWhiteSpace(view_interface.I_search_value);
            if (!empty)
            {
                item_list = repository_interface.Get_By_Value(view_interface.I_search_value);
            }
            else
            {
                item_list = repository_interface.Get_All();
            }

            Get_Binding_Source(Current_binding_source_key).DataSource = item_list;
        }

        // Add a new item shares the functionality with the edit item, so here we just set that the item is not being edited but in theory we are adding a new item
        // Add_New_Item & Edit_Item: Both methods deal with the user's intention to add or edit an item.
        // The main difference is the state they set in the view interface (I_is_edit).
        // Add_New_Item hides the DataGridView for item addition, while Edit_Item loads the selected item into the view and sets it up for editing.
        private void Add_New_Item(object? sender, EventArgs args)
        {
            view_interface.I_is_edit = false;
            view_interface.Hide_Data_Grid_View();
        }

        // Edit a new item shares the functionality with the add item, so here we just set that the item is being edited but in theory we are editing a new item
        // # OVERRIDEN IN THE DERIVED CLASSES
        // Add_New_Item & Edit_Item: Both methods deal with the user's intention to add or edit an item.
        // The main difference is the state they set in the view interface (I_is_edit).
        // Add_New_Item hides the DataGridView for item addition, while Edit_Item loads the selected item into the view and sets it up for editing.
        protected virtual void Edit_Item(object? sender, Cancelable_Event_Args args)
        {
            Shared_State.Current_item_id = null;

            var item = Get_Current_Selected_Item_From_Data_Grid_View(out bool is_item_selectet);
            if (is_item_selectet)
            {
                Load_Item_To_View(item);
                view_interface.I_is_edit = true;
                view_interface.Show_Data_Grid_View();
            }
            else
            {
                args.Cancel = true;
            }
        }

        // Delete an item ----------------------------------------------------
        // Delete_Item:
        // Fetches the currently selected item.
        // If confirmed by the user, attempts to delete the item.
        // On success, refreshes data and displays a success message.
        // On failure, displays an error message.

        // Helper functions for deleting an item ------------------

        // Try to delete the item
        private bool Try_Delete_Item(int item_id)
        {
            try
            {
                repository_interface.Delete(item_id);
                return true;
            }
            catch (TargetInvocationException ex)
            {
                Console.WriteLine($"Failed to delete item with ID {item_id} from the repository. Error: {ex.InnerException?.Message ?? ex.Message}");
                return false;
            }
        }

        // Perform the deletion
        private void Perform_Deletion(int item_id, Cancelable_Event_Args args)
        {
            if (Try_Delete_Item(item_id))
            {
                Handle_Delete_Success();
            }
            else
            {
                Handle_Delete_Failure(args);
            }
        }

        // Handle the delete success and refresh the data
        private void Handle_Delete_Success()
        {
            view_interface.I_message = Messages.Delete_success;
            Load_All_DataGridViews();
            Load_All_ComboBoxes();
        }

        // Handle the delete failure set the cancel event to true so we don't go through with the even
        private void Handle_Delete_Failure(Cancelable_Event_Args args)
        {
            view_interface.I_message = Messages.Delete_fail;
            args.Cancel = true;
        }

        // From the model get the its id of the returned selected item
        protected static int Get_Identifier_From_Item(T_Model item)
        {
            return item.GET_id;
        }

        // Helper functions for deleting an item ------------------

        // Main Method for deleting an item
        private void Delete_Item(object? sender, Cancelable_Event_Args args)
        {
            var item = Get_Current_Selected_Item_From_Data_Grid_View(out bool is_item_selectet);
            if (!is_item_selectet)
            {
                Handle_Delete_Failure(args);
                return;
            }

            if (Confirm_Deletion())
            {
                int item_id = Get_Identifier_From_Item(item);
                Perform_Deletion(item_id, args);
            }
            else
            {
                Handle_Delete_Failure(args);
            }
        }

        // Delete an item ----------------------------------------------------

        // Save an item ------------------------------------------------------
        // Save_Item: This function handles both adding new items and editing existing ones:
        // It fetches the item details from the view.
        // Validates the item.
        // If the item is valid, it either adds or edits the item in the repository.
        // After saving, it refreshes the views, loads the data grids and combo boxes, and clears the form.

        // Helper functions for saving an item ------------------

        // Get the item from the view
        private T_Model Get_Item_From_View()
        {
            var item = new T_Model();
            Utilities.Assign_Properties(view_interface, item);
            return item;
        }

        // Validate the item that the fields are correct before the add or edit
        private bool Validate_Item(T_Model item)
        {
            try
            {
                Data_Validation.Validate_Data(item);
                return true;
            }
            catch (Exception ex)
            {
                view_interface.I_message = ex.Message;
                return false;
            }
        }

        // This is the shared mechanism that the adding and editing functions share
        private void Save_Item_Model(T_Model item)
        {
            if (view_interface.I_is_edit)
            {
                repository_interface.Edit(item);
                view_interface.I_message = Messages.Edit_success;
            }
            else
            {
                repository_interface.Add(item);
                view_interface.I_message = Messages.Add_success;
            }
        }

        // Helper functions for saving an item ------------------

        // Main method to save an item
        private void Save_Item(object? sender, Cancelable_Event_Args args)
        {
            var item = Get_Item_From_View();
            if (Validate_Item(item))
            {
                Save_Item_Model(item);
                Load_All_DataGridViews();
                Load_All_ComboBoxes();
                Clear_View();
            }
            else
            {
                args.Cancel = true;
            }
        }

        // Save an item ------------------------------------------------------

        // Cancel an actions is just clearing the view
        private void Cancel_Action(object? sender, EventArgs args)
        {
            Clear_View();
        }

        // Delete an item from another form ----------------------------------
        //  Delete_Item_From_Another_Form: Allows the deletion of an item from a different form.
        //  It first confirms the deletion with the user, then tries to delete the item using reflection (through the given repository type and method).
        //  On success, it refreshes the views; on failure, it displays an error message.

        // Helper functions for deleting an item ------------------

        // Try and delete the item
        private static bool Try_Delete_Item(object repository, int item_id, MethodInfo? delete_method)
        {
            try
            {
                delete_method?.Invoke(repository, new object[] { item_id });
                return true;
            }
            catch (TargetInvocationException ex)
            {
                Console.WriteLine($"Failed to delete item with ID {item_id} from the repository. Error: {ex.InnerException?.Message ?? ex.Message}");
                return false;
            }
        }

        // Ensure we have the correct repository and method
        private static bool Ensure_Repository_And_Delete_Method(out object repository, out MethodInfo? delete_method, Type repository_type)
        {
            repository = Service_Locator.Get_Service(repository_type) ?? throw new InvalidOperationException("Repository could not be located.");
            delete_method = repository.GetType().GetMethod("Delete");

            return repository != null && delete_method != null;
        }

        // Helper functions for deleting an item ------------------

        // Main method to delete an item from another form
        protected void Delete_Item_From_Another_Form(Delete_From_Another_Form_Request_Event_Args args)
        {
            if (!Confirm_Deletion())
            {
                MessageBox.Show(Messages.Delete_fail, Messages.Delete_fail, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Ensure_Repository_And_Delete_Method(out var repository, out var delete_method, args.Repository_Type))
            {
                MessageBox.Show(Messages.Delete_fail, Messages.Delete_fail, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Try_Delete_Item(repository, args.Id, delete_method))
            {
                Load_All_DataGridViews();
                Load_All_ComboBoxes();
                MessageBox.Show(Messages.Delete_success, Messages.Delete_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Messages.Delete_fail, Messages.Delete_fail, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Delete an item from another form ----------------------------------

        // Open a form from another form -------------------------------------
        // Open_Form & Open_Form: These methods handle the opening of another form.
        // They set the shared state's current item ID and raise an event to request the form opening.

        // Function to be subscribed to the event that raises to open a form
        protected void Open_Form(Form_Open_Request_Event_Args args)
        {
            Open_Form(args.Id, args.Form_Type, args.Repository_Type, args.Presenter_Type);
        }

        // Open form function # OVERRIDEN IN THE DERIVED CLASSES
        protected virtual void Open_Form(int? item_id, Type form_type, Type repository_type, Type presenter_type)
        {
            Shared_State.Current_item_id = item_id;

            Form_Open_Request_Event_Args args;

            if (item_id.HasValue)
            {
                view_interface.I_is_edit = true;
                args = new Form_Open_Request_Event_Args(item_id.Value, form_type, repository_type, presenter_type);
            }
            else
            {
                view_interface.I_is_edit = false;
                args = new Form_Open_Request_Event_Args(form_type, repository_type, presenter_type);
            }

            Event_Aggregator.Instance.Raise_Request_Open_Form(args);
        }

        // Open a form from another form -------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Data grid view set up  --------------------------------------------------------------------------------------------

        // Add a binding source
        // Adds or updates a binding source in a dictionary.
        // If the key exists and force_update is true, it updates the existing binding source.
        private static void Add_Binding_Source(string key, BindingSource binding_source, bool force_update = false)
        {
            if (Shared_State.Data_Grid_View_Binding_sources.ContainsKey(key))
            {
                if (force_update)
                {
                    Shared_State.Data_Grid_View_Binding_sources[key] = binding_source;
                }
                return;
            }
            Shared_State.Data_Grid_View_Binding_sources.Add(key, binding_source);
        }

        // Register the data grid view
        // Initializes and sets the meta-information (Data_Grid_View_Tag) for a DataGridView.
        // Associates a DataGridView with a specific binding source key and sets up an event listener for selection changes.
        private void Register_DataGridView(DataGridView grid_view, string binding_source_key)
        {
            var tag = new Data_Grid_View_Tag
            {
                Binding_SourceKey = binding_source_key
            };
            grid_view.Tag = tag;
            grid_view.SelectionChanged += On_Grid_View_Selection_Changed;
        }

        // On Grid View Selection Changed
        // Event handler for DataGridView's selection changed event.
        // It captures the binding source key from the DataGridView's meta-information (Tag) when the selection changes.
        private void On_Grid_View_Selection_Changed(object? sender, EventArgs args)
        {
            if (sender is DataGridView grid_view && grid_view.Tag is Data_Grid_View_Tag tag && tag.Binding_SourceKey != null)
            {
                Current_binding_source_key = tag.Binding_SourceKey;
            }
        }

        // Unsubscribe From Grid View Selection Changed
        // Removes the event listener for the DataGridView's selection changed event.
        protected void Unsubscribe_From_Grid_View_Selection_Changed(DataGridView grid_view)
        {
            grid_view.SelectionChanged -= On_Grid_View_Selection_Changed;
        }

        // Register the load function
        // Associates a specific load function with a key in a dictionary.
        // If the key exists and force_update is true, it updates the existing load function.
        private static void Register_Load_Function(string key, Func<IEnumerable<object>> load_function, bool force_update = false)
        {
            if (Shared_State.Data_Grid_View_Load_functions.ContainsKey(key))
            {
                if (force_update)
                {
                    Shared_State.Data_Grid_View_Load_functions[key] = load_function;
                }
                return;
            }
            Shared_State.Data_Grid_View_Load_functions.Add(key, load_function);
        }

        // Set the binding list of the data grid view
        // Associates a BindingSource with a DataGridView.
        // This determines what data will be shown in the DataGridView.
        private static void Set_List_Binding_Source(DataGridView grid_view, BindingSource binding_source)
        {
            grid_view.DataSource = binding_source;
        }

        // On Data Bind Complete
        // Event handler for DataGridView's data binding complete event.
        // Uses the meta-information (Data_Grid_View_Tag) to apply specific configuration settings, such as hiding certain columns.
        private void On_Data_Bind_Complete(object? sender, DataGridViewBindingCompleteEventArgs args)
        {
            if (sender is DataGridView grid_view && grid_view.Tag is Data_Grid_View_Tag tag && tag.Configuration != null)
            {
                var config = tag.Configuration;
                if (config.Columns_To_Hide != null && config.Columns_To_Hide.Count > 0)
                {
                    view_interface.Hide_Data_Grid_View_Columns(grid_view, config.Columns_To_Hide);
                }
            }
        }

        // Unsubscribe From Data Binding Complete
        // Removes the event listener for the DataGridView's data binding complete event.
        protected void Unsubscribe_From_Data_Binding_Complete(DataGridView config)
        {
            config.DataBindingComplete -= On_Data_Bind_Complete;
        }

        // Main method for to register data grid view # CALLED IN THE DERIVED CLASS
        // The main function for setting up a DataGridView.
        // Adds a BindingSource, sets up the DataGridView's meta-information (Data_Grid_View_Tag), registers a load function, and associates the BindingSource with the DataGridView.
        // It also adds a listener for the data binding complete event.
        // Add the grid to a list so we can keep track of it later for unsubscribing.
        protected void Register_Grid_View(Data_Grid_View_Configuration config)
        {
            Add_Binding_Source(config.Key, new BindingSource());
            Register_DataGridView(config.Data_Grid_View_Control, config.Key);
            Register_Load_Function(config.Key, config.Load_Function);
            Set_List_Binding_Source(config.Data_Grid_View_Control, Get_Binding_Source(config.Key));

            if (config.Data_Grid_View_Control.Tag is Data_Grid_View_Tag tag)
            {
                tag.Configuration = config;
                config.Data_Grid_View_Control.DataBindingComplete += On_Data_Bind_Complete;
            }

            Shared_State.Subscribed_Grid_Views.Add(config.Data_Grid_View_Control);
        }

        // Load a specific data grid view on the details tab page # CALLED IN THE DERIVED CLASSES
        // Fetches and loads data into a specific DataGridView using its configuration key.
        protected static void Load_Specific_Grid(string configuration_key)
        {
            var data = Shared_State.Data_Grid_View_Load_functions[configuration_key]();
            Get_Binding_Source(configuration_key).DataSource = data;
        }

        // Load the data on to the data grid views
        // Iteratively fetches and loads data into all registered DataGridViews.
        protected static void Load_All_DataGridViews()
        {
            foreach (var key in Shared_State.Data_Grid_View_Binding_sources.Keys)
            {
                Load_Specific_Grid(key);
            }
        }

        // Data grid view set up  --------------------------------------------------------------------------------------------

        // Combo Box set up  -------------------------------------------------------------------------------------------------
        // Is_Valid_Selection_Combo_Box: Checks if a valid item is selected in a ComboBox. Shows a warning if not valid.
        // Register_ComboBox: Registers a ComboBox configuration in a dictionary and loads data into it.
        // Load_ComboBox: Loads data into a specific ComboBox based on its configuration key.
        // Load_All_ComboBoxes: Iteratively loads data into all ComboBoxes in the dictionary.

        // Is an item of the Combo Box selected # CALLED IN THE VIEW OF THE DERIVED CLASS
        protected static bool Is_Valid_Selection_Combo_Box(ComboBox combo_box)
        {
            if (combo_box.SelectedItem is Custom_Combo_Box selected_item && selected_item.ID != 0)
            {
                return true;
            }

            MessageBox.Show(Messages.Select_Warning, Messages.Warning_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // Register the ComboBox # CALLED IN THE DERIVED CLASS
        protected static void Register_ComboBox(Combo_Box_Configuration config)
        {
            Shared_State.Combo_Box_Configurations[config.Key] = config;
            Load_ComboBox(config.Key);
        }

        // Load data into the ComboBox
        private static void Load_ComboBox(string key)
        {
            if (!Shared_State.Combo_Box_Configurations.ContainsKey(key))
            {
                throw new KeyNotFoundException($"ComboBox with key '{key}' not found.");
            }

            var config = Shared_State.Combo_Box_Configurations[key];
            config.Combo_Box_Control.Items.Clear();

            var items = config.Load_Function();
            foreach (var item in items)
            {
                config.Combo_Box_Control.Items.Add(item);
            }

            config.Combo_Box_Control.SelectedIndex = 0;
        }

        // Load data to the combo boxes
        protected static void Load_All_ComboBoxes()
        {
            foreach (var key in Shared_State.Combo_Box_Configurations.Keys)
            {
                Load_ComboBox(key);
            }
        }

        // Combo Box set up  -------------------------------------------------------------------------------------------------

        // Called in the main view presenter ---------------------------------------------------------------------------------

        // Load the data by id to be called in the Main view presenter # CALLED IN THE MAIN VIEW PRESENTER
        protected void Load_Data_By_Id(int? id)
        {
            if (id.HasValue && id.Value != 0)
            {
                var item = repository_interface.Get_By_Id(id.Value);
                if (item != null)
                {
                    view_interface.Show_Details_Tab_Page(Messages.Edit_text);
                    Load_Item_To_View(item);
                    view_interface.Show_Data_Grid_View();
                    return; // Exit if the item is found
                }
            }
            view_interface.Show_Details_Tab_Page(Messages.Add_new_text);
            view_interface.Hide_Data_Grid_View();

            Clear_View();
        }

        // Called in the main view presenter ---------------------------------------------------------------------------------
    }
}