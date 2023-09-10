using MaterialSkin;
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

        private readonly MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;

        public DataGridView I_main_data_grid_view
        {
            get => Data_Grid_View_Main;
            set => Data_Grid_View_Main = value;
        }

        public DataGridView? I_details_data_grid_view
        {
            get => Data_Grid_View_Details ?? null;
            set => Data_Grid_View_Details = value;
        }

        protected string Data_Grid_View_Key = string.Empty;

        public string I_Data_Grid_View_Key
        {
            get => Data_Grid_View_Key;
            set => Data_Grid_View_Key = value;
        }

        // Abstract properties for the derived classes to implement

        protected abstract TabControl Main_Tab_Control { get; }
        protected abstract Button Search_Button { get; }
        protected abstract MaterialTextBox2 Search_Text_Box { get; }
        protected abstract Button Add_new_button { get; }
        protected abstract Button Save_button { get; }
        protected abstract Button Delete_button { get; }
        protected abstract Button Cancel_button { get; }
        protected abstract Button Edit_Button { get; }
        protected abstract TabPage List_tab_page { get; }
        protected abstract TabPage Details_tab_page { get; }
        protected abstract DataGridView Data_Grid_View_Main { get; set; }
        protected virtual DataGridView? Data_Grid_View_Details { get; set; }
        protected abstract DateTimePicker? Date_Time_Picker { get; set; }
        protected abstract MaterialLabel? Label_Date_Time_Picker_Mask { get; }
        protected abstract MaterialTextBox2 ID_Text_Box_Mask { get; }
        protected abstract NumericUpDown Numeric_Up_Down_ID_Of_Item { get; }

        // Event values

        public abstract string I_search_value { get; set; }

        public bool I_is_edit
        {
            get => Shared_State.Is_edit;
            set => Shared_State.Is_edit = value;
        }

        protected string message = string.Empty;

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

        // Initialize the form
        protected void Initialize_Form(MaterialForm form)
        {
            Theme_Manager.Apply_Theme_To_Form(form);
            Utilities.Set_Double_Buffered_Recursively(form, true);
            Refresh_Data_Grid_View_Theme();
            Date_Time_Picker_Mask_Value_Changed(this, EventArgs.Empty);
            Numeric_Up_Down_Mask_Value_Changed(this, EventArgs.Empty);
        }

        // Subscribe buttons to events # OVERRIDEN IN THE DERIVED CLASSES
        protected virtual void Subscribe_Button_Clicks_To_Invoking_Calls()
        {
            // Buttons
            Search_Button.Click += Button_Search_Click;
            Search_Text_Box.KeyDown += Text_Box_Search_Key_Down;
            Add_new_button.Click += Button_Add_New_Click;
            Edit_Button.Click += Edit_Button_Click;
            Save_button.Click += Button_Save_Click;
            Delete_button.Click += Button_Delete_Click;
            Cancel_button.Click += Button_Cancel_Click;

            // UI
            Numeric_Up_Down_ID_Of_Item.ValueChanged += Numeric_Up_Down_Mask_Value_Changed;
            Theme_Manager.Theme_Or_Color_Change += Refresh_Data_Grid_View_Theme;
            Data_Grid_View_Main.CellFormatting += Data_Grid_View_Cell_Formatting;
            if (Data_Grid_View_Details != null)
            {
                Data_Grid_View_Details.CellFormatting += Data_Grid_View_Cell_Formatting;
            }
            if (Label_Date_Time_Picker_Mask != null)
            {
                Label_Date_Time_Picker_Mask.Click += Label_Date_Time_Picker_Mask_Click;
            }
            if (Date_Time_Picker != null)
            {
                Date_Time_Picker.ValueChanged += Date_Time_Picker_Mask_Value_Changed;
            }
        }

        // Unsubscribe buttons from events # OVERRIDEN IN THE DERIVED CLASSES
        protected virtual void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            // Buttons
            Search_Button.Click -= Button_Search_Click;
            Search_Text_Box.KeyDown -= Text_Box_Search_Key_Down;
            Add_new_button.Click -= Button_Add_New_Click;
            Edit_Button.Click -= Edit_Button_Click;
            Save_button.Click -= Button_Save_Click;
            Delete_button.Click -= Button_Delete_Click;
            Cancel_button.Click -= Button_Cancel_Click;

            // UI
            Theme_Manager.Theme_Or_Color_Change -= Refresh_Data_Grid_View_Theme;
            Numeric_Up_Down_ID_Of_Item.ValueChanged -= Numeric_Up_Down_Mask_Value_Changed;
            Data_Grid_View_Main.CellFormatting -= Data_Grid_View_Cell_Formatting;
            if (Data_Grid_View_Details != null)
            {
                Data_Grid_View_Details.CellFormatting -= Data_Grid_View_Cell_Formatting;
            }
            if (Label_Date_Time_Picker_Mask != null)
            {
                Label_Date_Time_Picker_Mask.Click -= Label_Date_Time_Picker_Mask_Click;
            }
            if (Date_Time_Picker != null)
            {
                Date_Time_Picker.ValueChanged -= Date_Time_Picker_Mask_Value_Changed;
            }
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
        private void Text_Box_Search_Key_Down(object? sender, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Enter)
            {
                Search_Event?.Invoke(this, EventArgs.Empty);
            }
        }

        // Button add a new item
        private void Button_Add_New_Click(object? sender, EventArgs args)
        {
            Add_New_Event?.Invoke(this, EventArgs.Empty);

            Show_Details_Tab_Page(Messages.Add_new_text);
            Hide_Data_Grid_View_Details();
        }

        // Button edit a new item
        private void Edit_Button_Click(object? sender, EventArgs args)
        {
            var cargs = new Cancelable_Event_Args();
            Edit_Event?.Invoke(this, cargs);
            if (cargs.Cancel) return;

            Show_Details_Tab_Page(Messages.Edit_text);
            Show_Data_Grid_View_Details();
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

            Show_List_Tab_Page();
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

        // Hide all controls in a Tab Page
        public static void Hide_Content(TabPage page)
        {
            foreach (Control control in page.Controls)
            {
                control.Visible = false;
            }
        }

        // Show all controls in a Tab Page
        public static void Show_Content(TabPage page)
        {
            foreach (Control control in page.Controls)
            {
                control.Visible = true;
            }
        }

        // Show the list Tab Page on the main Tab Control aka the main tab
        public void Show_List_Tab_Page()
        {
            if (Main_Tab_Control.SelectedTab != List_tab_page)
            {
                // Hide_Content(Details_tab_page);
                //
                // // Only show if it's not already visible.
                // if (!List_tab_page.Controls[0].Visible)
                // {
                //     Show_Content(List_tab_page);
                // }

                Main_Tab_Control.SelectedTab = List_tab_page;  // Ensure the list tab is selected.
            }
        }

        // Show the details Tab Page on the main Tab Control aka the edit page tab
        public void Show_Details_Tab_Page(string title = "")
        {
            if (Main_Tab_Control.SelectedTab != Details_tab_page)
            {
                // Hide_Content(List_tab_page);
                //
                // // Only show if it's not already visible.
                // if (!Details_tab_page.Controls[0].Visible)
                // {
                //     Show_Content(Details_tab_page);
                // }

                Main_Tab_Control.SelectedTab = Details_tab_page;  // Ensure the details tab is selected.
            }

            // Update the title even if the tab was already selected.
            Details_tab_page.Text = title;
        }

        // Hide Columns in the Data Grid View, that we don't care about
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

        // Select the Date Time Picker when the Label mask is clicked
        private void Label_Date_Time_Picker_Mask_Click(object? sender, EventArgs e)
        {
            // When we click on the mask select the element below it aka here we select the Date Time Picker underneath it
            if (Date_Time_Picker != null)
            {
                Date_Time_Picker.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        // Set the value of the Date Time Picker to the Label mask
        private void Date_Time_Picker_Mask_Value_Changed(object? sender, EventArgs e)
        {
            if (Label_Date_Time_Picker_Mask != null)
            {
                Label_Date_Time_Picker_Mask.Text = Date_Time_Picker?.Text;
            }
        }

        // Set the value of the Numeric Up Down to the Text Box Mask
        private void Numeric_Up_Down_Mask_Value_Changed(object? sender, EventArgs e)
        {
            ID_Text_Box_Mask.Text = Numeric_Up_Down_ID_Of_Item.Value.ToString();
        }

        // Show a Data Grid View
        public void Show_Data_Grid_View_Details()
        {
            I_details_data_grid_view?.Show();
        }

        // Hide a Data Grid View and clear its selection
        public void Hide_Data_Grid_View_Details()
        {
            I_details_data_grid_view?.Hide();
            I_details_data_grid_view?.ClearSelection();
        }

        // Refresh the Data Grid View theme
        private void Refresh_Data_Grid_View_Theme()
        {
            Apply_Theme_To_Data_Grid_View(Data_Grid_View_Main);
            Apply_Theme_To_Data_Grid_View(Data_Grid_View_Details);
        }

        // Apply the theme to the Data Grid View
        private void Apply_Theme_To_Data_Grid_View(DataGridView? data_grid_view)
        {
            if (data_grid_view == null)
            {
                return;
            }

            // Set Data Grid View default styles using Material Skin colors
            data_grid_view.DefaultCellStyle.Padding = new Padding(11, 11, 0, 11);
            data_grid_view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            data_grid_view.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            data_grid_view.DefaultCellStyle.Font = material_skin_manager.getFontByType(MaterialSkinManager.fontType.Body1);
            data_grid_view.DefaultCellStyle.BackColor = material_skin_manager.ColorScheme.PrimaryColor;
            data_grid_view.DefaultCellStyle.ForeColor = material_skin_manager.ColorScheme.TextColor;
            data_grid_view.DefaultCellStyle.SelectionBackColor = material_skin_manager.ColorScheme.AccentColor;
            data_grid_view.DefaultCellStyle.SelectionForeColor = material_skin_manager.ColorScheme.TextColor;

            // Set Header styles
            data_grid_view.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_grid_view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            data_grid_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_view.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            data_grid_view.ColumnHeadersDefaultCellStyle.Padding = new Padding(9, 16, 0, 16);
            data_grid_view.ColumnHeadersDefaultCellStyle.Font = material_skin_manager.getFontByType(MaterialSkinManager.fontType.Subtitle1);
            data_grid_view.ColumnHeadersDefaultCellStyle.BackColor = material_skin_manager.ColorScheme.DarkPrimaryColor;
            data_grid_view.ColumnHeadersDefaultCellStyle.ForeColor = material_skin_manager.ColorScheme.TextColor;
            data_grid_view.ColumnHeadersDefaultCellStyle.SelectionBackColor = material_skin_manager.ColorScheme.DarkPrimaryColor;
            data_grid_view.ColumnHeadersDefaultCellStyle.SelectionForeColor = material_skin_manager.ColorScheme.TextColor;
            data_grid_view.EnableHeadersVisualStyles = false;

            // Row headers
            data_grid_view.RowHeadersVisible = false;

            // Other styles
            data_grid_view.GridColor = material_skin_manager.ColorScheme.AccentColor;
            data_grid_view.BorderStyle = BorderStyle.None;
            data_grid_view.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            data_grid_view.BackgroundColor = material_skin_manager.ColorScheme.PrimaryColor;
            data_grid_view.AllowUserToAddRows = false;
            data_grid_view.AllowUserToDeleteRows = false;
            data_grid_view.AllowUserToOrderColumns = false;
            data_grid_view.MultiSelect = false;
            data_grid_view.ReadOnly = true;
            data_grid_view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid_view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        //  If the cell information is more than 100 characters replace the rest with three dots
        private void Data_Grid_View_Cell_Formatting(object? sender, DataGridViewCellFormattingEventArgs args)
        {
            // Check if the cell value is not null and is a string
            if (args.Value is string cell_value)
            {
                if (cell_value.Length > 100)
                {
                    // Truncate the string and add three dots at the end
                    args.Value = cell_value[..100] + "…";

                    args.FormattingApplied = true; // Indicates the formatting was applied
                }
            }
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

        protected override MaterialSkin.Controls.MaterialTextBox2 Search_Text_Box => throw new NotImplementedException();

        protected override Button Add_new_button => throw new NotImplementedException();

        protected override Button Save_button => throw new NotImplementedException();

        protected override Button Delete_button => throw new NotImplementedException();

        protected override Button Cancel_button => throw new NotImplementedException();

        protected override Button Edit_Button => throw new NotImplementedException();

        protected override TabPage List_tab_page => throw new NotImplementedException();

        protected override TabPage Details_tab_page => throw new NotImplementedException();

        protected override DataGridView Data_Grid_View_Main { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override DateTimePicker? Date_Time_Picker
        {
            get => null;
            set
            {
                if (Date_Time_Picker != null)
                {
                    Date_Time_Picker.Value = DateTime.Now;
                }
            }
        }

        protected override MaterialLabel? Label_Date_Time_Picker_Mask => null;

        protected override MaterialTextBox2 ID_Text_Box_Mask => throw new NotImplementedException();

        protected override NumericUpDown Numeric_Up_Down_ID_Of_Item { get => throw new NotImplementedException(); }

        // ... override other members ...

        // If the base constructor calls any abstract methods (which is a bad practice), ensure that they are properly overridden here and return valid values, even if it's just null or a default value.
    }

#endif
}