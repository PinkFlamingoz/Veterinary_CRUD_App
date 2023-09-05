namespace Veterinary_CRUD_App.Views
{
    partial class Pet_Form
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
            tabControl_pets_form = new TabControl();
            tabPage_pet_list = new TabPage();
            dataGridView_pets = new DataGridView();
            button_pet_delete = new Button();
            button_pet_edit = new Button();
            button_pet_add_new = new Button();
            button_pet_search = new Button();
            textBox_pet_search = new TextBox();
            label_pet_search = new Label();
            tabPage_pet_details = new TabPage();
            button_pet_delete_visit = new Button();
            button_pet_add_visit = new Button();
            comboBox_pet_owner_id = new ComboBox();
            button_pet_add_owner = new Button();
            button_pet_upload_picture = new Button();
            numericUpDown_pet_id = new NumericUpDown();
            numericUpDown_pet_age = new NumericUpDown();
            dateTimePicker_pet_birthdate = new DateTimePicker();
            button_pet_edit_owner = new Button();
            button_pet_edit_visits = new Button();
            dataGridView_pet_visits = new DataGridView();
            button_pet_cancel = new Button();
            button_pet_save = new Button();
            pictureBox_pet_picture = new PictureBox();
            label_pet_birthdate = new Label();
            textBox_pet_sex = new TextBox();
            label_pet_sex = new Label();
            label_pet_age = new Label();
            textBox_pet_colour = new TextBox();
            label_pet_colour = new Label();
            textBox_pet_type = new TextBox();
            label_pet_type = new Label();
            textBox_pet_name = new TextBox();
            label_pet_name = new Label();
            label_pet_owner_id = new Label();
            label_pet_id = new Label();
            tabControl_pets_form.SuspendLayout();
            tabPage_pet_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pets).BeginInit();
            tabPage_pet_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pet_visits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_pet_picture).BeginInit();
            SuspendLayout();
            // 
            // tabControl_pets_form
            // 
            tabControl_pets_form.Controls.Add(tabPage_pet_list);
            tabControl_pets_form.Controls.Add(tabPage_pet_details);
            tabControl_pets_form.Dock = DockStyle.Fill;
            tabControl_pets_form.Location = new Point(0, 0);
            tabControl_pets_form.Name = "tabControl_pets_form";
            tabControl_pets_form.SelectedIndex = 0;
            tabControl_pets_form.Size = new Size(1095, 655);
            tabControl_pets_form.TabIndex = 2;
            // 
            // tabPage_pet_list
            // 
            tabPage_pet_list.Controls.Add(dataGridView_pets);
            tabPage_pet_list.Controls.Add(button_pet_delete);
            tabPage_pet_list.Controls.Add(button_pet_edit);
            tabPage_pet_list.Controls.Add(button_pet_add_new);
            tabPage_pet_list.Controls.Add(button_pet_search);
            tabPage_pet_list.Controls.Add(textBox_pet_search);
            tabPage_pet_list.Controls.Add(label_pet_search);
            tabPage_pet_list.Location = new Point(4, 24);
            tabPage_pet_list.Name = "tabPage_pet_list";
            tabPage_pet_list.Padding = new Padding(3);
            tabPage_pet_list.Size = new Size(1087, 627);
            tabPage_pet_list.TabIndex = 0;
            tabPage_pet_list.Text = "Pet List";
            tabPage_pet_list.UseVisualStyleBackColor = true;
            // 
            // dataGridView_pets
            // 
            dataGridView_pets.AllowUserToAddRows = false;
            dataGridView_pets.AllowUserToDeleteRows = false;
            dataGridView_pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_pets.Dock = DockStyle.Bottom;
            dataGridView_pets.Location = new Point(3, 330);
            dataGridView_pets.MultiSelect = false;
            dataGridView_pets.Name = "dataGridView_pets";
            dataGridView_pets.ReadOnly = true;
            dataGridView_pets.RowTemplate.Height = 25;
            dataGridView_pets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_pets.Size = new Size(1081, 294);
            dataGridView_pets.TabIndex = 6;
            // 
            // button_pet_delete
            // 
            button_pet_delete.Location = new Point(714, 10);
            button_pet_delete.Name = "button_pet_delete";
            button_pet_delete.Size = new Size(75, 23);
            button_pet_delete.TabIndex = 5;
            button_pet_delete.Text = "Delete";
            button_pet_delete.UseVisualStyleBackColor = true;
            // 
            // button_pet_edit
            // 
            button_pet_edit.Location = new Point(634, 9);
            button_pet_edit.Name = "button_pet_edit";
            button_pet_edit.Size = new Size(75, 23);
            button_pet_edit.TabIndex = 4;
            button_pet_edit.Text = "Edit";
            button_pet_edit.UseVisualStyleBackColor = true;
            // 
            // button_pet_add_new
            // 
            button_pet_add_new.Location = new Point(553, 9);
            button_pet_add_new.Name = "button_pet_add_new";
            button_pet_add_new.Size = new Size(75, 23);
            button_pet_add_new.TabIndex = 3;
            button_pet_add_new.Text = "Add Pet";
            button_pet_add_new.UseVisualStyleBackColor = true;
            // 
            // button_pet_search
            // 
            button_pet_search.Location = new Point(472, 9);
            button_pet_search.Name = "button_pet_search";
            button_pet_search.Size = new Size(75, 23);
            button_pet_search.TabIndex = 2;
            button_pet_search.Text = "Search";
            button_pet_search.UseVisualStyleBackColor = true;
            // 
            // textBox_pet_search
            // 
            textBox_pet_search.Location = new Point(56, 11);
            textBox_pet_search.Name = "textBox_pet_search";
            textBox_pet_search.Size = new Size(374, 23);
            textBox_pet_search.TabIndex = 1;
            // 
            // label_pet_search
            // 
            label_pet_search.AutoSize = true;
            label_pet_search.Location = new Point(8, 13);
            label_pet_search.Name = "label_pet_search";
            label_pet_search.Size = new Size(42, 15);
            label_pet_search.TabIndex = 0;
            label_pet_search.Text = "Search";
            // 
            // tabPage_pet_details
            // 
            tabPage_pet_details.Controls.Add(button_pet_delete_visit);
            tabPage_pet_details.Controls.Add(button_pet_add_visit);
            tabPage_pet_details.Controls.Add(comboBox_pet_owner_id);
            tabPage_pet_details.Controls.Add(button_pet_add_owner);
            tabPage_pet_details.Controls.Add(button_pet_upload_picture);
            tabPage_pet_details.Controls.Add(numericUpDown_pet_id);
            tabPage_pet_details.Controls.Add(numericUpDown_pet_age);
            tabPage_pet_details.Controls.Add(dateTimePicker_pet_birthdate);
            tabPage_pet_details.Controls.Add(button_pet_edit_owner);
            tabPage_pet_details.Controls.Add(button_pet_edit_visits);
            tabPage_pet_details.Controls.Add(dataGridView_pet_visits);
            tabPage_pet_details.Controls.Add(button_pet_cancel);
            tabPage_pet_details.Controls.Add(button_pet_save);
            tabPage_pet_details.Controls.Add(pictureBox_pet_picture);
            tabPage_pet_details.Controls.Add(label_pet_birthdate);
            tabPage_pet_details.Controls.Add(textBox_pet_sex);
            tabPage_pet_details.Controls.Add(label_pet_sex);
            tabPage_pet_details.Controls.Add(label_pet_age);
            tabPage_pet_details.Controls.Add(textBox_pet_colour);
            tabPage_pet_details.Controls.Add(label_pet_colour);
            tabPage_pet_details.Controls.Add(textBox_pet_type);
            tabPage_pet_details.Controls.Add(label_pet_type);
            tabPage_pet_details.Controls.Add(textBox_pet_name);
            tabPage_pet_details.Controls.Add(label_pet_name);
            tabPage_pet_details.Controls.Add(label_pet_owner_id);
            tabPage_pet_details.Controls.Add(label_pet_id);
            tabPage_pet_details.Location = new Point(4, 24);
            tabPage_pet_details.Name = "tabPage_pet_details";
            tabPage_pet_details.Padding = new Padding(3);
            tabPage_pet_details.Size = new Size(1087, 562);
            tabPage_pet_details.TabIndex = 1;
            tabPage_pet_details.Text = "Pet Details";
            tabPage_pet_details.UseVisualStyleBackColor = true;
            // 
            // button_pet_delete_visit
            // 
            button_pet_delete_visit.Location = new Point(341, 259);
            button_pet_delete_visit.Name = "button_pet_delete_visit";
            button_pet_delete_visit.Size = new Size(75, 23);
            button_pet_delete_visit.TabIndex = 31;
            button_pet_delete_visit.Text = "Delete Visit";
            button_pet_delete_visit.UseVisualStyleBackColor = true;
            // 
            // button_pet_add_visit
            // 
            button_pet_add_visit.Location = new Point(341, 288);
            button_pet_add_visit.Name = "button_pet_add_visit";
            button_pet_add_visit.Size = new Size(75, 23);
            button_pet_add_visit.TabIndex = 30;
            button_pet_add_visit.Text = "Add Visit";
            button_pet_add_visit.UseVisualStyleBackColor = true;
            // 
            // comboBox_pet_owner_id
            // 
            comboBox_pet_owner_id.FormattingEnabled = true;
            comboBox_pet_owner_id.Location = new Point(113, 49);
            comboBox_pet_owner_id.Name = "comboBox_pet_owner_id";
            comboBox_pet_owner_id.Size = new Size(121, 23);
            comboBox_pet_owner_id.TabIndex = 29;
            // 
            // button_pet_add_owner
            // 
            button_pet_add_owner.Location = new Point(260, 288);
            button_pet_add_owner.Name = "button_pet_add_owner";
            button_pet_add_owner.Size = new Size(75, 23);
            button_pet_add_owner.TabIndex = 28;
            button_pet_add_owner.Text = "Add Owner";
            button_pet_add_owner.UseVisualStyleBackColor = true;
            // 
            // button_pet_upload_picture
            // 
            button_pet_upload_picture.Location = new Point(341, 233);
            button_pet_upload_picture.Name = "button_pet_upload_picture";
            button_pet_upload_picture.Size = new Size(113, 23);
            button_pet_upload_picture.TabIndex = 26;
            button_pet_upload_picture.Text = "Upload Picture";
            button_pet_upload_picture.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_pet_id
            // 
            numericUpDown_pet_id.Location = new Point(113, 18);
            numericUpDown_pet_id.Name = "numericUpDown_pet_id";
            numericUpDown_pet_id.Size = new Size(120, 23);
            numericUpDown_pet_id.TabIndex = 24;
            // 
            // numericUpDown_pet_age
            // 
            numericUpDown_pet_age.Location = new Point(113, 165);
            numericUpDown_pet_age.Name = "numericUpDown_pet_age";
            numericUpDown_pet_age.Size = new Size(120, 23);
            numericUpDown_pet_age.TabIndex = 23;
            // 
            // dateTimePicker_pet_birthdate
            // 
            dateTimePicker_pet_birthdate.Location = new Point(135, 231);
            dateTimePicker_pet_birthdate.Name = "dateTimePicker_pet_birthdate";
            dateTimePicker_pet_birthdate.Size = new Size(200, 23);
            dateTimePicker_pet_birthdate.TabIndex = 22;
            // 
            // button_pet_edit_owner
            // 
            button_pet_edit_owner.Location = new Point(260, 194);
            button_pet_edit_owner.Name = "button_pet_edit_owner";
            button_pet_edit_owner.Size = new Size(75, 23);
            button_pet_edit_owner.TabIndex = 21;
            button_pet_edit_owner.Text = "Edit Owner";
            button_pet_edit_owner.UseVisualStyleBackColor = true;
            // 
            // button_pet_edit_visits
            // 
            button_pet_edit_visits.Location = new Point(341, 194);
            button_pet_edit_visits.Name = "button_pet_edit_visits";
            button_pet_edit_visits.Size = new Size(75, 23);
            button_pet_edit_visits.TabIndex = 20;
            button_pet_edit_visits.Text = "Edit Visits";
            button_pet_edit_visits.UseVisualStyleBackColor = true;
            // 
            // dataGridView_pet_visits
            // 
            dataGridView_pet_visits.AllowUserToAddRows = false;
            dataGridView_pet_visits.AllowUserToDeleteRows = false;
            dataGridView_pet_visits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_pet_visits.Location = new Point(460, 6);
            dataGridView_pet_visits.MultiSelect = false;
            dataGridView_pet_visits.Name = "dataGridView_pet_visits";
            dataGridView_pet_visits.ReadOnly = true;
            dataGridView_pet_visits.RowTemplate.Height = 25;
            dataGridView_pet_visits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_pet_visits.Size = new Size(619, 337);
            dataGridView_pet_visits.TabIndex = 19;
            // 
            // button_pet_cancel
            // 
            button_pet_cancel.Location = new Point(341, 164);
            button_pet_cancel.Name = "button_pet_cancel";
            button_pet_cancel.Size = new Size(75, 23);
            button_pet_cancel.TabIndex = 18;
            button_pet_cancel.Text = "Cancel";
            button_pet_cancel.UseVisualStyleBackColor = true;
            // 
            // button_pet_save
            // 
            button_pet_save.Location = new Point(260, 164);
            button_pet_save.Name = "button_pet_save";
            button_pet_save.Size = new Size(75, 23);
            button_pet_save.TabIndex = 17;
            button_pet_save.Text = "Save";
            button_pet_save.UseVisualStyleBackColor = true;
            // 
            // pictureBox_pet_picture
            // 
            pictureBox_pet_picture.Image = Properties.Resources.Default_Pet_Image;
            pictureBox_pet_picture.Location = new Point(270, 20);
            pictureBox_pet_picture.Name = "pictureBox_pet_picture";
            pictureBox_pet_picture.Size = new Size(122, 122);
            pictureBox_pet_picture.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_pet_picture.TabIndex = 16;
            pictureBox_pet_picture.TabStop = false;
            // 
            // label_pet_birthdate
            // 
            label_pet_birthdate.AutoSize = true;
            label_pet_birthdate.Location = new Point(27, 223);
            label_pet_birthdate.Name = "label_pet_birthdate";
            label_pet_birthdate.Size = new Size(51, 15);
            label_pet_birthdate.TabIndex = 14;
            label_pet_birthdate.Text = "Birthday";
            // 
            // textBox_pet_sex
            // 
            textBox_pet_sex.Location = new Point(133, 194);
            textBox_pet_sex.Name = "textBox_pet_sex";
            textBox_pet_sex.Size = new Size(100, 23);
            textBox_pet_sex.TabIndex = 13;
            // 
            // label_pet_sex
            // 
            label_pet_sex.AutoSize = true;
            label_pet_sex.Location = new Point(27, 194);
            label_pet_sex.Name = "label_pet_sex";
            label_pet_sex.Size = new Size(25, 15);
            label_pet_sex.TabIndex = 12;
            label_pet_sex.Text = "Sex";
            // 
            // label_pet_age
            // 
            label_pet_age.AutoSize = true;
            label_pet_age.Location = new Point(27, 165);
            label_pet_age.Name = "label_pet_age";
            label_pet_age.Size = new Size(28, 15);
            label_pet_age.TabIndex = 10;
            label_pet_age.Text = "Age";
            // 
            // textBox_pet_colour
            // 
            textBox_pet_colour.Location = new Point(133, 136);
            textBox_pet_colour.Name = "textBox_pet_colour";
            textBox_pet_colour.Size = new Size(100, 23);
            textBox_pet_colour.TabIndex = 9;
            // 
            // label_pet_colour
            // 
            label_pet_colour.AutoSize = true;
            label_pet_colour.Location = new Point(27, 136);
            label_pet_colour.Name = "label_pet_colour";
            label_pet_colour.Size = new Size(43, 15);
            label_pet_colour.TabIndex = 8;
            label_pet_colour.Text = "Colour";
            // 
            // textBox_pet_type
            // 
            textBox_pet_type.Location = new Point(133, 107);
            textBox_pet_type.Name = "textBox_pet_type";
            textBox_pet_type.Size = new Size(100, 23);
            textBox_pet_type.TabIndex = 7;
            // 
            // label_pet_type
            // 
            label_pet_type.AutoSize = true;
            label_pet_type.Location = new Point(27, 107);
            label_pet_type.Name = "label_pet_type";
            label_pet_type.Size = new Size(31, 15);
            label_pet_type.TabIndex = 6;
            label_pet_type.Text = "Type";
            // 
            // textBox_pet_name
            // 
            textBox_pet_name.Location = new Point(133, 78);
            textBox_pet_name.Name = "textBox_pet_name";
            textBox_pet_name.Size = new Size(100, 23);
            textBox_pet_name.TabIndex = 5;
            // 
            // label_pet_name
            // 
            label_pet_name.AutoSize = true;
            label_pet_name.Location = new Point(27, 78);
            label_pet_name.Name = "label_pet_name";
            label_pet_name.Size = new Size(39, 15);
            label_pet_name.TabIndex = 4;
            label_pet_name.Text = "Name";
            // 
            // label_pet_owner_id
            // 
            label_pet_owner_id.AutoSize = true;
            label_pet_owner_id.Location = new Point(27, 49);
            label_pet_owner_id.Name = "label_pet_owner_id";
            label_pet_owner_id.Size = new Size(56, 15);
            label_pet_owner_id.TabIndex = 2;
            label_pet_owner_id.Text = "Owner ID";
            // 
            // label_pet_id
            // 
            label_pet_id.AutoSize = true;
            label_pet_id.Location = new Point(27, 20);
            label_pet_id.Name = "label_pet_id";
            label_pet_id.Size = new Size(38, 15);
            label_pet_id.TabIndex = 0;
            label_pet_id.Text = "Pet ID";
            // 
            // Pet_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 655);
            Controls.Add(tabControl_pets_form);
            Name = "Pet_Form";
            Text = "Pet_From";
            tabControl_pets_form.ResumeLayout(false);
            tabPage_pet_list.ResumeLayout(false);
            tabPage_pet_list.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pets).EndInit();
            tabPage_pet_details.ResumeLayout(false);
            tabPage_pet_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pet_visits).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_pet_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl_pets_form;
        private TabPage tabPage_pet_list;
        private TabPage tabPage_pet_details;
        private DataGridView dataGridView_pets;
        private Button button_pet_delete;
        private Button button_pet_edit;
        private Button button_pet_add_new;
        private Button button_pet_search;
        private TextBox textBox_pet_search;
        private Label label_pet_search;
        private Label label_pet_id;
        private Label label_pet_birthdate;
        private TextBox textBox_pet_sex;
        private Label label_pet_sex;
        private Label label_pet_age;
        private TextBox textBox_pet_colour;
        private Label label_pet_colour;
        private TextBox textBox_pet_type;
        private Label label_pet_type;
        private TextBox textBox_pet_name;
        private Label label_pet_name;
        private Label label_pet_owner_id;
        private Button button_pet_cancel;
        private Button button_pet_save;
        private PictureBox pictureBox_pet_picture;
        private Button button_pet_edit_visits;
        private DataGridView dataGridView_pet_visits;
        private Button button_pet_edit_owner;
        private DateTimePicker dateTimePicker_pet_birthdate;
        private NumericUpDown numericUpDown_pet_age;
        private NumericUpDown numericUpDown_pet_id;
        private Button button_pet_upload_picture;
        private Button button_pet_add_owner;
        private ComboBox comboBox_pet_owner_id;
        private Button button_pet_add_visit;
        private Button button_pet_delete_visit;
    }
}