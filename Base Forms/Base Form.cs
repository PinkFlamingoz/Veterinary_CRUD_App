using MaterialSkin.Controls;
using Veterinary_CRUD_App.Interfaces;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Base_Forms
{
    /// <summary>
    /// An abstract base form for a Veterinary CRUD application.
    /// DO NOT OPEN IN DESIGNER!
    /// This abstract class serves as the template for various other forms,
    /// defining a set of shared members and functionalities.
    /// </summary>
    public abstract class Base_Form : MaterialForm, IBase_View_Interface
    {
        // Common values
        public DataGridView I_main_data_grid_view
        {
            get => DataGridView_Main;
            set => DataGridView_Main = value;
        }

        public DataGridView? I_details_data_grid_view
        {
            get => DataGridView_Details ?? null;
            set => DataGridView_Details = value;
        }

        protected string message = "";

        // Abstract properties for the derived classes to implement

        protected abstract TabControl Main_Tab_Control { get; }
        protected abstract Button Search_Button { get; }
        protected abstract MaterialSkin.Controls.MaterialTextBox2 Search_textBox { get; }
        protected abstract Button Add_new_button { get; }
        protected abstract Button Save_button { get; }
        protected abstract Button Delete_button { get; }
        protected abstract Button Cancel_button { get; }
        protected abstract Button Edit_Button { get; }
        protected abstract TabPage List_tab_page { get; }
        protected abstract TabPage Details_tab_page { get; }
        protected abstract DataGridView DataGridView_Main { get; set; }
        protected virtual DataGridView? DataGridView_Details { get; set; }

        // Event values

        public abstract string I_search_value { get; set; }

        public bool I_is_edit
        {
            get => Shared_State.Is_edit;
            set => Shared_State.Is_edit = value;
        }

        public string I_message
        {
            get => message;
            set => message = value;
        }

        // Events

        public event EventHandler? Search_Event;

        public event EventHandler? Add_New_Event;

        public event EventHandler<Cancelable_Event_Args>? Edit_Event;

        public event EventHandler<Cancelable_Event_Args>? Save_Event;

        public event EventHandler<Cancelable_Event_Args>? Delete_Event;

        public event EventHandler? Cancel_Event;

        public event Action<Form_Open_Request_Event_Args>? Open_Form_Event;

        public event Action<Delete_From_Another_Form_Request_Event_Args>? Delete_Item_From_Another_Form_Event;

        public event Func<ComboBox, bool>? Validate_Combo_Box_Selection_Event;

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        protected static void Initialize_Form(MaterialForm form)
        {
            Theme_Manager.Apply_Theme_To_Form(form);
        }

        // Subscribe buttons to events # OVERRIDEN IN THE DERIVED CLASSES
        protected virtual void Subscribe_Button_Clicks_To_Invoking_Calls()
        {
            Search_Button.Click += Button_Search_Click;
            Search_textBox.KeyDown += TextBox_Search_KeyDown;
            Add_new_button.Click += Button_Add_New_Click;
            Edit_Button.Click += Edit_Button_Click;
            Save_button.Click += Button_Save_Click;
            Delete_button.Click += Button_Delete_Click;
            Cancel_button.Click += Button_Cancel_Click;
        }

        // Unsubscribe buttons from events # OVERRIDEN IN THE DERIVED CLASSES
        protected virtual void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            Search_Button.Click -= Button_Search_Click;
            Search_textBox.KeyDown -= TextBox_Search_KeyDown;
            Add_new_button.Click -= Button_Add_New_Click;
            Edit_Button.Click -= Edit_Button_Click;
            Save_button.Click -= Button_Save_Click;
            Delete_button.Click -= Button_Delete_Click;
            Cancel_button.Click -= Button_Cancel_Click;
        }

        // Unsubscribe from events by overriding the Dispose function
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Unsubscribe_Button_Clicks_To_Invoking_Calls();
            }
            base.Dispose(disposing);
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Button search
        private void Button_Search_Click(object? sender, EventArgs args)
        {
            Search_Event?.Invoke(this, EventArgs.Empty);
        }

        // TextBox search
        private void TextBox_Search_KeyDown(object? sender, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Enter)
            {
                Search_Event?.Invoke(this, EventArgs.Empty);
            }
        }

        // Button add a new item
        private void Button_Add_New_Click(object? sender, EventArgs args)
        {
            Show_Details_Tab_Page(Messages.Add_new_text);

            Add_New_Event?.Invoke(this, EventArgs.Empty);
        }

        // Button edit a new item
        private void Edit_Button_Click(object? sender, EventArgs args)
        {
            var cargs = new Cancelable_Event_Args();
            Edit_Event?.Invoke(this, cargs);
            if (cargs.Cancel) return;

            Show_Details_Tab_Page(Messages.Edit_text);
        }

        // Button save changes
        private void Button_Save_Click(object? sender, EventArgs args)
        {
            var cargs = new Cancelable_Event_Args();
            Save_Event?.Invoke(this, cargs);
            if (cargs.Cancel)
            {
                MessageBox.Show(message, Messages.Warning_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(message, Messages.Add_success, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Show_List_Tab_Page();
        }

        // Button delete an item
        private void Button_Delete_Click(object? sender, EventArgs args)
        {
            var cargs = new Cancelable_Event_Args();
            Delete_Event?.Invoke(this, cargs);
            if (cargs.Cancel)
            {
                MessageBox.Show(message, Messages.Delete_fail, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(message, Messages.Delete_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button to cancel actions
        private void Button_Cancel_Click(object? sender, EventArgs args)
        {
            Cancel_Event?.Invoke(this, EventArgs.Empty);

            Show_List_Tab_Page();
        }

        // Raise a event to open a form # CALLED IN THE DERIVED CLASSES
        protected void Raise_Open_Form_Event(Form_Open_Request_Event_Args args)
        {
            Open_Form_Event?.Invoke(args);
        }

        // Raise a event to delete an item from another form # CALLED IN THE DERIVED CLASS
        protected void Raise_Delete_From_Another_Form_Event(Delete_From_Another_Form_Request_Event_Args args)
        {
            Delete_Item_From_Another_Form_Event?.Invoke(args);
        }

        // Raise a event to validate if a selection has been made within the Combo Box # CALLED IN THE DERIVED CLASS
        protected bool Raise_Validate_Combo_Box_Selection_Event(ComboBox combo_box)
        {
            return Validate_Combo_Box_Selection_Event?.Invoke(combo_box) ?? false;
        }

        // Event functions ---------------------------------------------------------------------------------------------------

        // UI manipulation functions -----------------------------------------------------------------------------------------

        // Show the list tab page on the main tab control aka the main tab
        public void Show_List_Tab_Page()
        {
            if (Main_Tab_Control.SelectedTab != List_tab_page)
            {
                Main_Tab_Control.TabPages.Remove(Details_tab_page);

                // Only add if it's not already present.
                if (!Main_Tab_Control.TabPages.Contains(List_tab_page))
                {
                    Main_Tab_Control.TabPages.Add(List_tab_page);
                }

                Main_Tab_Control.SelectedTab = List_tab_page;  // Ensure the list tab is selected.
            }
        }

        // Show the details tab page on the main tab control aka the edit page tab
        public void Show_Details_Tab_Page(string title = "")
        {
            if (Main_Tab_Control.SelectedTab != Details_tab_page)
            {
                Main_Tab_Control.TabPages.Remove(List_tab_page);

                // Only add if it's not already present.
                if (!Main_Tab_Control.TabPages.Contains(Details_tab_page))
                {
                    Main_Tab_Control.TabPages.Add(Details_tab_page);
                }

                Main_Tab_Control.SelectedTab = Details_tab_page;  // Ensure the details tab is selected.
            }

            // Update the title even if the tab was already selected.
            Details_tab_page.Text = title;
        }

        // Hide Columns in the data grid view, that we don't care about
        public void Hide_Data_Grid_View_Columns(DataGridView target_data_grid_view, IEnumerable<string> column_names)
        {
            foreach (var column_name in column_names)
            {
                if (target_data_grid_view.Columns.Contains(column_name) && target_data_grid_view.Columns[column_name].Visible)
                {
                    target_data_grid_view.Columns[column_name].Visible = false;
                }
            }
        }

        // Show a data grid view
        public void Show_Data_Grid_View()
        {
            I_details_data_grid_view?.Show();
        }

        // Hide a data grid view
        public void Hide_Data_Grid_View()
        {
            I_details_data_grid_view?.Hide();
            I_details_data_grid_view?.ClearSelection();
        }

        // UI manipulation functions -----------------------------------------------------------------------------------------
    }

#if DEBUG

    /// <summary>
    /// Design-time base form. Use this for designing and sub classing.
    /// </summary>
    public class DesignTimeBase_Form : Base_Form
    {
        public override string I_search_value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Implement all the abstract members here just for design-time visualization.
        // They don't have to be functional, just enough to satisfy the compiler.

        protected override TabControl Main_Tab_Control => throw new NotImplementedException();

        protected override Button Search_Button => throw new NotImplementedException(); // Or a new Button();

        protected override MaterialSkin.Controls.MaterialTextBox2 Search_textBox => throw new NotImplementedException();

        protected override Button Add_new_button => throw new NotImplementedException();

        protected override Button Save_button => throw new NotImplementedException();

        protected override Button Delete_button => throw new NotImplementedException();

        protected override Button Cancel_button => throw new NotImplementedException();

        protected override Button Edit_Button => throw new NotImplementedException();

        protected override TabPage List_tab_page => throw new NotImplementedException();

        protected override TabPage Details_tab_page => throw new NotImplementedException();

        protected override DataGridView DataGridView_Main { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // ... override other members ...

        // If the base constructor calls any abstract methods (which is a bad practice), ensure that they are properly overridden here and return valid values, even if it's just null or a default value.
    }

#endif
}