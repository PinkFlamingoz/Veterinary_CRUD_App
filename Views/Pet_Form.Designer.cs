﻿namespace Veterinary_CRUD_App.Views
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
            dataGridView_pets = new DataGridView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            button_pet_delete = new MaterialSkin.Controls.MaterialButton();
            button_pet_edit = new MaterialSkin.Controls.MaterialButton();
            button_pet_add_new = new MaterialSkin.Controls.MaterialButton();
            button_pet_search = new MaterialSkin.Controls.MaterialButton();
            textBox_pet_search = new MaterialSkin.Controls.MaterialTextBox2();
            numericUpDown_pet_id = new NumericUpDown();
            numericUpDown_pet_age = new NumericUpDown();
            dateTimePicker_pet_birthdate = new DateTimePicker();
            dataGridView_pet_visits = new DataGridView();
            pictureBox_pet_picture = new PictureBox();
            tabControl_pets_form = new MaterialSkin.Controls.MaterialTabControl();
            tabPage_pet_list = new TabPage();
            tabPage_pet_details = new TabPage();
            panel_container_data = new Panel();
            panel_container = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            panel_buttons_container = new Panel();
            button_pet_upload_picture = new MaterialSkin.Controls.MaterialButton();
            button_pet_save = new MaterialSkin.Controls.MaterialButton();
            button_pet_delete_visit = new MaterialSkin.Controls.MaterialButton();
            button_pet_edit_owner = new MaterialSkin.Controls.MaterialButton();
            button_pet_add_visit = new MaterialSkin.Controls.MaterialButton();
            button_pet_cancel = new MaterialSkin.Controls.MaterialButton();
            button_pet_add_owner = new MaterialSkin.Controls.MaterialButton();
            button_pet_edit_visits = new MaterialSkin.Controls.MaterialButton();
            materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            materialLabel_pet_id = new MaterialSkin.Controls.MaterialLabel();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            materialLabel_pet_age = new MaterialSkin.Controls.MaterialLabel();
            materialLabel_pet_birthday = new MaterialSkin.Controls.MaterialLabel();
            textBox_pet_sex = new MaterialSkin.Controls.MaterialTextBox2();
            textBox_pet_colour = new MaterialSkin.Controls.MaterialTextBox2();
            textBox_pet_type = new MaterialSkin.Controls.MaterialTextBox2();
            textBox_pet_name = new MaterialSkin.Controls.MaterialTextBox2();
            comboBox_pet_owner_id = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pets).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pet_visits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_pet_picture).BeginInit();
            tabControl_pets_form.SuspendLayout();
            tabPage_pet_list.SuspendLayout();
            tabPage_pet_details.SuspendLayout();
            panel_container_data.SuspendLayout();
            panel_container.SuspendLayout();
            materialCard2.SuspendLayout();
            panel_buttons_container.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_pets
            // 
            dataGridView_pets.AllowUserToAddRows = false;
            dataGridView_pets.AllowUserToDeleteRows = false;
            dataGridView_pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_pets.Dock = DockStyle.Bottom;
            dataGridView_pets.Location = new Point(3, 421);
            dataGridView_pets.MultiSelect = false;
            dataGridView_pets.Name = "dataGridView_pets";
            dataGridView_pets.ReadOnly = true;
            dataGridView_pets.RowTemplate.Height = 25;
            dataGridView_pets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_pets.Size = new Size(1580, 442);
            dataGridView_pets.TabIndex = 6;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(button_pet_delete);
            materialCard1.Controls.Add(button_pet_edit);
            materialCard1.Controls.Add(button_pet_add_new);
            materialCard1.Controls.Add(button_pet_search);
            materialCard1.Controls.Add(textBox_pet_search);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 3);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1580, 85);
            materialCard1.TabIndex = 7;
            // 
            // button_pet_delete
            // 
            button_pet_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_pet_delete.AutoSize = false;
            button_pet_delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_delete.Depth = 0;
            button_pet_delete.HighEmphasis = true;
            button_pet_delete.Icon = Properties.Resources.icons8_delete_480;
            button_pet_delete.Location = new Point(1452, 20);
            button_pet_delete.Margin = new Padding(4, 6, 4, 6);
            button_pet_delete.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_delete.Name = "button_pet_delete";
            button_pet_delete.NoAccentTextColor = Color.Empty;
            button_pet_delete.Size = new Size(112, 45);
            button_pet_delete.TabIndex = 10;
            button_pet_delete.Text = "Delete";
            button_pet_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_delete.UseAccentColor = false;
            button_pet_delete.UseVisualStyleBackColor = true;
            // 
            // button_pet_edit
            // 
            button_pet_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_pet_edit.AutoSize = false;
            button_pet_edit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_edit.Depth = 0;
            button_pet_edit.HighEmphasis = true;
            button_pet_edit.Icon = Properties.Resources.icons8_edit_512;
            button_pet_edit.Location = new Point(1332, 20);
            button_pet_edit.Margin = new Padding(4, 6, 4, 6);
            button_pet_edit.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_edit.Name = "button_pet_edit";
            button_pet_edit.NoAccentTextColor = Color.Empty;
            button_pet_edit.Size = new Size(112, 45);
            button_pet_edit.TabIndex = 9;
            button_pet_edit.Text = "Edit";
            button_pet_edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_edit.UseAccentColor = false;
            button_pet_edit.UseVisualStyleBackColor = true;
            // 
            // button_pet_add_new
            // 
            button_pet_add_new.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_pet_add_new.AutoSize = false;
            button_pet_add_new.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_add_new.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_add_new.Depth = 0;
            button_pet_add_new.HighEmphasis = true;
            button_pet_add_new.Icon = Properties.Resources.icons8_cat_face_96;
            button_pet_add_new.Location = new Point(1212, 20);
            button_pet_add_new.Margin = new Padding(4, 6, 4, 6);
            button_pet_add_new.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_add_new.Name = "button_pet_add_new";
            button_pet_add_new.NoAccentTextColor = Color.Empty;
            button_pet_add_new.Size = new Size(112, 45);
            button_pet_add_new.TabIndex = 8;
            button_pet_add_new.Text = "Add";
            button_pet_add_new.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_add_new.UseAccentColor = false;
            button_pet_add_new.UseVisualStyleBackColor = true;
            // 
            // button_pet_search
            // 
            button_pet_search.AutoSize = false;
            button_pet_search.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_search.Cursor = Cursors.Help;
            button_pet_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_search.Depth = 0;
            button_pet_search.HighEmphasis = true;
            button_pet_search.Icon = null;
            button_pet_search.Location = new Point(503, 20);
            button_pet_search.Margin = new Padding(4, 6, 4, 6);
            button_pet_search.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_search.Name = "button_pet_search";
            button_pet_search.NoAccentTextColor = Color.Empty;
            button_pet_search.Size = new Size(140, 45);
            button_pet_search.TabIndex = 1;
            button_pet_search.Text = "Search";
            button_pet_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_search.UseAccentColor = true;
            button_pet_search.UseVisualStyleBackColor = true;
            // 
            // textBox_pet_search
            // 
            textBox_pet_search.AnimateReadOnly = false;
            textBox_pet_search.BackgroundImageLayout = ImageLayout.None;
            textBox_pet_search.CharacterCasing = CharacterCasing.Normal;
            textBox_pet_search.Depth = 0;
            textBox_pet_search.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_pet_search.HideSelection = true;
            textBox_pet_search.LeadingIcon = Properties.Resources.Default_Pet_Image;
            textBox_pet_search.Location = new Point(17, 17);
            textBox_pet_search.MaxLength = 32767;
            textBox_pet_search.MouseState = MaterialSkin.MouseState.OUT;
            textBox_pet_search.Name = "textBox_pet_search";
            textBox_pet_search.PasswordChar = '\0';
            textBox_pet_search.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_pet_search.PrefixSuffixText = "Search";
            textBox_pet_search.ReadOnly = false;
            textBox_pet_search.RightToLeft = RightToLeft.No;
            textBox_pet_search.SelectedText = "";
            textBox_pet_search.SelectionLength = 0;
            textBox_pet_search.SelectionStart = 0;
            textBox_pet_search.ShortcutsEnabled = true;
            textBox_pet_search.Size = new Size(464, 48);
            textBox_pet_search.TabIndex = 0;
            textBox_pet_search.TabStop = false;
            textBox_pet_search.TextAlign = HorizontalAlignment.Left;
            textBox_pet_search.TrailingIcon = Properties.Resources.icons8_search_500;
            textBox_pet_search.UseSystemPasswordChar = false;
            // 
            // numericUpDown_pet_id
            // 
            numericUpDown_pet_id.AutoSize = true;
            numericUpDown_pet_id.BorderStyle = BorderStyle.None;
            numericUpDown_pet_id.Enabled = false;
            numericUpDown_pet_id.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_pet_id.Location = new Point(379, 261);
            numericUpDown_pet_id.Name = "numericUpDown_pet_id";
            numericUpDown_pet_id.ReadOnly = true;
            numericUpDown_pet_id.Size = new Size(164, 32);
            numericUpDown_pet_id.TabIndex = 24;
            // 
            // numericUpDown_pet_age
            // 
            numericUpDown_pet_age.AutoSize = true;
            numericUpDown_pet_age.BorderStyle = BorderStyle.None;
            numericUpDown_pet_age.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_pet_age.Location = new Point(379, 470);
            numericUpDown_pet_age.Name = "numericUpDown_pet_age";
            numericUpDown_pet_age.Size = new Size(166, 32);
            numericUpDown_pet_age.TabIndex = 23;
            // 
            // dateTimePicker_pet_birthdate
            // 
            dateTimePicker_pet_birthdate.Location = new Point(377, 371);
            dateTimePicker_pet_birthdate.Name = "dateTimePicker_pet_birthdate";
            dateTimePicker_pet_birthdate.Size = new Size(167, 23);
            dateTimePicker_pet_birthdate.TabIndex = 22;
            // 
            // dataGridView_pet_visits
            // 
            dataGridView_pet_visits.AllowUserToAddRows = false;
            dataGridView_pet_visits.AllowUserToDeleteRows = false;
            dataGridView_pet_visits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_pet_visits.Dock = DockStyle.Fill;
            dataGridView_pet_visits.Location = new Point(22, 22);
            dataGridView_pet_visits.MultiSelect = false;
            dataGridView_pet_visits.Name = "dataGridView_pet_visits";
            dataGridView_pet_visits.ReadOnly = true;
            dataGridView_pet_visits.RowTemplate.Height = 25;
            dataGridView_pet_visits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_pet_visits.Size = new Size(732, 816);
            dataGridView_pet_visits.TabIndex = 19;
            // 
            // pictureBox_pet_picture
            // 
            pictureBox_pet_picture.Image = Properties.Resources.Default_Pet_Image;
            pictureBox_pet_picture.Location = new Point(376, 52);
            pictureBox_pet_picture.Name = "pictureBox_pet_picture";
            pictureBox_pet_picture.Size = new Size(167, 163);
            pictureBox_pet_picture.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_pet_picture.TabIndex = 16;
            pictureBox_pet_picture.TabStop = false;
            // 
            // tabControl_pets_form
            // 
            tabControl_pets_form.Controls.Add(tabPage_pet_list);
            tabControl_pets_form.Controls.Add(tabPage_pet_details);
            tabControl_pets_form.Depth = 0;
            tabControl_pets_form.Dock = DockStyle.Fill;
            tabControl_pets_form.Location = new Point(3, 3);
            tabControl_pets_form.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl_pets_form.Multiline = true;
            tabControl_pets_form.Name = "tabControl_pets_form";
            tabControl_pets_form.SelectedIndex = 0;
            tabControl_pets_form.Size = new Size(1594, 894);
            tabControl_pets_form.TabIndex = 9;
            // 
            // tabPage_pet_list
            // 
            tabPage_pet_list.Controls.Add(dataGridView_pets);
            tabPage_pet_list.Controls.Add(materialCard1);
            tabPage_pet_list.Location = new Point(4, 24);
            tabPage_pet_list.Name = "tabPage_pet_list";
            tabPage_pet_list.Padding = new Padding(3);
            tabPage_pet_list.Size = new Size(1586, 866);
            tabPage_pet_list.TabIndex = 0;
            tabPage_pet_list.Text = "Pet List";
            tabPage_pet_list.UseVisualStyleBackColor = true;
            // 
            // tabPage_pet_details
            // 
            tabPage_pet_details.Controls.Add(panel_container_data);
            tabPage_pet_details.Controls.Add(panel_container);
            tabPage_pet_details.Location = new Point(4, 24);
            tabPage_pet_details.Name = "tabPage_pet_details";
            tabPage_pet_details.Padding = new Padding(3);
            tabPage_pet_details.Size = new Size(1586, 866);
            tabPage_pet_details.TabIndex = 1;
            tabPage_pet_details.Text = "Details";
            tabPage_pet_details.UseVisualStyleBackColor = true;
            // 
            // panel_container_data
            // 
            panel_container_data.Controls.Add(dataGridView_pet_visits);
            panel_container_data.Dock = DockStyle.Fill;
            panel_container_data.Location = new Point(807, 3);
            panel_container_data.Margin = new Padding(22);
            panel_container_data.Name = "panel_container_data";
            panel_container_data.Padding = new Padding(22);
            panel_container_data.Size = new Size(776, 860);
            panel_container_data.TabIndex = 34;
            // 
            // panel_container
            // 
            panel_container.Controls.Add(materialCard2);
            panel_container.Dock = DockStyle.Left;
            panel_container.Location = new Point(3, 3);
            panel_container.Margin = new Padding(22);
            panel_container.Name = "panel_container";
            panel_container.Padding = new Padding(22);
            panel_container.Size = new Size(804, 860);
            panel_container.TabIndex = 33;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(panel_buttons_container);
            materialCard2.Controls.Add(materialDivider5);
            materialCard2.Controls.Add(materialLabel4);
            materialCard2.Controls.Add(materialDivider4);
            materialCard2.Controls.Add(materialLabel_pet_id);
            materialCard2.Controls.Add(materialDivider3);
            materialCard2.Controls.Add(materialDivider2);
            materialCard2.Controls.Add(materialDivider1);
            materialCard2.Controls.Add(materialLabel_pet_age);
            materialCard2.Controls.Add(materialLabel_pet_birthday);
            materialCard2.Controls.Add(textBox_pet_sex);
            materialCard2.Controls.Add(textBox_pet_colour);
            materialCard2.Controls.Add(textBox_pet_type);
            materialCard2.Controls.Add(textBox_pet_name);
            materialCard2.Controls.Add(numericUpDown_pet_id);
            materialCard2.Controls.Add(comboBox_pet_owner_id);
            materialCard2.Controls.Add(dateTimePicker_pet_birthdate);
            materialCard2.Controls.Add(pictureBox_pet_picture);
            materialCard2.Controls.Add(numericUpDown_pet_age);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(22, 22);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(760, 816);
            materialCard2.TabIndex = 32;
            // 
            // panel_buttons_container
            // 
            panel_buttons_container.Controls.Add(button_pet_upload_picture);
            panel_buttons_container.Controls.Add(button_pet_save);
            panel_buttons_container.Controls.Add(button_pet_delete_visit);
            panel_buttons_container.Controls.Add(button_pet_edit_owner);
            panel_buttons_container.Controls.Add(button_pet_add_visit);
            panel_buttons_container.Controls.Add(button_pet_cancel);
            panel_buttons_container.Controls.Add(button_pet_add_owner);
            panel_buttons_container.Controls.Add(button_pet_edit_visits);
            panel_buttons_container.Dock = DockStyle.Bottom;
            panel_buttons_container.Location = new Point(14, 670);
            panel_buttons_container.Name = "panel_buttons_container";
            panel_buttons_container.Size = new Size(732, 132);
            panel_buttons_container.TabIndex = 34;
            // 
            // button_pet_upload_picture
            // 
            button_pet_upload_picture.Anchor = AnchorStyles.None;
            button_pet_upload_picture.AutoSize = false;
            button_pet_upload_picture.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_upload_picture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_upload_picture.Depth = 0;
            button_pet_upload_picture.HighEmphasis = true;
            button_pet_upload_picture.Icon = Properties.Resources.icons8_upload_100;
            button_pet_upload_picture.Location = new Point(12, 71);
            button_pet_upload_picture.Margin = new Padding(4, 6, 4, 6);
            button_pet_upload_picture.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_upload_picture.Name = "button_pet_upload_picture";
            button_pet_upload_picture.NoAccentTextColor = Color.Empty;
            button_pet_upload_picture.Size = new Size(219, 36);
            button_pet_upload_picture.TabIndex = 7;
            button_pet_upload_picture.Text = "Upload Picture";
            button_pet_upload_picture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_upload_picture.UseAccentColor = false;
            button_pet_upload_picture.UseVisualStyleBackColor = true;
            // 
            // button_pet_save
            // 
            button_pet_save.Anchor = AnchorStyles.None;
            button_pet_save.AutoSize = false;
            button_pet_save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_save.Depth = 0;
            button_pet_save.HighEmphasis = true;
            button_pet_save.Icon = Properties.Resources.icons8_save_90;
            button_pet_save.Location = new Point(11, 22);
            button_pet_save.Margin = new Padding(4, 6, 4, 6);
            button_pet_save.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_save.Name = "button_pet_save";
            button_pet_save.NoAccentTextColor = Color.Empty;
            button_pet_save.Size = new Size(106, 36);
            button_pet_save.TabIndex = 0;
            button_pet_save.Text = "Save";
            button_pet_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_save.UseAccentColor = true;
            button_pet_save.UseVisualStyleBackColor = true;
            // 
            // button_pet_delete_visit
            // 
            button_pet_delete_visit.Anchor = AnchorStyles.None;
            button_pet_delete_visit.AutoSize = false;
            button_pet_delete_visit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_delete_visit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_delete_visit.Depth = 0;
            button_pet_delete_visit.HighEmphasis = true;
            button_pet_delete_visit.Icon = Properties.Resources.icons8_delete_480;
            button_pet_delete_visit.Location = new Point(579, 23);
            button_pet_delete_visit.Margin = new Padding(4, 6, 4, 6);
            button_pet_delete_visit.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_delete_visit.Name = "button_pet_delete_visit";
            button_pet_delete_visit.NoAccentTextColor = Color.Empty;
            button_pet_delete_visit.Size = new Size(142, 85);
            button_pet_delete_visit.TabIndex = 6;
            button_pet_delete_visit.Text = "Delete Visit";
            button_pet_delete_visit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_delete_visit.UseAccentColor = true;
            button_pet_delete_visit.UseVisualStyleBackColor = true;
            // 
            // button_pet_edit_owner
            // 
            button_pet_edit_owner.Anchor = AnchorStyles.None;
            button_pet_edit_owner.AutoSize = false;
            button_pet_edit_owner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_edit_owner.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_edit_owner.Depth = 0;
            button_pet_edit_owner.HighEmphasis = true;
            button_pet_edit_owner.Icon = Properties.Resources.icons8_edit_512;
            button_pet_edit_owner.Location = new Point(259, 71);
            button_pet_edit_owner.Margin = new Padding(4, 6, 4, 6);
            button_pet_edit_owner.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_edit_owner.Name = "button_pet_edit_owner";
            button_pet_edit_owner.NoAccentTextColor = Color.Empty;
            button_pet_edit_owner.Size = new Size(142, 36);
            button_pet_edit_owner.TabIndex = 1;
            button_pet_edit_owner.Text = "Edit Owner";
            button_pet_edit_owner.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_edit_owner.UseAccentColor = false;
            button_pet_edit_owner.UseVisualStyleBackColor = true;
            // 
            // button_pet_add_visit
            // 
            button_pet_add_visit.Anchor = AnchorStyles.None;
            button_pet_add_visit.AutoSize = false;
            button_pet_add_visit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_add_visit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_add_visit.Depth = 0;
            button_pet_add_visit.HighEmphasis = true;
            button_pet_add_visit.Icon = Properties.Resources.icons8_appointment_64;
            button_pet_add_visit.Location = new Point(429, 23);
            button_pet_add_visit.Margin = new Padding(4, 6, 4, 6);
            button_pet_add_visit.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_add_visit.Name = "button_pet_add_visit";
            button_pet_add_visit.NoAccentTextColor = Color.Empty;
            button_pet_add_visit.Size = new Size(142, 36);
            button_pet_add_visit.TabIndex = 5;
            button_pet_add_visit.Text = "Add Visit";
            button_pet_add_visit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_add_visit.UseAccentColor = true;
            button_pet_add_visit.UseVisualStyleBackColor = true;
            // 
            // button_pet_cancel
            // 
            button_pet_cancel.Anchor = AnchorStyles.None;
            button_pet_cancel.AutoSize = false;
            button_pet_cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_cancel.Depth = 0;
            button_pet_cancel.HighEmphasis = true;
            button_pet_cancel.Icon = null;
            button_pet_cancel.Location = new Point(125, 22);
            button_pet_cancel.Margin = new Padding(4, 6, 4, 6);
            button_pet_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_cancel.Name = "button_pet_cancel";
            button_pet_cancel.NoAccentTextColor = Color.Empty;
            button_pet_cancel.Size = new Size(106, 36);
            button_pet_cancel.TabIndex = 2;
            button_pet_cancel.Text = "Cancel";
            button_pet_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_cancel.UseAccentColor = false;
            button_pet_cancel.UseVisualStyleBackColor = true;
            // 
            // button_pet_add_owner
            // 
            button_pet_add_owner.Anchor = AnchorStyles.None;
            button_pet_add_owner.AutoSize = false;
            button_pet_add_owner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_add_owner.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_add_owner.Depth = 0;
            button_pet_add_owner.HighEmphasis = true;
            button_pet_add_owner.Icon = Properties.Resources.icons8_person_90;
            button_pet_add_owner.Location = new Point(259, 23);
            button_pet_add_owner.Margin = new Padding(4, 6, 4, 6);
            button_pet_add_owner.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_add_owner.Name = "button_pet_add_owner";
            button_pet_add_owner.NoAccentTextColor = Color.Empty;
            button_pet_add_owner.Size = new Size(142, 36);
            button_pet_add_owner.TabIndex = 4;
            button_pet_add_owner.Text = "Add Owner";
            button_pet_add_owner.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_add_owner.UseAccentColor = true;
            button_pet_add_owner.UseVisualStyleBackColor = true;
            // 
            // button_pet_edit_visits
            // 
            button_pet_edit_visits.Anchor = AnchorStyles.None;
            button_pet_edit_visits.AutoSize = false;
            button_pet_edit_visits.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pet_edit_visits.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_pet_edit_visits.Depth = 0;
            button_pet_edit_visits.HighEmphasis = true;
            button_pet_edit_visits.Icon = Properties.Resources.icons8_edit_512;
            button_pet_edit_visits.Location = new Point(429, 72);
            button_pet_edit_visits.Margin = new Padding(4, 6, 4, 6);
            button_pet_edit_visits.MouseState = MaterialSkin.MouseState.HOVER;
            button_pet_edit_visits.Name = "button_pet_edit_visits";
            button_pet_edit_visits.NoAccentTextColor = Color.Empty;
            button_pet_edit_visits.Size = new Size(142, 36);
            button_pet_edit_visits.TabIndex = 3;
            button_pet_edit_visits.Text = "Edit Visit";
            button_pet_edit_visits.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_pet_edit_visits.UseAccentColor = false;
            button_pet_edit_visits.UseVisualStyleBackColor = true;
            // 
            // materialDivider5
            // 
            materialDivider5.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider5.Depth = 0;
            materialDivider5.Location = new Point(17, 416);
            materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider5.Name = "materialDivider5";
            materialDivider5.Size = new Size(166, 3);
            materialDivider5.TabIndex = 31;
            materialDivider5.Text = "materialDivider5";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.Location = new Point(17, 389);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(59, 24);
            materialLabel4.TabIndex = 30;
            materialLabel4.Text = "Owner";
            // 
            // materialDivider4
            // 
            materialDivider4.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider4.Depth = 0;
            materialDivider4.Location = new Point(379, 249);
            materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider4.Name = "materialDivider4";
            materialDivider4.Size = new Size(133, 3);
            materialDivider4.TabIndex = 29;
            materialDivider4.Text = "materialDivider4";
            // 
            // materialLabel_pet_id
            // 
            materialLabel_pet_id.AutoSize = true;
            materialLabel_pet_id.Depth = 0;
            materialLabel_pet_id.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_pet_id.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_pet_id.Location = new Point(378, 222);
            materialLabel_pet_id.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_pet_id.Name = "materialLabel_pet_id";
            materialLabel_pet_id.Size = new Size(56, 24);
            materialLabel_pet_id.TabIndex = 28;
            materialLabel_pet_id.Text = "Pet ID";
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(345, 67);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(3, 450);
            materialDivider3.TabIndex = 27;
            materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(379, 454);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(133, 3);
            materialDivider2.TabIndex = 26;
            materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(377, 356);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(133, 3);
            materialDivider1.TabIndex = 25;
            materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel_pet_age
            // 
            materialLabel_pet_age.AutoSize = true;
            materialLabel_pet_age.Depth = 0;
            materialLabel_pet_age.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_pet_age.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_pet_age.Location = new Point(379, 427);
            materialLabel_pet_age.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_pet_age.Name = "materialLabel_pet_age";
            materialLabel_pet_age.Size = new Size(36, 24);
            materialLabel_pet_age.TabIndex = 24;
            materialLabel_pet_age.Text = "Age";
            // 
            // materialLabel_pet_birthday
            // 
            materialLabel_pet_birthday.AutoSize = true;
            materialLabel_pet_birthday.Depth = 0;
            materialLabel_pet_birthday.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_pet_birthday.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_pet_birthday.Location = new Point(376, 329);
            materialLabel_pet_birthday.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_pet_birthday.Name = "materialLabel_pet_birthday";
            materialLabel_pet_birthday.Size = new Size(76, 24);
            materialLabel_pet_birthday.TabIndex = 23;
            materialLabel_pet_birthday.Text = "Birthday";
            // 
            // textBox_pet_sex
            // 
            textBox_pet_sex.AnimateReadOnly = false;
            textBox_pet_sex.BackgroundImageLayout = ImageLayout.None;
            textBox_pet_sex.CharacterCasing = CharacterCasing.Normal;
            textBox_pet_sex.Depth = 0;
            textBox_pet_sex.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_pet_sex.HelperText = "                      Enter Pet Sex";
            textBox_pet_sex.HideSelection = true;
            textBox_pet_sex.LeadingIcon = Properties.Resources.Default_Pet_Image;
            textBox_pet_sex.Location = new Point(17, 304);
            textBox_pet_sex.MaxLength = 32767;
            textBox_pet_sex.MouseState = MaterialSkin.MouseState.OUT;
            textBox_pet_sex.Name = "textBox_pet_sex";
            textBox_pet_sex.PasswordChar = '\0';
            textBox_pet_sex.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_pet_sex.PrefixSuffixText = "Sex";
            textBox_pet_sex.ReadOnly = false;
            textBox_pet_sex.RightToLeft = RightToLeft.No;
            textBox_pet_sex.SelectedText = "";
            textBox_pet_sex.SelectionLength = 0;
            textBox_pet_sex.SelectionStart = 0;
            textBox_pet_sex.ShortcutsEnabled = true;
            textBox_pet_sex.ShowAssistiveText = true;
            textBox_pet_sex.Size = new Size(303, 64);
            textBox_pet_sex.TabIndex = 13;
            textBox_pet_sex.TabStop = false;
            textBox_pet_sex.TextAlign = HorizontalAlignment.Left;
            textBox_pet_sex.TrailingIcon = null;
            textBox_pet_sex.UseSystemPasswordChar = false;
            // 
            // textBox_pet_colour
            // 
            textBox_pet_colour.AnimateReadOnly = false;
            textBox_pet_colour.BackgroundImageLayout = ImageLayout.None;
            textBox_pet_colour.CharacterCasing = CharacterCasing.Normal;
            textBox_pet_colour.Depth = 0;
            textBox_pet_colour.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_pet_colour.HelperText = "                      Enter Pet Color";
            textBox_pet_colour.HideSelection = true;
            textBox_pet_colour.LeadingIcon = Properties.Resources.Default_Pet_Image;
            textBox_pet_colour.Location = new Point(17, 217);
            textBox_pet_colour.MaxLength = 32767;
            textBox_pet_colour.MouseState = MaterialSkin.MouseState.OUT;
            textBox_pet_colour.Name = "textBox_pet_colour";
            textBox_pet_colour.PasswordChar = '\0';
            textBox_pet_colour.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_pet_colour.PrefixSuffixText = "Color";
            textBox_pet_colour.ReadOnly = false;
            textBox_pet_colour.RightToLeft = RightToLeft.No;
            textBox_pet_colour.SelectedText = "";
            textBox_pet_colour.SelectionLength = 0;
            textBox_pet_colour.SelectionStart = 0;
            textBox_pet_colour.ShortcutsEnabled = true;
            textBox_pet_colour.ShowAssistiveText = true;
            textBox_pet_colour.Size = new Size(303, 64);
            textBox_pet_colour.TabIndex = 12;
            textBox_pet_colour.TabStop = false;
            textBox_pet_colour.TextAlign = HorizontalAlignment.Left;
            textBox_pet_colour.TrailingIcon = null;
            textBox_pet_colour.UseSystemPasswordChar = false;
            // 
            // textBox_pet_type
            // 
            textBox_pet_type.AnimateReadOnly = false;
            textBox_pet_type.BackgroundImageLayout = ImageLayout.None;
            textBox_pet_type.CharacterCasing = CharacterCasing.Normal;
            textBox_pet_type.Depth = 0;
            textBox_pet_type.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_pet_type.HelperText = "                      Enter Pet Type";
            textBox_pet_type.HideSelection = true;
            textBox_pet_type.LeadingIcon = Properties.Resources.Default_Pet_Image;
            textBox_pet_type.Location = new Point(17, 130);
            textBox_pet_type.MaxLength = 32767;
            textBox_pet_type.MouseState = MaterialSkin.MouseState.OUT;
            textBox_pet_type.Name = "textBox_pet_type";
            textBox_pet_type.PasswordChar = '\0';
            textBox_pet_type.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_pet_type.PrefixSuffixText = "Type";
            textBox_pet_type.ReadOnly = false;
            textBox_pet_type.RightToLeft = RightToLeft.No;
            textBox_pet_type.SelectedText = "";
            textBox_pet_type.SelectionLength = 0;
            textBox_pet_type.SelectionStart = 0;
            textBox_pet_type.ShortcutsEnabled = true;
            textBox_pet_type.ShowAssistiveText = true;
            textBox_pet_type.Size = new Size(303, 64);
            textBox_pet_type.TabIndex = 11;
            textBox_pet_type.TabStop = false;
            textBox_pet_type.TextAlign = HorizontalAlignment.Left;
            textBox_pet_type.TrailingIcon = null;
            textBox_pet_type.UseSystemPasswordChar = false;
            // 
            // textBox_pet_name
            // 
            textBox_pet_name.AnimateReadOnly = false;
            textBox_pet_name.BackgroundImageLayout = ImageLayout.None;
            textBox_pet_name.CharacterCasing = CharacterCasing.Normal;
            textBox_pet_name.Depth = 0;
            textBox_pet_name.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_pet_name.HelperText = "                      Enter Pet Name";
            textBox_pet_name.HideSelection = true;
            textBox_pet_name.LeadingIcon = Properties.Resources.Default_Pet_Image;
            textBox_pet_name.Location = new Point(17, 52);
            textBox_pet_name.MaxLength = 32767;
            textBox_pet_name.MouseState = MaterialSkin.MouseState.OUT;
            textBox_pet_name.Name = "textBox_pet_name";
            textBox_pet_name.PasswordChar = '\0';
            textBox_pet_name.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_pet_name.PrefixSuffixText = "Name";
            textBox_pet_name.ReadOnly = false;
            textBox_pet_name.RightToLeft = RightToLeft.No;
            textBox_pet_name.SelectedText = "";
            textBox_pet_name.SelectionLength = 0;
            textBox_pet_name.SelectionStart = 0;
            textBox_pet_name.ShortcutsEnabled = true;
            textBox_pet_name.ShowAssistiveText = true;
            textBox_pet_name.Size = new Size(303, 64);
            textBox_pet_name.TabIndex = 10;
            textBox_pet_name.TabStop = false;
            textBox_pet_name.TextAlign = HorizontalAlignment.Left;
            textBox_pet_name.TrailingIcon = null;
            textBox_pet_name.UseSystemPasswordChar = false;
            // 
            // comboBox_pet_owner_id
            // 
            comboBox_pet_owner_id.AutoResize = false;
            comboBox_pet_owner_id.BackColor = Color.FromArgb(255, 255, 255);
            comboBox_pet_owner_id.Depth = 0;
            comboBox_pet_owner_id.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_pet_owner_id.DropDownHeight = 174;
            comboBox_pet_owner_id.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_pet_owner_id.DropDownWidth = 121;
            comboBox_pet_owner_id.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBox_pet_owner_id.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBox_pet_owner_id.FormattingEnabled = true;
            comboBox_pet_owner_id.IntegralHeight = false;
            comboBox_pet_owner_id.ItemHeight = 43;
            comboBox_pet_owner_id.Location = new Point(16, 431);
            comboBox_pet_owner_id.MaxDropDownItems = 4;
            comboBox_pet_owner_id.MouseState = MaterialSkin.MouseState.OUT;
            comboBox_pet_owner_id.Name = "comboBox_pet_owner_id";
            comboBox_pet_owner_id.Size = new Size(303, 49);
            comboBox_pet_owner_id.StartIndex = 0;
            comboBox_pet_owner_id.TabIndex = 9;
            // 
            // Pet_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl_pets_form);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Pet_Form";
            Padding = new Padding(3);
            Sizable = false;
            Text = "Pet_From";
            ((System.ComponentModel.ISupportInitialize)dataGridView_pets).EndInit();
            materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_pet_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_pet_visits).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_pet_picture).EndInit();
            tabControl_pets_form.ResumeLayout(false);
            tabPage_pet_list.ResumeLayout(false);
            tabPage_pet_details.ResumeLayout(false);
            panel_container_data.ResumeLayout(false);
            panel_container.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            panel_buttons_container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView_pets;
        private PictureBox pictureBox_pet_picture;
        private DataGridView dataGridView_pet_visits;
        private DateTimePicker dateTimePicker_pet_birthdate;
        private NumericUpDown numericUpDown_pet_age;
        private NumericUpDown numericUpDown_pet_id;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_pet_search;
        private MaterialSkin.Controls.MaterialButton button_pet_search;
        private MaterialSkin.Controls.MaterialButton button_pet_delete;
        private MaterialSkin.Controls.MaterialButton button_pet_edit;
        private MaterialSkin.Controls.MaterialButton button_pet_add_new;
        private MaterialSkin.Controls.MaterialTabControl tabControl_pets_form;
        private TabPage tabPage_pet_list;
        private TabPage tabPage_pet_details;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialComboBox comboBox_pet_owner_id;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_pet_name;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_pet_sex;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_pet_colour;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_pet_type;
        private MaterialSkin.Controls.MaterialLabel materialLabel_pet_age;
        private MaterialSkin.Controls.MaterialLabel materialLabel_pet_birthday;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialLabel materialLabel_pet_id;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton button_pet_save;
        private MaterialSkin.Controls.MaterialButton button_pet_edit_visits;
        private MaterialSkin.Controls.MaterialButton button_pet_cancel;
        private MaterialSkin.Controls.MaterialButton button_pet_edit_owner;
        private MaterialSkin.Controls.MaterialButton button_pet_upload_picture;
        private MaterialSkin.Controls.MaterialButton button_pet_delete_visit;
        private MaterialSkin.Controls.MaterialButton button_pet_add_visit;
        private MaterialSkin.Controls.MaterialButton button_pet_add_owner;
        private Panel panel_buttons_container;
        private Panel panel_container;
        private Panel panel_container_data;
    }
}