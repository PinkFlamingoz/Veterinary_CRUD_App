using Veterinary_CRUD_App.Interfaces.Pets;
using Veterinary_CRUD_App.Presenters.Common;
using Veterinary_CRUD_App.Base_Forms;
using Veterinary_CRUD_App.Presenters;
using Veterinary_CRUD_App.Interfaces.Visits;
using Veterinary_CRUD_App.Interfaces.Owner;
using MaterialSkin.Controls;

namespace Veterinary_CRUD_App.Views
{
    public partial class Pet_Form : DesignTimeBase_Form, IPet_View_Interface
    {
        // Pet values

        public int I_pet_id
        {
            get => (int)numericUpDown_pet_id.Value;
            set => numericUpDown_pet_id.Value = value;
        }

        public int I_owner_id
        {
            get
            {
                if (I_pet_owner_name_cb.SelectedItem is Custom_Combo_Box selected_owner)
                {
                    return selected_owner.Id;
                }
                return 0;
            }
            set
            {
                foreach (var item in I_pet_owner_name_cb.Items)
                {
                    if (item is Custom_Combo_Box owner_item && owner_item.Id == value)
                    {
                        I_pet_owner_name_cb.SelectedItem = owner_item;
                        return;
                    }
                }
            }
        }

        public string I_pet_name
        {
            get => textBox_pet_name.Text;
            set => textBox_pet_name.Text = value;
        }

        public string I_pet_type
        {
            get => textBox_pet_type.Text;
            set => textBox_pet_type.Text = value;
        }

        public string I_pet_color
        {
            get => textBox_pet_colour.Text;
            set => textBox_pet_colour.Text = value;
        }

        public int I_pet_age
        {
            get => (int)numericUpDown_pet_age.Value;
            set => numericUpDown_pet_age.Value = value;
        }

        public string I_pet_sex
        {
            get => textBox_pet_sex.Text;
            set => textBox_pet_sex.Text = value;
        }

        public DateTime I_pet_birthdate
        {
            get => dateTimePicker_pet_birthdate.Value;
            set
            {
                if (value > dateTimePicker_pet_birthdate.MinDate && value < dateTimePicker_pet_birthdate.MaxDate)
                {
                    dateTimePicker_pet_birthdate.Value = value;
                }
                else
                {
                    dateTimePicker_pet_birthdate.Value = DateTime.Now;
                }
            }
        }

        public string I_pet_picture
        {
            get => pictureBox_pet_picture.ImageLocation;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    pictureBox_pet_picture.Image = Properties.Resources.Default_Pet_Image;
                }
                else
                {
                    try
                    {
                        string full_path = Path.Combine(Application.StartupPath, @"..\..\..\Resources\Images\", value);

                        pictureBox_pet_picture.ImageLocation = full_path;
                        pictureBox_pet_picture.Image = Image.FromFile(full_path);
                    }
                    catch (Exception ex)
                    {
                        pictureBox_pet_picture.Image = Properties.Resources.Default_Pet_Image;
                        Console.WriteLine("Error loading image, default image loaded: " + ex.Message);
                    }
                }
            }
        }

        public MaterialSkin.Controls.MaterialComboBox I_pet_owner_name_cb
        {
            get => comboBox_pet_owner_id;
            set => comboBox_pet_owner_id = value;
        }

        // Events

        public event EventHandler? Add_Image_Event;

        // Override abstract properties from Base_Form

        public override string I_search_value
        {
            get => textBox_pet_search.Text;
            set => textBox_pet_search.Text = value;
        }

        protected override TabControl Main_Tab_Control => tabControl_pets_form;
        protected override Button Search_Button => button_pet_search;
        protected override MaterialTextBox2 Search_Text_Box => textBox_pet_search;
        protected override Button Add_new_button => button_pet_add_new;
        protected override Button Save_button => button_pet_save;
        protected override Button Delete_button => button_pet_delete;
        protected override Button Cancel_button => button_pet_cancel;
        protected override Button Edit_Button => button_pet_edit;
        protected override TabPage List_tab_page => tabPage_pet_list;
        protected override TabPage Details_tab_page => tabPage_pet_details;
        protected override DataGridView Data_Grid_View_Main => dataGridView_pets;
        protected override DataGridView? Data_Grid_View_Details => dataGridView_pet_visits;
        protected override DateTimePicker Date_Time_Picker => dateTimePicker_pet_birthdate;
        protected override MaterialLabel Label_Date_Time_Picker_Mask => materialLabel_pet_birthday_datetime_mask;
        protected override MaterialTextBox2 ID_Text_Box_Mask => materialTextBox21_pet_id_mask;
        protected override NumericUpDown Numeric_Up_Down_ID_Of_Item => numericUpDown_pet_id;

        // Constructor
        public Pet_Form()
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

            button_pet_edit_owner.Click += Button_Pet_Edit_Owner_Click;
            button_pet_add_owner.Click += Button_Pet_Add_Owner_Click;
            button_pet_edit_visits.Click += Button_Pet_Edit_Visit_Click;
            button_pet_add_visit.Click += Button_Pet_Add_Visit_Click;
            button_pet_delete_visit.Click += Button_Pet_Delete_Visit_Click;
            button_pet_upload_picture.Click += Button_Pet_Add_Image_Click;
        }

        // Unsubscribe buttons from events
        protected override void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            base.Unsubscribe_Button_Clicks_To_Invoking_Calls();

            button_pet_edit_owner.Click -= Button_Pet_Edit_Owner_Click;
            button_pet_add_owner.Click -= Button_Pet_Add_Owner_Click;
            button_pet_edit_visits.Click -= Button_Pet_Edit_Visit_Click;
            button_pet_add_visit.Click -= Button_Pet_Add_Visit_Click;
            button_pet_delete_visit.Click -= Button_Pet_Delete_Visit_Click;
            button_pet_upload_picture.Click -= Button_Pet_Add_Image_Click;
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Button edit the owner of a pet
        private void Button_Pet_Edit_Owner_Click(object? sender, EventArgs e)
        {
            if (Raise_Validate_Combo_Box_Selection_Event(I_pet_owner_name_cb))
            {
                var args = new Form_Open_Request_Event_Args(I_owner_id, typeof(Owner_Form), typeof(IOwner_Repository_Interface), typeof(Owner_Form_Presenter));
                Raise_Open_Form_Event(args);
            }
        }

        // Button add new owner
        private void Button_Pet_Add_Owner_Click(object? sender, EventArgs e)
        {
            var args = new Form_Open_Request_Event_Args(null, typeof(Owner_Form), typeof(IOwner_Repository_Interface), typeof(Owner_Form_Presenter));
            Raise_Open_Form_Event(args);
        }

        // Button edit the visit of a pet
        private void Button_Pet_Edit_Visit_Click(object? sender, EventArgs e)
        {
            if (dataGridView_pet_visits.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dataGridView_pet_visits.SelectedRows[0];
                if (selected_row.Cells["Get_visit_id"]?.Value is int selected_visit_id)
                {
                    var args = new Form_Open_Request_Event_Args(selected_visit_id, typeof(Visit_Form), typeof(IVisit_Repository_Interface), typeof(Visit_Form_Presenter));
                    Raise_Open_Form_Event(args);
                }
            }
            else
            {
                MessageBox.Show(Messages.No_Visit_Selected, Messages.Warning_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Button add a new visit
        private void Button_Pet_Add_Visit_Click(object? sender, EventArgs e)
        {
            var args = new Form_Open_Request_Event_Args(null, typeof(Visit_Form), typeof(IVisit_Repository_Interface), typeof(Visit_Form_Presenter));
            Raise_Open_Form_Event(args);
        }

        // Button delete a visit of a pet
        private void Button_Pet_Delete_Visit_Click(object? sender, EventArgs e)
        {
            if (dataGridView_pet_visits.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dataGridView_pet_visits.SelectedRows[0];
                if (selected_row.Cells["Get_visit_id"]?.Value is int selected_visit_id)
                {
                    var args = new Delete_From_Another_Form_Request_Event_Args(selected_visit_id, typeof(IVisit_Repository_Interface));
                    Raise_Delete_From_Another_Form_Event(args);
                }
            }
            else
            {
                MessageBox.Show(Messages.No_Visit_Selected, Messages.Warning_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_Pet_Add_Image_Click(object? sender, EventArgs e)
        {
            Add_Image_Event?.Invoke(this, EventArgs.Empty);
        }

        // Event functions ---------------------------------------------------------------------------------------------------

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}