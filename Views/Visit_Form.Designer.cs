namespace Veterinary_CRUD_App.Views
{
    partial class Visit_Form
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
            label_visits = new Label();
            panel_visits_title = new Panel();
            tabControl_visits_form = new TabControl();
            tabPage_visit_list = new TabPage();
            dataGridView_visits_pets = new DataGridView();
            button_visit_search = new Button();
            textBox_visit_search = new TextBox();
            label_visit_search = new Label();
            button_visit_delete = new Button();
            button_visit_edit = new Button();
            button_visit_add_new_visit = new Button();
            tabPage_visit_details = new TabPage();
            comboBox_visit_pet_id = new ComboBox();
            numericUpDown_visit_id = new NumericUpDown();
            dateTimePicker_visit_date = new DateTimePicker();
            button_visit_cancel = new Button();
            button_visit_save = new Button();
            textBox_visit_description = new TextBox();
            label_visit_description = new Label();
            label_visit_date = new Label();
            textBox_visit_type = new TextBox();
            label_visit_type = new Label();
            label_visit_pet_id = new Label();
            label_visit_id = new Label();
            button_visit_edit_pet = new Button();
            panel_visits_title.SuspendLayout();
            tabControl_visits_form.SuspendLayout();
            tabPage_visit_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_visits_pets).BeginInit();
            tabPage_visit_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_visit_id).BeginInit();
            SuspendLayout();
            // 
            // label_visits
            // 
            label_visits.AutoSize = true;
            label_visits.Location = new Point(40, 29);
            label_visits.Name = "label_visits";
            label_visits.Size = new Size(34, 15);
            label_visits.TabIndex = 0;
            label_visits.Text = "Visits";
            // 
            // panel_visits_title
            // 
            panel_visits_title.BackColor = Color.White;
            panel_visits_title.Controls.Add(label_visits);
            panel_visits_title.Dock = DockStyle.Top;
            panel_visits_title.Location = new Point(0, 0);
            panel_visits_title.Name = "panel_visits_title";
            panel_visits_title.Size = new Size(1147, 65);
            panel_visits_title.TabIndex = 2;
            // 
            // tabControl_visits_form
            // 
            tabControl_visits_form.Controls.Add(tabPage_visit_list);
            tabControl_visits_form.Controls.Add(tabPage_visit_details);
            tabControl_visits_form.Dock = DockStyle.Fill;
            tabControl_visits_form.Location = new Point(0, 65);
            tabControl_visits_form.Name = "tabControl_visits_form";
            tabControl_visits_form.SelectedIndex = 0;
            tabControl_visits_form.Size = new Size(1147, 615);
            tabControl_visits_form.TabIndex = 3;
            // 
            // tabPage_visit_list
            // 
            tabPage_visit_list.Controls.Add(dataGridView_visits_pets);
            tabPage_visit_list.Controls.Add(button_visit_search);
            tabPage_visit_list.Controls.Add(textBox_visit_search);
            tabPage_visit_list.Controls.Add(label_visit_search);
            tabPage_visit_list.Controls.Add(button_visit_delete);
            tabPage_visit_list.Controls.Add(button_visit_edit);
            tabPage_visit_list.Controls.Add(button_visit_add_new_visit);
            tabPage_visit_list.Location = new Point(4, 24);
            tabPage_visit_list.Name = "tabPage_visit_list";
            tabPage_visit_list.Padding = new Padding(3);
            tabPage_visit_list.Size = new Size(1139, 587);
            tabPage_visit_list.TabIndex = 0;
            tabPage_visit_list.Text = "Visit List";
            tabPage_visit_list.UseVisualStyleBackColor = true;
            // 
            // dataGridView_visits_pets
            // 
            dataGridView_visits_pets.AllowUserToAddRows = false;
            dataGridView_visits_pets.AllowUserToDeleteRows = false;
            dataGridView_visits_pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_visits_pets.Dock = DockStyle.Bottom;
            dataGridView_visits_pets.Location = new Point(3, 160);
            dataGridView_visits_pets.Name = "dataGridView_visits_pets";
            dataGridView_visits_pets.ReadOnly = true;
            dataGridView_visits_pets.RowTemplate.Height = 25;
            dataGridView_visits_pets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_visits_pets.Size = new Size(1133, 424);
            dataGridView_visits_pets.TabIndex = 12;
            // 
            // button_visit_search
            // 
            button_visit_search.Location = new Point(472, 6);
            button_visit_search.Name = "button_visit_search";
            button_visit_search.Size = new Size(75, 23);
            button_visit_search.TabIndex = 18;
            button_visit_search.Text = "Search";
            button_visit_search.UseVisualStyleBackColor = true;
            // 
            // textBox_visit_search
            // 
            textBox_visit_search.Location = new Point(56, 8);
            textBox_visit_search.Name = "textBox_visit_search";
            textBox_visit_search.Size = new Size(374, 23);
            textBox_visit_search.TabIndex = 17;
            // 
            // label_visit_search
            // 
            label_visit_search.AutoSize = true;
            label_visit_search.Location = new Point(8, 10);
            label_visit_search.Name = "label_visit_search";
            label_visit_search.Size = new Size(42, 15);
            label_visit_search.TabIndex = 16;
            label_visit_search.Text = "Search";
            // 
            // button_visit_delete
            // 
            button_visit_delete.Location = new Point(712, 8);
            button_visit_delete.Name = "button_visit_delete";
            button_visit_delete.Size = new Size(75, 23);
            button_visit_delete.TabIndex = 15;
            button_visit_delete.Text = "Delete";
            button_visit_delete.UseVisualStyleBackColor = true;
            // 
            // button_visit_edit
            // 
            button_visit_edit.Location = new Point(632, 7);
            button_visit_edit.Name = "button_visit_edit";
            button_visit_edit.Size = new Size(75, 23);
            button_visit_edit.TabIndex = 14;
            button_visit_edit.Text = "Edit";
            button_visit_edit.UseVisualStyleBackColor = true;
            // 
            // button_visit_add_new_visit
            // 
            button_visit_add_new_visit.Location = new Point(551, 7);
            button_visit_add_new_visit.Name = "button_visit_add_new_visit";
            button_visit_add_new_visit.Size = new Size(75, 23);
            button_visit_add_new_visit.TabIndex = 13;
            button_visit_add_new_visit.Text = "Add";
            button_visit_add_new_visit.UseVisualStyleBackColor = true;
            // 
            // tabPage_visit_details
            // 
            tabPage_visit_details.Controls.Add(button_visit_edit_pet);
            tabPage_visit_details.Controls.Add(comboBox_visit_pet_id);
            tabPage_visit_details.Controls.Add(numericUpDown_visit_id);
            tabPage_visit_details.Controls.Add(dateTimePicker_visit_date);
            tabPage_visit_details.Controls.Add(button_visit_cancel);
            tabPage_visit_details.Controls.Add(button_visit_save);
            tabPage_visit_details.Controls.Add(textBox_visit_description);
            tabPage_visit_details.Controls.Add(label_visit_description);
            tabPage_visit_details.Controls.Add(label_visit_date);
            tabPage_visit_details.Controls.Add(textBox_visit_type);
            tabPage_visit_details.Controls.Add(label_visit_type);
            tabPage_visit_details.Controls.Add(label_visit_pet_id);
            tabPage_visit_details.Controls.Add(label_visit_id);
            tabPage_visit_details.Location = new Point(4, 24);
            tabPage_visit_details.Name = "tabPage_visit_details";
            tabPage_visit_details.Padding = new Padding(3);
            tabPage_visit_details.Size = new Size(1139, 587);
            tabPage_visit_details.TabIndex = 1;
            tabPage_visit_details.Text = "Visit Details";
            tabPage_visit_details.UseVisualStyleBackColor = true;
            // 
            // comboBox_visit_pet_id
            // 
            comboBox_visit_pet_id.FormattingEnabled = true;
            comboBox_visit_pet_id.Location = new Point(101, 49);
            comboBox_visit_pet_id.Name = "comboBox_visit_pet_id";
            comboBox_visit_pet_id.Size = new Size(121, 23);
            comboBox_visit_pet_id.TabIndex = 34;
            // 
            // numericUpDown_visit_id
            // 
            numericUpDown_visit_id.Location = new Point(102, 18);
            numericUpDown_visit_id.Name = "numericUpDown_visit_id";
            numericUpDown_visit_id.Size = new Size(120, 23);
            numericUpDown_visit_id.TabIndex = 32;
            // 
            // dateTimePicker_visit_date
            // 
            dateTimePicker_visit_date.Location = new Point(125, 109);
            dateTimePicker_visit_date.Name = "dateTimePicker_visit_date";
            dateTimePicker_visit_date.Size = new Size(200, 23);
            dateTimePicker_visit_date.TabIndex = 31;
            // 
            // button_visit_cancel
            // 
            button_visit_cancel.Location = new Point(112, 187);
            button_visit_cancel.Name = "button_visit_cancel";
            button_visit_cancel.Size = new Size(75, 23);
            button_visit_cancel.TabIndex = 30;
            button_visit_cancel.Text = "Cancel";
            button_visit_cancel.UseVisualStyleBackColor = true;
            // 
            // button_visit_save
            // 
            button_visit_save.Location = new Point(31, 187);
            button_visit_save.Name = "button_visit_save";
            button_visit_save.Size = new Size(75, 23);
            button_visit_save.TabIndex = 29;
            button_visit_save.Text = "Save";
            button_visit_save.UseVisualStyleBackColor = true;
            // 
            // textBox_visit_description
            // 
            textBox_visit_description.Location = new Point(122, 136);
            textBox_visit_description.Name = "textBox_visit_description";
            textBox_visit_description.Size = new Size(100, 23);
            textBox_visit_description.TabIndex = 28;
            // 
            // label_visit_description
            // 
            label_visit_description.AutoSize = true;
            label_visit_description.Location = new Point(16, 136);
            label_visit_description.Name = "label_visit_description";
            label_visit_description.Size = new Size(67, 15);
            label_visit_description.TabIndex = 27;
            label_visit_description.Text = "Description";
            // 
            // label_visit_date
            // 
            label_visit_date.AutoSize = true;
            label_visit_date.Location = new Point(16, 107);
            label_visit_date.Name = "label_visit_date";
            label_visit_date.Size = new Size(31, 15);
            label_visit_date.TabIndex = 25;
            label_visit_date.Text = "Date";
            // 
            // textBox_visit_type
            // 
            textBox_visit_type.Location = new Point(122, 78);
            textBox_visit_type.Name = "textBox_visit_type";
            textBox_visit_type.Size = new Size(100, 23);
            textBox_visit_type.TabIndex = 24;
            // 
            // label_visit_type
            // 
            label_visit_type.AutoSize = true;
            label_visit_type.Location = new Point(16, 78);
            label_visit_type.Name = "label_visit_type";
            label_visit_type.Size = new Size(56, 15);
            label_visit_type.TabIndex = 23;
            label_visit_type.Text = "Visit Type";
            // 
            // label_visit_pet_id
            // 
            label_visit_pet_id.AutoSize = true;
            label_visit_pet_id.Location = new Point(16, 49);
            label_visit_pet_id.Name = "label_visit_pet_id";
            label_visit_pet_id.Size = new Size(38, 15);
            label_visit_pet_id.TabIndex = 21;
            label_visit_pet_id.Text = "Pet ID";
            // 
            // label_visit_id
            // 
            label_visit_id.AutoSize = true;
            label_visit_id.Location = new Point(16, 20);
            label_visit_id.Name = "label_visit_id";
            label_visit_id.Size = new Size(43, 15);
            label_visit_id.TabIndex = 19;
            label_visit_id.Text = "Visit ID";
            // 
            // button_visit_edit_pet
            // 
            button_visit_edit_pet.Location = new Point(205, 187);
            button_visit_edit_pet.Name = "button_visit_edit_pet";
            button_visit_edit_pet.Size = new Size(75, 23);
            button_visit_edit_pet.TabIndex = 35;
            button_visit_edit_pet.Text = "Edit Pet";
            button_visit_edit_pet.UseVisualStyleBackColor = true;
            // 
            // Visit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 680);
            Controls.Add(tabControl_visits_form);
            Controls.Add(panel_visits_title);
            Name = "Visit_Form";
            Text = "Visit_Form";
            panel_visits_title.ResumeLayout(false);
            panel_visits_title.PerformLayout();
            tabControl_visits_form.ResumeLayout(false);
            tabPage_visit_list.ResumeLayout(false);
            tabPage_visit_list.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_visits_pets).EndInit();
            tabPage_visit_details.ResumeLayout(false);
            tabPage_visit_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_visit_id).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label_visits;
        private Panel panel_visits_title;
        private TabControl tabControl_visits_form;
        private TabPage tabPage_visit_list;
        private TabPage tabPage_visit_details;
        private Button button_visit_search;
        private TextBox textBox_visit_search;
        private Label label_visit_search;
        private Button button_visit_delete;
        private Button button_visit_edit;
        private Button button_visit_add_new_visit;
        private DataGridView dataGridView_visits_pets;
        private Button button_visit_cancel;
        private Button button_visit_save;
        private TextBox textBox_visit_description;
        private Label label_visit_description;
        private Label label_visit_date;
        private TextBox textBox_visit_type;
        private Label label_visit_type;
        private Label label_visit_pet_id;
        private Label label_visit_id;
        private DateTimePicker dateTimePicker_visit_date;
        private NumericUpDown numericUpDown_visit_id;
        private ComboBox comboBox_visit_pet_id;
        private Button button_visit_edit_pet;
    }
}