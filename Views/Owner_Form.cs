using System.Reflection;
using Veterinary_CRUD_App.Base_Forms;
using Veterinary_CRUD_App.Interfaces.Owner;
using Veterinary_CRUD_App.Interfaces.Pets;
using Veterinary_CRUD_App.Presenters;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Views
{
    public partial class Owner_Form : DesignTimeBase_Form, IOwner_View_Interface
    {
        // Owner values

        public int I_owner_id
        {
            get => (int)numericUpDown_owner_id.Value;
            set => numericUpDown_owner_id.Value = value;
        }

        public string I_owner_name
        {
            get => textBox_owner_name.Text;
            set => textBox_owner_name.Text = value;
        }

        public string I_owner_phone
        {
            get => textBox_owner_phone.Text;
            set => textBox_owner_phone.Text = value;
        }

        public string I_owner_email
        {
            get => textBox_owner_email.Text;
            set => textBox_owner_email.Text = value;
        }

        // Override abstract properties from Base_Form

        public override string I_search_value
        {
            get => textBox_owner_search.Text;
            set => textBox_owner_search.Text = value;
        }

        protected override TabControl Main_Tab_Control => tabControl_owner_form;
        protected override Button Search_Button => button_owner_search;
        protected override MaterialSkin.Controls.MaterialTextBox2 Search_Text_Box => textBox_owner_search;
        protected override Button Add_new_button => button_owner_add_owner;
        protected override Button Save_button => button_owner_save;
        protected override Button Delete_button => button_owner_delete;
        protected override Button Cancel_button => button_owner_cancel;
        protected override Button Edit_Button => button_owner_edit;
        protected override TabPage List_tab_page => tabPage_owners;
        protected override TabPage Details_tab_page => tabPage_owner_details;
        protected override DataGridView DataGridView_Main => dataGridView_owners;
        protected override DataGridView? DataGridView_Details => dataGridView_owner_pets;

        // Constructor
        public Owner_Form()
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

            button_owner_edit_pet.Click += Button_Owner_Edit_Pet_Click;
            button_owner_add_new_pet.Click += Button_Owner_Add_Pet_Click;
            button_owner_delete_pet.Click += Button_Owner_Delete_Pet_Click;
        }

        // Unsubscribe buttons from events
        protected override void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            base.Unsubscribe_Button_Clicks_To_Invoking_Calls();

            button_owner_edit_pet.Click -= Button_Owner_Edit_Pet_Click;
            button_owner_add_new_pet.Click -= Button_Owner_Add_Pet_Click;
            button_owner_delete_pet.Click -= Button_Owner_Delete_Pet_Click;
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Button edit the pet of an owner
        private void Button_Owner_Edit_Pet_Click(object? sender, EventArgs e)
        {
            if (dataGridView_owner_pets.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dataGridView_owner_pets.SelectedRows[0];
                if (selected_row.Cells["Get_pet_id"]?.Value is int selected_pet_id)
                {
                    var args = new Form_Open_Request_Event_Args(selected_pet_id, typeof(Pet_Form), typeof(IPet_Repository_Interface), typeof(Pet_Form_Presenter));
                    Raise_Open_Form_Event(args);
                }
            }
            else
            {
                MessageBox.Show(Messages.No_Pet_Selected, Messages.Warning_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Button add a new pet
        private void Button_Owner_Add_Pet_Click(object? sender, EventArgs e)
        {
            var args = new Form_Open_Request_Event_Args(null, typeof(Pet_Form), typeof(IPet_Repository_Interface), typeof(Pet_Form_Presenter));
            Raise_Open_Form_Event(args);
        }

        // Button delete a pet of an owner
        private void Button_Owner_Delete_Pet_Click(object? sender, EventArgs e)
        {
            if (dataGridView_owner_pets.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dataGridView_owner_pets.SelectedRows[0];
                if (selected_row.Cells["Get_pet_id"]?.Value is int selected_pet_id)
                {
                    var args = new Delete_From_Another_Form_Request_Event_Args(selected_pet_id, typeof(IPet_Repository_Interface));
                    Raise_Delete_From_Another_Form_Event(args);
                }
            }
            else
            {
                MessageBox.Show(Messages.No_Pet_Selected, Messages.Warning_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event functions ---------------------------------------------------------------------------------------------------
    }
}