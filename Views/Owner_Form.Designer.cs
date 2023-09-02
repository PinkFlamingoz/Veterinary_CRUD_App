namespace Veterinary_CRUD_App.Views
{
    partial class Owner_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_owner = new Label();
            panel_owner_title = new Panel();
            tabControl_owner_form = new TabControl();
            tabPage_owners = new TabPage();
            button_owner_search = new Button();
            textBox_owner_pet_search = new TextBox();
            label_owner_pet_search = new Label();
            button_owner_delete = new Button();
            button_owner_edit = new Button();
            button_owner_add_owner = new Button();
            dataGridView_owners = new DataGridView();
            tabPage_owner_details = new TabPage();
            button_owner_edit_pet = new Button();
            button_owner_delete_pet = new Button();
            button_owner_add_new_pet = new Button();
            dataGridView_owner_pets = new DataGridView();
            numericUpDown_owner_id = new NumericUpDown();
            button_owner_cancel = new Button();
            button_owner_save = new Button();
            textBox_owner_email = new TextBox();
            label_owner_email = new Label();
            textBox_owner_phone = new TextBox();
            label_owner_phone = new Label();
            textBox_owner_name = new TextBox();
            label_owner_name = new Label();
            label_owner_id = new Label();
            panel_owner_title.SuspendLayout();
            tabControl_owner_form.SuspendLayout();
            tabPage_owners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_owners).BeginInit();
            tabPage_owner_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_owner_pets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_owner_id).BeginInit();
            SuspendLayout();
            // 
            // label_owner
            // 
            label_owner.AutoSize = true;
            label_owner.Location = new Point(40, 29);
            label_owner.Name = "label_owner";
            label_owner.Size = new Size(42, 15);
            label_owner.TabIndex = 0;
            label_owner.Text = "Owner";
            // 
            // panel_owner_title
            // 
            panel_owner_title.BackColor = Color.White;
            panel_owner_title.Controls.Add(label_owner);
            panel_owner_title.Dock = DockStyle.Top;
            panel_owner_title.Location = new Point(0, 0);
            panel_owner_title.Name = "panel_owner_title";
            panel_owner_title.Size = new Size(1115, 65);
            panel_owner_title.TabIndex = 2;
            // 
            // tabControl_owner_form
            // 
            tabControl_owner_form.Controls.Add(tabPage_owners);
            tabControl_owner_form.Controls.Add(tabPage_owner_details);
            tabControl_owner_form.Dock = DockStyle.Fill;
            tabControl_owner_form.Location = new Point(0, 65);
            tabControl_owner_form.Name = "tabControl_owner_form";
            tabControl_owner_form.SelectedIndex = 0;
            tabControl_owner_form.Size = new Size(1115, 617);
            tabControl_owner_form.TabIndex = 4;
            // 
            // tabPage_owners
            // 
            tabPage_owners.Controls.Add(button_owner_search);
            tabPage_owners.Controls.Add(textBox_owner_pet_search);
            tabPage_owners.Controls.Add(label_owner_pet_search);
            tabPage_owners.Controls.Add(button_owner_delete);
            tabPage_owners.Controls.Add(button_owner_edit);
            tabPage_owners.Controls.Add(button_owner_add_owner);
            tabPage_owners.Controls.Add(dataGridView_owners);
            tabPage_owners.Location = new Point(4, 24);
            tabPage_owners.Name = "tabPage_owners";
            tabPage_owners.Padding = new Padding(3);
            tabPage_owners.Size = new Size(1107, 589);
            tabPage_owners.TabIndex = 0;
            tabPage_owners.Text = "Owners";
            tabPage_owners.UseVisualStyleBackColor = true;
            // 
            // button_owner_search
            // 
            button_owner_search.Location = new Point(472, 6);
            button_owner_search.Name = "button_owner_search";
            button_owner_search.Size = new Size(75, 23);
            button_owner_search.TabIndex = 18;
            button_owner_search.Text = "Search";
            button_owner_search.UseVisualStyleBackColor = true;
            // 
            // textBox_owner_pet_search
            // 
            textBox_owner_pet_search.Location = new Point(56, 8);
            textBox_owner_pet_search.Name = "textBox_owner_pet_search";
            textBox_owner_pet_search.Size = new Size(374, 23);
            textBox_owner_pet_search.TabIndex = 17;
            // 
            // label_owner_pet_search
            // 
            label_owner_pet_search.AutoSize = true;
            label_owner_pet_search.Location = new Point(11, 13);
            label_owner_pet_search.Name = "label_owner_pet_search";
            label_owner_pet_search.Size = new Size(42, 15);
            label_owner_pet_search.TabIndex = 16;
            label_owner_pet_search.Text = "Search";
            // 
            // button_owner_delete
            // 
            button_owner_delete.Location = new Point(712, 8);
            button_owner_delete.Name = "button_owner_delete";
            button_owner_delete.Size = new Size(75, 23);
            button_owner_delete.TabIndex = 15;
            button_owner_delete.Text = "Delete";
            button_owner_delete.UseVisualStyleBackColor = true;
            // 
            // button_owner_edit
            // 
            button_owner_edit.Location = new Point(632, 7);
            button_owner_edit.Name = "button_owner_edit";
            button_owner_edit.Size = new Size(75, 23);
            button_owner_edit.TabIndex = 14;
            button_owner_edit.Text = "Edit";
            button_owner_edit.UseVisualStyleBackColor = true;
            // 
            // button_owner_add_owner
            // 
            button_owner_add_owner.Location = new Point(551, 7);
            button_owner_add_owner.Name = "button_owner_add_owner";
            button_owner_add_owner.Size = new Size(75, 23);
            button_owner_add_owner.TabIndex = 13;
            button_owner_add_owner.Text = "Add";
            button_owner_add_owner.UseVisualStyleBackColor = true;
            // 
            // dataGridView_owners
            // 
            dataGridView_owners.AllowUserToAddRows = false;
            dataGridView_owners.AllowUserToDeleteRows = false;
            dataGridView_owners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_owners.Dock = DockStyle.Bottom;
            dataGridView_owners.Location = new Point(3, 294);
            dataGridView_owners.MultiSelect = false;
            dataGridView_owners.Name = "dataGridView_owners";
            dataGridView_owners.ReadOnly = true;
            dataGridView_owners.RowTemplate.Height = 25;
            dataGridView_owners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_owners.Size = new Size(1101, 292);
            dataGridView_owners.TabIndex = 12;
            // 
            // tabPage_owner_details
            // 
            tabPage_owner_details.Controls.Add(button_owner_edit_pet);
            tabPage_owner_details.Controls.Add(button_owner_delete_pet);
            tabPage_owner_details.Controls.Add(button_owner_add_new_pet);
            tabPage_owner_details.Controls.Add(dataGridView_owner_pets);
            tabPage_owner_details.Controls.Add(numericUpDown_owner_id);
            tabPage_owner_details.Controls.Add(button_owner_cancel);
            tabPage_owner_details.Controls.Add(button_owner_save);
            tabPage_owner_details.Controls.Add(textBox_owner_email);
            tabPage_owner_details.Controls.Add(label_owner_email);
            tabPage_owner_details.Controls.Add(textBox_owner_phone);
            tabPage_owner_details.Controls.Add(label_owner_phone);
            tabPage_owner_details.Controls.Add(textBox_owner_name);
            tabPage_owner_details.Controls.Add(label_owner_name);
            tabPage_owner_details.Controls.Add(label_owner_id);
            tabPage_owner_details.Location = new Point(4, 24);
            tabPage_owner_details.Name = "tabPage_owner_details";
            tabPage_owner_details.Padding = new Padding(3);
            tabPage_owner_details.Size = new Size(1107, 589);
            tabPage_owner_details.TabIndex = 1;
            tabPage_owner_details.Text = "Owner Details";
            tabPage_owner_details.UseVisualStyleBackColor = true;
            // 
            // button_owner_edit_pet
            // 
            button_owner_edit_pet.Location = new Point(112, 357);
            button_owner_edit_pet.Name = "button_owner_edit_pet";
            button_owner_edit_pet.Size = new Size(92, 23);
            button_owner_edit_pet.TabIndex = 35;
            button_owner_edit_pet.Text = "Edit Pet";
            button_owner_edit_pet.UseVisualStyleBackColor = true;
            // 
            // button_owner_delete_pet
            // 
            button_owner_delete_pet.Location = new Point(112, 308);
            button_owner_delete_pet.Name = "button_owner_delete_pet";
            button_owner_delete_pet.Size = new Size(92, 23);
            button_owner_delete_pet.TabIndex = 34;
            button_owner_delete_pet.Text = "Delete Pet";
            button_owner_delete_pet.UseVisualStyleBackColor = true;
            // 
            // button_owner_add_new_pet
            // 
            button_owner_add_new_pet.Location = new Point(112, 264);
            button_owner_add_new_pet.Name = "button_owner_add_new_pet";
            button_owner_add_new_pet.Size = new Size(92, 23);
            button_owner_add_new_pet.TabIndex = 33;
            button_owner_add_new_pet.Text = "Add New Pet";
            button_owner_add_new_pet.UseVisualStyleBackColor = true;
            // 
            // dataGridView_owner_pets
            // 
            dataGridView_owner_pets.AllowUserToAddRows = false;
            dataGridView_owner_pets.AllowUserToDeleteRows = false;
            dataGridView_owner_pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_owner_pets.Location = new Point(377, 15);
            dataGridView_owner_pets.MultiSelect = false;
            dataGridView_owner_pets.Name = "dataGridView_owner_pets";
            dataGridView_owner_pets.ReadOnly = true;
            dataGridView_owner_pets.RowTemplate.Height = 25;
            dataGridView_owner_pets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_owner_pets.Size = new Size(722, 347);
            dataGridView_owner_pets.TabIndex = 32;
            // 
            // numericUpDown_owner_id
            // 
            numericUpDown_owner_id.Location = new Point(112, 15);
            numericUpDown_owner_id.Name = "numericUpDown_owner_id";
            numericUpDown_owner_id.Size = new Size(120, 23);
            numericUpDown_owner_id.TabIndex = 31;
            // 
            // button_owner_cancel
            // 
            button_owner_cancel.Location = new Point(112, 187);
            button_owner_cancel.Name = "button_owner_cancel";
            button_owner_cancel.Size = new Size(75, 23);
            button_owner_cancel.TabIndex = 30;
            button_owner_cancel.Text = "Cancel";
            button_owner_cancel.UseVisualStyleBackColor = true;
            // 
            // button_owner_save
            // 
            button_owner_save.Location = new Point(31, 187);
            button_owner_save.Name = "button_owner_save";
            button_owner_save.Size = new Size(75, 23);
            button_owner_save.TabIndex = 29;
            button_owner_save.Text = "Save";
            button_owner_save.UseVisualStyleBackColor = true;
            // 
            // textBox_owner_email
            // 
            textBox_owner_email.Location = new Point(122, 107);
            textBox_owner_email.Name = "textBox_owner_email";
            textBox_owner_email.Size = new Size(100, 23);
            textBox_owner_email.TabIndex = 26;
            // 
            // label_owner_email
            // 
            label_owner_email.AutoSize = true;
            label_owner_email.Location = new Point(19, 110);
            label_owner_email.Name = "label_owner_email";
            label_owner_email.Size = new Size(36, 15);
            label_owner_email.TabIndex = 25;
            label_owner_email.Text = "Email";
            // 
            // textBox_owner_phone
            // 
            textBox_owner_phone.Location = new Point(122, 78);
            textBox_owner_phone.Name = "textBox_owner_phone";
            textBox_owner_phone.Size = new Size(100, 23);
            textBox_owner_phone.TabIndex = 24;
            // 
            // label_owner_phone
            // 
            label_owner_phone.AutoSize = true;
            label_owner_phone.Location = new Point(19, 81);
            label_owner_phone.Name = "label_owner_phone";
            label_owner_phone.Size = new Size(41, 15);
            label_owner_phone.TabIndex = 23;
            label_owner_phone.Text = "Phone";
            // 
            // textBox_owner_name
            // 
            textBox_owner_name.Location = new Point(122, 49);
            textBox_owner_name.Name = "textBox_owner_name";
            textBox_owner_name.Size = new Size(100, 23);
            textBox_owner_name.TabIndex = 22;
            // 
            // label_owner_name
            // 
            label_owner_name.AutoSize = true;
            label_owner_name.Location = new Point(19, 52);
            label_owner_name.Name = "label_owner_name";
            label_owner_name.Size = new Size(39, 15);
            label_owner_name.TabIndex = 21;
            label_owner_name.Text = "Name";
            // 
            // label_owner_id
            // 
            label_owner_id.AutoSize = true;
            label_owner_id.Location = new Point(19, 23);
            label_owner_id.Name = "label_owner_id";
            label_owner_id.Size = new Size(56, 15);
            label_owner_id.TabIndex = 19;
            label_owner_id.Text = "Owner ID";
            // 
            // Owner_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 682);
            Controls.Add(tabControl_owner_form);
            Controls.Add(panel_owner_title);
            Name = "Owner_Form";
            Text = "Owner_Form";
            panel_owner_title.ResumeLayout(false);
            panel_owner_title.PerformLayout();
            tabControl_owner_form.ResumeLayout(false);
            tabPage_owners.ResumeLayout(false);
            tabPage_owners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_owners).EndInit();
            tabPage_owner_details.ResumeLayout(false);
            tabPage_owner_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_owner_pets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_owner_id).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_owner;
        private Panel panel_owner_title;
        private TabControl tabControl_owner_form;
        private TabPage tabPage_owners;
        private Button button_owner_search;
        private TextBox textBox_owner_pet_search;
        private Label label_owner_pet_search;
        private Button button_owner_delete;
        private Button button_owner_edit;
        private Button button_owner_add_owner;
        private DataGridView dataGridView_owners;
        private TabPage tabPage_owner_details;
        private TextBox textBox_owner_email;
        private Label label_owner_email;
        private TextBox textBox_owner_phone;
        private Label label_owner_phone;
        private TextBox textBox_owner_name;
        private Label label_owner_name;
        private Label label_owner_id;
        private Button button_owner_cancel;
        private Button button_owner_save;
        private NumericUpDown numericUpDown_owner_id;
        private DataGridView dataGridView_owner_pets;
        private Button button_owner_add_new_pet;
        private Button button_owner_edit_pet;
        private Button button_owner_delete_pet;
    }
}