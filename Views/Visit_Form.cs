using Veterinary_CRUD_App.Interfaces.Visits;
using Veterinary_CRUD_App.Base_Forms;
using Veterinary_CRUD_App.Presenters.Common;
using Veterinary_CRUD_App.Interfaces.Pets;
using Veterinary_CRUD_App.Presenters;
using MaterialSkin.Controls;

namespace Veterinary_CRUD_App.Views
{
    public partial class Visit_Form : DesignTimeBase_Form, IVisit_View_Interface
    {
        // Visit values

        public int I_visit_id
        {
            get => (int)numericUpDown_visit_id.Value;
            set => numericUpDown_visit_id.Value = value;
        }

        public int I_pet_id
        {
            get
            {
                if (I_visit_pet_name_cb.SelectedItem is Custom_Combo_Box selected_pet)
                {
                    return selected_pet.Id;
                }
                return 0;
            }
            set
            {
                foreach (var item in I_visit_pet_name_cb.Items)
                {
                    if (item is Custom_Combo_Box pet_item && pet_item.Id == value)
                    {
                        I_visit_pet_name_cb.SelectedItem = pet_item;
                        return;
                    }
                }
            }
        }

        public string I_visit_type
        {
            get => textBox_visit_type.Text;
            set => textBox_visit_type.Text = value;
        }

        public DateTime I_visit_date
        {
            get => dateTimePicker_visit_date.Value;
            set
            {
                if (value > dateTimePicker_visit_date.MinDate && value < dateTimePicker_visit_date.MaxDate)
                {
                    dateTimePicker_visit_date.Value = value;
                }
                else
                {
                    dateTimePicker_visit_date.Value = DateTime.Now;
                }
            }
        }

        public string I_visit_description
        {
            get => textBox_visit_description.Text;
            set => textBox_visit_description.Text = value;
        }

        public MaterialSkin.Controls.MaterialComboBox I_visit_pet_name_cb
        {
            get => comboBox_visit_pet_id;
            set => comboBox_visit_pet_id = value;
        }

        // Override abstract properties from Base_Form

        public override string I_search_value
        {
            get => textBox_visit_search.Text;
            set => textBox_visit_search.Text = value;
        }

        protected override TabControl Main_Tab_Control => tabControl_visits_form;
        protected override Button Search_Button => button_visit_search;
        protected override MaterialTextBox2 Search_Text_Box => textBox_visit_search;
        protected override Button Add_new_button => button_visit_add_new_visit;
        protected override Button Save_button => button_visit_save;
        protected override Button Delete_button => button_visit_delete;
        protected override Button Cancel_button => button_visit_cancel;
        protected override Button Edit_Button => button_visit_edit;
        protected override TabPage List_tab_page => tabPage_visit_list;
        protected override TabPage Details_tab_page => tabPage_visit_details;
        protected override DataGridView Data_Grid_View_Main => dataGridView_visits_pets;
        protected override DateTimePicker Date_Time_Picker => dateTimePicker_visit_date;
        protected override MaterialLabel Label_Date_Time_Picker_Mask => materialLabel_visit_date_datetime_mask;
        protected override MaterialTextBox2 ID_Text_Box_Mask => materialTextBox21_visit_id_mask;
        protected override NumericUpDown Numeric_Up_Down_ID_Of_Item => numericUpDown_visit_id;

        // Constructor
        public Visit_Form()
        {
            InitializeComponent();
            Subscribe_Button_Clicks_To_Invoking_Calls();
            Initialize_Form(this);
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events
        protected override void Subscribe_Button_Clicks_To_Invoking_Calls()
        {
            base.Subscribe_Button_Clicks_To_Invoking_Calls();

            button_visit_edit_pet.Click += Button_Visit_Edit_Pet_Click;
        }

        // Unsubscribe buttons from events
        protected override void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            base.Unsubscribe_Button_Clicks_To_Invoking_Calls();

            button_visit_edit_pet.Click -= Button_Visit_Edit_Pet_Click;
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Button edit a visit of a pet
        private void Button_Visit_Edit_Pet_Click(object? sender, EventArgs e)
        {
            if (Raise_Validate_Combo_Box_Selection_Event(I_visit_pet_name_cb))
            {
                var args = new Form_Open_Request_Event_Args(I_pet_id, typeof(Pet_Form), typeof(IPet_Repository_Interface), typeof(Pet_Form_Presenter));
                Raise_Open_Form_Event(args);
            }
        }

        // Event functions ---------------------------------------------------------------------------------------------------

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}