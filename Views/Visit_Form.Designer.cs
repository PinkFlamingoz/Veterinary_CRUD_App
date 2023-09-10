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
            tabControl_visits_form = new MaterialSkin.Controls.MaterialTabControl();
            tabPage_visit_list = new TabPage();
            dataGridView_visits_pets = new DataGridView();
            panel_conatiner_main_buttons = new Panel();
            button_visit_delete = new MaterialSkin.Controls.MaterialButton();
            button_visit_edit = new MaterialSkin.Controls.MaterialButton();
            textBox_visit_search = new MaterialSkin.Controls.MaterialTextBox2();
            button_visit_add_new_visit = new MaterialSkin.Controls.MaterialButton();
            button_visit_search = new MaterialSkin.Controls.MaterialButton();
            tabPage_visit_details = new TabPage();
            panel_container = new Panel();
            materialTextBox21_visit_id_mask = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel_visit_date_datetime_mask = new MaterialSkin.Controls.MaterialLabel();
            materialLabel_visits_pet = new MaterialSkin.Controls.MaterialLabel();
            materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            numericUpDown_visit_id = new NumericUpDown();
            textBox_visit_description = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel_visit_date = new MaterialSkin.Controls.MaterialLabel();
            comboBox_visit_pet_id = new MaterialSkin.Controls.MaterialComboBox();
            dateTimePicker_visit_date = new DateTimePicker();
            panel_buttons_container = new Panel();
            button_visit_save = new MaterialSkin.Controls.MaterialButton();
            button_visit_edit_pet = new MaterialSkin.Controls.MaterialButton();
            button_visit_cancel = new MaterialSkin.Controls.MaterialButton();
            textBox_visit_type = new MaterialSkin.Controls.MaterialTextBox2();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            tabControl_visits_form.SuspendLayout();
            tabPage_visit_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_visits_pets).BeginInit();
            panel_conatiner_main_buttons.SuspendLayout();
            tabPage_visit_details.SuspendLayout();
            panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_visit_id).BeginInit();
            panel_buttons_container.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_visits_form
            // 
            tabControl_visits_form.Controls.Add(tabPage_visit_list);
            tabControl_visits_form.Controls.Add(tabPage_visit_details);
            tabControl_visits_form.Depth = 0;
            tabControl_visits_form.Dock = DockStyle.Fill;
            tabControl_visits_form.Location = new Point(3, 3);
            tabControl_visits_form.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl_visits_form.Multiline = true;
            tabControl_visits_form.Name = "tabControl_visits_form";
            tabControl_visits_form.SelectedIndex = 0;
            tabControl_visits_form.Size = new Size(1594, 894);
            tabControl_visits_form.TabIndex = 19;
            // 
            // tabPage_visit_list
            // 
            tabPage_visit_list.Controls.Add(dataGridView_visits_pets);
            tabPage_visit_list.Controls.Add(panel_conatiner_main_buttons);
            tabPage_visit_list.Location = new Point(4, 24);
            tabPage_visit_list.Name = "tabPage_visit_list";
            tabPage_visit_list.Padding = new Padding(3);
            tabPage_visit_list.Size = new Size(1586, 866);
            tabPage_visit_list.TabIndex = 0;
            tabPage_visit_list.Text = "Visits";
            tabPage_visit_list.UseVisualStyleBackColor = true;
            // 
            // dataGridView_visits_pets
            // 
            dataGridView_visits_pets.AllowUserToAddRows = false;
            dataGridView_visits_pets.AllowUserToDeleteRows = false;
            dataGridView_visits_pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_visits_pets.Dock = DockStyle.Fill;
            dataGridView_visits_pets.Location = new Point(3, 103);
            dataGridView_visits_pets.MultiSelect = false;
            dataGridView_visits_pets.Name = "dataGridView_visits_pets";
            dataGridView_visits_pets.ReadOnly = true;
            dataGridView_visits_pets.RowTemplate.Height = 25;
            dataGridView_visits_pets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_visits_pets.Size = new Size(1580, 760);
            dataGridView_visits_pets.TabIndex = 6;
            // 
            // panel_conatiner_main_buttons
            // 
            panel_conatiner_main_buttons.Controls.Add(button_visit_delete);
            panel_conatiner_main_buttons.Controls.Add(button_visit_edit);
            panel_conatiner_main_buttons.Controls.Add(textBox_visit_search);
            panel_conatiner_main_buttons.Controls.Add(button_visit_add_new_visit);
            panel_conatiner_main_buttons.Controls.Add(button_visit_search);
            panel_conatiner_main_buttons.Dock = DockStyle.Top;
            panel_conatiner_main_buttons.Location = new Point(3, 3);
            panel_conatiner_main_buttons.Name = "panel_conatiner_main_buttons";
            panel_conatiner_main_buttons.Size = new Size(1580, 100);
            panel_conatiner_main_buttons.TabIndex = 17;
            // 
            // button_visit_delete
            // 
            button_visit_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_visit_delete.AutoSize = false;
            button_visit_delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_delete.Depth = 0;
            button_visit_delete.HighEmphasis = true;
            button_visit_delete.Icon = Properties.Resources.icons8_delete_480;
            button_visit_delete.Location = new Point(1451, 22);
            button_visit_delete.Margin = new Padding(4, 6, 4, 6);
            button_visit_delete.MouseState = MaterialSkin.MouseState.HOVER;
            button_visit_delete.Name = "button_visit_delete";
            button_visit_delete.NoAccentTextColor = Color.Empty;
            button_visit_delete.Size = new Size(112, 45);
            button_visit_delete.TabIndex = 16;
            button_visit_delete.Text = "Delete";
            button_visit_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_visit_delete.UseAccentColor = false;
            button_visit_delete.UseVisualStyleBackColor = true;
            // 
            // button_visit_edit
            // 
            button_visit_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_visit_edit.AutoSize = false;
            button_visit_edit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_edit.Depth = 0;
            button_visit_edit.HighEmphasis = true;
            button_visit_edit.Icon = Properties.Resources.icons8_edit_512;
            button_visit_edit.Location = new Point(1331, 22);
            button_visit_edit.Margin = new Padding(4, 6, 4, 6);
            button_visit_edit.MouseState = MaterialSkin.MouseState.HOVER;
            button_visit_edit.Name = "button_visit_edit";
            button_visit_edit.NoAccentTextColor = Color.Empty;
            button_visit_edit.Size = new Size(112, 45);
            button_visit_edit.TabIndex = 15;
            button_visit_edit.Text = "Edit";
            button_visit_edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_visit_edit.UseAccentColor = false;
            button_visit_edit.UseVisualStyleBackColor = true;
            // 
            // textBox_visit_search
            // 
            textBox_visit_search.AnimateReadOnly = false;
            textBox_visit_search.BackgroundImageLayout = ImageLayout.None;
            textBox_visit_search.CharacterCasing = CharacterCasing.Normal;
            textBox_visit_search.Depth = 0;
            textBox_visit_search.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_visit_search.HideSelection = true;
            textBox_visit_search.LeadingIcon = Properties.Resources.icons8_appointment_64;
            textBox_visit_search.Location = new Point(32, 19);
            textBox_visit_search.MaxLength = 32767;
            textBox_visit_search.MouseState = MaterialSkin.MouseState.OUT;
            textBox_visit_search.Name = "textBox_visit_search";
            textBox_visit_search.PasswordChar = '\0';
            textBox_visit_search.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_visit_search.PrefixSuffixText = "Search";
            textBox_visit_search.ReadOnly = false;
            textBox_visit_search.RightToLeft = RightToLeft.No;
            textBox_visit_search.SelectedText = "";
            textBox_visit_search.SelectionLength = 0;
            textBox_visit_search.SelectionStart = 0;
            textBox_visit_search.ShortcutsEnabled = true;
            textBox_visit_search.Size = new Size(464, 48);
            textBox_visit_search.TabIndex = 0;
            textBox_visit_search.TabStop = false;
            textBox_visit_search.TextAlign = HorizontalAlignment.Left;
            textBox_visit_search.TrailingIcon = Properties.Resources.icons8_search_500;
            textBox_visit_search.UseSystemPasswordChar = false;
            // 
            // button_visit_add_new_visit
            // 
            button_visit_add_new_visit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_visit_add_new_visit.AutoSize = false;
            button_visit_add_new_visit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_add_new_visit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_add_new_visit.Depth = 0;
            button_visit_add_new_visit.HighEmphasis = true;
            button_visit_add_new_visit.Icon = Properties.Resources.icons8_appointment_64;
            button_visit_add_new_visit.Location = new Point(1211, 22);
            button_visit_add_new_visit.Margin = new Padding(4, 6, 4, 6);
            button_visit_add_new_visit.MouseState = MaterialSkin.MouseState.HOVER;
            button_visit_add_new_visit.Name = "button_visit_add_new_visit";
            button_visit_add_new_visit.NoAccentTextColor = Color.Empty;
            button_visit_add_new_visit.Size = new Size(112, 45);
            button_visit_add_new_visit.TabIndex = 14;
            button_visit_add_new_visit.Text = "Add";
            button_visit_add_new_visit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_visit_add_new_visit.UseAccentColor = false;
            button_visit_add_new_visit.UseVisualStyleBackColor = true;
            // 
            // button_visit_search
            // 
            button_visit_search.AutoSize = false;
            button_visit_search.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_search.Cursor = Cursors.Help;
            button_visit_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_search.Depth = 0;
            button_visit_search.HighEmphasis = true;
            button_visit_search.Icon = null;
            button_visit_search.Location = new Point(518, 22);
            button_visit_search.Margin = new Padding(4, 6, 4, 6);
            button_visit_search.MouseState = MaterialSkin.MouseState.HOVER;
            button_visit_search.Name = "button_visit_search";
            button_visit_search.NoAccentTextColor = Color.Empty;
            button_visit_search.Size = new Size(140, 45);
            button_visit_search.TabIndex = 1;
            button_visit_search.Text = "Search";
            button_visit_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_visit_search.UseAccentColor = true;
            button_visit_search.UseVisualStyleBackColor = true;
            // 
            // tabPage_visit_details
            // 
            tabPage_visit_details.Controls.Add(panel_container);
            tabPage_visit_details.Location = new Point(4, 24);
            tabPage_visit_details.Name = "tabPage_visit_details";
            tabPage_visit_details.Padding = new Padding(3);
            tabPage_visit_details.Size = new Size(1586, 866);
            tabPage_visit_details.TabIndex = 1;
            tabPage_visit_details.Text = "Details";
            tabPage_visit_details.UseVisualStyleBackColor = true;
            // 
            // panel_container
            // 
            panel_container.Controls.Add(materialTextBox21_visit_id_mask);
            panel_container.Controls.Add(materialLabel_visit_date_datetime_mask);
            panel_container.Controls.Add(materialLabel_visits_pet);
            panel_container.Controls.Add(materialDivider5);
            panel_container.Controls.Add(numericUpDown_visit_id);
            panel_container.Controls.Add(textBox_visit_description);
            panel_container.Controls.Add(materialLabel_visit_date);
            panel_container.Controls.Add(comboBox_visit_pet_id);
            panel_container.Controls.Add(dateTimePicker_visit_date);
            panel_container.Controls.Add(panel_buttons_container);
            panel_container.Controls.Add(textBox_visit_type);
            panel_container.Controls.Add(materialDivider1);
            panel_container.Dock = DockStyle.Fill;
            panel_container.Location = new Point(3, 3);
            panel_container.Margin = new Padding(22);
            panel_container.Name = "panel_container";
            panel_container.Padding = new Padding(22);
            panel_container.Size = new Size(1580, 860);
            panel_container.TabIndex = 33;
            // 
            // materialTextBox21_visit_id_mask
            // 
            materialTextBox21_visit_id_mask.Anchor = AnchorStyles.None;
            materialTextBox21_visit_id_mask.AnimateReadOnly = true;
            materialTextBox21_visit_id_mask.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21_visit_id_mask.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21_visit_id_mask.Depth = 0;
            materialTextBox21_visit_id_mask.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21_visit_id_mask.HideSelection = true;
            materialTextBox21_visit_id_mask.LeadingIcon = Properties.Resources.icons8_appointment_64;
            materialTextBox21_visit_id_mask.Location = new Point(642, 48);
            materialTextBox21_visit_id_mask.MaxLength = 32767;
            materialTextBox21_visit_id_mask.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21_visit_id_mask.Name = "materialTextBox21_visit_id_mask";
            materialTextBox21_visit_id_mask.PasswordChar = '\0';
            materialTextBox21_visit_id_mask.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            materialTextBox21_visit_id_mask.PrefixSuffixText = "Visit ID";
            materialTextBox21_visit_id_mask.ReadOnly = true;
            materialTextBox21_visit_id_mask.RightToLeft = RightToLeft.No;
            materialTextBox21_visit_id_mask.SelectedText = "";
            materialTextBox21_visit_id_mask.SelectionLength = 0;
            materialTextBox21_visit_id_mask.SelectionStart = 0;
            materialTextBox21_visit_id_mask.ShortcutsEnabled = true;
            materialTextBox21_visit_id_mask.Size = new Size(169, 48);
            materialTextBox21_visit_id_mask.TabIndex = 44;
            materialTextBox21_visit_id_mask.TabStop = false;
            materialTextBox21_visit_id_mask.TextAlign = HorizontalAlignment.Left;
            materialTextBox21_visit_id_mask.TrailingIcon = null;
            materialTextBox21_visit_id_mask.UseSystemPasswordChar = false;
            // 
            // materialLabel_visit_date_datetime_mask
            // 
            materialLabel_visit_date_datetime_mask.Anchor = AnchorStyles.None;
            materialLabel_visit_date_datetime_mask.Cursor = Cursors.Hand;
            materialLabel_visit_date_datetime_mask.Depth = 0;
            materialLabel_visit_date_datetime_mask.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel_visit_date_datetime_mask.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel_visit_date_datetime_mask.HighEmphasis = true;
            materialLabel_visit_date_datetime_mask.Location = new Point(393, 90);
            materialLabel_visit_date_datetime_mask.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_visit_date_datetime_mask.Name = "materialLabel_visit_date_datetime_mask";
            materialLabel_visit_date_datetime_mask.Size = new Size(206, 30);
            materialLabel_visit_date_datetime_mask.TabIndex = 43;
            materialLabel_visit_date_datetime_mask.Text = "Jan 01, 2023";
            materialLabel_visit_date_datetime_mask.UseAccent = true;
            // 
            // materialLabel_visits_pet
            // 
            materialLabel_visits_pet.Anchor = AnchorStyles.None;
            materialLabel_visits_pet.AutoSize = true;
            materialLabel_visits_pet.Depth = 0;
            materialLabel_visits_pet.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_visits_pet.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_visits_pet.Location = new Point(48, 48);
            materialLabel_visits_pet.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_visits_pet.Name = "materialLabel_visits_pet";
            materialLabel_visits_pet.Size = new Size(32, 24);
            materialLabel_visits_pet.TabIndex = 42;
            materialLabel_visits_pet.Text = "Pet";
            // 
            // materialDivider5
            // 
            materialDivider5.Anchor = AnchorStyles.None;
            materialDivider5.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider5.Depth = 0;
            materialDivider5.Location = new Point(47, 75);
            materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider5.Name = "materialDivider5";
            materialDivider5.Size = new Size(166, 3);
            materialDivider5.TabIndex = 31;
            materialDivider5.Text = "materialDivider5";
            // 
            // numericUpDown_visit_id
            // 
            numericUpDown_visit_id.Anchor = AnchorStyles.None;
            numericUpDown_visit_id.AutoSize = true;
            numericUpDown_visit_id.BorderStyle = BorderStyle.None;
            numericUpDown_visit_id.Enabled = false;
            numericUpDown_visit_id.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_visit_id.Location = new Point(642, 48);
            numericUpDown_visit_id.Name = "numericUpDown_visit_id";
            numericUpDown_visit_id.ReadOnly = true;
            numericUpDown_visit_id.Size = new Size(164, 32);
            numericUpDown_visit_id.TabIndex = 38;
            // 
            // textBox_visit_description
            // 
            textBox_visit_description.Anchor = AnchorStyles.None;
            textBox_visit_description.AnimateReadOnly = false;
            textBox_visit_description.BackgroundImageLayout = ImageLayout.None;
            textBox_visit_description.CharacterCasing = CharacterCasing.Normal;
            textBox_visit_description.Depth = 0;
            textBox_visit_description.HideSelection = true;
            textBox_visit_description.Hint = "Enter Visit Description";
            textBox_visit_description.Location = new Point(47, 285);
            textBox_visit_description.MaxLength = 32767;
            textBox_visit_description.MouseState = MaterialSkin.MouseState.OUT;
            textBox_visit_description.Name = "textBox_visit_description";
            textBox_visit_description.PasswordChar = '\0';
            textBox_visit_description.ReadOnly = false;
            textBox_visit_description.ScrollBars = ScrollBars.Both;
            textBox_visit_description.SelectedText = "";
            textBox_visit_description.SelectionLength = 0;
            textBox_visit_description.SelectionStart = 0;
            textBox_visit_description.ShortcutsEnabled = true;
            textBox_visit_description.Size = new Size(1487, 309);
            textBox_visit_description.TabIndex = 35;
            textBox_visit_description.TabStop = false;
            textBox_visit_description.TextAlign = HorizontalAlignment.Left;
            textBox_visit_description.UseSystemPasswordChar = false;
            // 
            // materialLabel_visit_date
            // 
            materialLabel_visit_date.Anchor = AnchorStyles.None;
            materialLabel_visit_date.AutoSize = true;
            materialLabel_visit_date.Depth = 0;
            materialLabel_visit_date.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_visit_date.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_visit_date.Location = new Point(393, 48);
            materialLabel_visit_date.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_visit_date.Name = "materialLabel_visit_date";
            materialLabel_visit_date.Size = new Size(88, 24);
            materialLabel_visit_date.TabIndex = 37;
            materialLabel_visit_date.Text = "Visit Date";
            // 
            // comboBox_visit_pet_id
            // 
            comboBox_visit_pet_id.Anchor = AnchorStyles.None;
            comboBox_visit_pet_id.AutoResize = false;
            comboBox_visit_pet_id.BackColor = Color.FromArgb(255, 255, 255);
            comboBox_visit_pet_id.Depth = 0;
            comboBox_visit_pet_id.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_visit_pet_id.DropDownHeight = 174;
            comboBox_visit_pet_id.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_visit_pet_id.DropDownWidth = 121;
            comboBox_visit_pet_id.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBox_visit_pet_id.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBox_visit_pet_id.FormattingEnabled = true;
            comboBox_visit_pet_id.IntegralHeight = false;
            comboBox_visit_pet_id.ItemHeight = 43;
            comboBox_visit_pet_id.Location = new Point(47, 90);
            comboBox_visit_pet_id.MaxDropDownItems = 4;
            comboBox_visit_pet_id.MouseState = MaterialSkin.MouseState.OUT;
            comboBox_visit_pet_id.Name = "comboBox_visit_pet_id";
            comboBox_visit_pet_id.Size = new Size(246, 49);
            comboBox_visit_pet_id.StartIndex = 0;
            comboBox_visit_pet_id.TabIndex = 9;
            // 
            // dateTimePicker_visit_date
            // 
            dateTimePicker_visit_date.Anchor = AnchorStyles.None;
            dateTimePicker_visit_date.Location = new Point(394, 90);
            dateTimePicker_visit_date.Name = "dateTimePicker_visit_date";
            dateTimePicker_visit_date.Size = new Size(167, 23);
            dateTimePicker_visit_date.TabIndex = 36;
            // 
            // panel_buttons_container
            // 
            panel_buttons_container.Controls.Add(button_visit_save);
            panel_buttons_container.Controls.Add(button_visit_edit_pet);
            panel_buttons_container.Controls.Add(button_visit_cancel);
            panel_buttons_container.Dock = DockStyle.Bottom;
            panel_buttons_container.Location = new Point(22, 706);
            panel_buttons_container.Name = "panel_buttons_container";
            panel_buttons_container.Size = new Size(1536, 132);
            panel_buttons_container.TabIndex = 34;
            // 
            // button_visit_save
            // 
            button_visit_save.Anchor = AnchorStyles.None;
            button_visit_save.AutoSize = false;
            button_visit_save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_save.Depth = 0;
            button_visit_save.HighEmphasis = true;
            button_visit_save.Icon = Properties.Resources.icons8_save_90;
            button_visit_save.Location = new Point(583, 48);
            button_visit_save.Margin = new Padding(4, 6, 4, 6);
            button_visit_save.MouseState = MaterialSkin.MouseState.HOVER;
            button_visit_save.Name = "button_visit_save";
            button_visit_save.NoAccentTextColor = Color.Empty;
            button_visit_save.Size = new Size(106, 36);
            button_visit_save.TabIndex = 3;
            button_visit_save.Text = "Save";
            button_visit_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_visit_save.UseAccentColor = true;
            button_visit_save.UseVisualStyleBackColor = true;
            // 
            // button_visit_edit_pet
            // 
            button_visit_edit_pet.Anchor = AnchorStyles.None;
            button_visit_edit_pet.AutoSize = false;
            button_visit_edit_pet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_edit_pet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_edit_pet.Depth = 0;
            button_visit_edit_pet.HighEmphasis = true;
            button_visit_edit_pet.Icon = Properties.Resources.icons8_edit_512;
            button_visit_edit_pet.Location = new Point(811, 48);
            button_visit_edit_pet.Margin = new Padding(4, 6, 4, 6);
            button_visit_edit_pet.MouseState = MaterialSkin.MouseState.HOVER;
            button_visit_edit_pet.Name = "button_visit_edit_pet";
            button_visit_edit_pet.NoAccentTextColor = Color.Empty;
            button_visit_edit_pet.Size = new Size(142, 36);
            button_visit_edit_pet.TabIndex = 4;
            button_visit_edit_pet.Text = "Edit Pet";
            button_visit_edit_pet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_visit_edit_pet.UseAccentColor = false;
            button_visit_edit_pet.UseVisualStyleBackColor = true;
            // 
            // button_visit_cancel
            // 
            button_visit_cancel.Anchor = AnchorStyles.None;
            button_visit_cancel.AutoSize = false;
            button_visit_cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_cancel.Depth = 0;
            button_visit_cancel.HighEmphasis = true;
            button_visit_cancel.Icon = null;
            button_visit_cancel.Location = new Point(697, 48);
            button_visit_cancel.Margin = new Padding(4, 6, 4, 6);
            button_visit_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            button_visit_cancel.Name = "button_visit_cancel";
            button_visit_cancel.NoAccentTextColor = Color.Empty;
            button_visit_cancel.Size = new Size(106, 36);
            button_visit_cancel.TabIndex = 5;
            button_visit_cancel.Text = "Cancel";
            button_visit_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_visit_cancel.UseAccentColor = false;
            button_visit_cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_visit_type
            // 
            textBox_visit_type.Anchor = AnchorStyles.None;
            textBox_visit_type.AnimateReadOnly = false;
            textBox_visit_type.BackgroundImageLayout = ImageLayout.None;
            textBox_visit_type.CharacterCasing = CharacterCasing.Normal;
            textBox_visit_type.Depth = 0;
            textBox_visit_type.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_visit_type.HelperText = "                      Enter The Type Of Visit";
            textBox_visit_type.HideSelection = true;
            textBox_visit_type.LeadingIcon = Properties.Resources.icons8_appointment_64;
            textBox_visit_type.Location = new Point(47, 179);
            textBox_visit_type.MaxLength = 32767;
            textBox_visit_type.MouseState = MaterialSkin.MouseState.OUT;
            textBox_visit_type.Name = "textBox_visit_type";
            textBox_visit_type.PasswordChar = '\0';
            textBox_visit_type.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_visit_type.PrefixSuffixText = "Type";
            textBox_visit_type.ReadOnly = false;
            textBox_visit_type.RightToLeft = RightToLeft.No;
            textBox_visit_type.SelectedText = "";
            textBox_visit_type.SelectionLength = 0;
            textBox_visit_type.SelectionStart = 0;
            textBox_visit_type.ShortcutsEnabled = true;
            textBox_visit_type.ShowAssistiveText = true;
            textBox_visit_type.Size = new Size(764, 64);
            textBox_visit_type.TabIndex = 10;
            textBox_visit_type.TabStop = false;
            textBox_visit_type.TextAlign = HorizontalAlignment.Left;
            textBox_visit_type.TrailingIcon = null;
            textBox_visit_type.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.None;
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(393, 75);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(133, 3);
            materialDivider1.TabIndex = 39;
            materialDivider1.Text = "materialDivider1";
            // 
            // Visit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl_visits_form);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Visit_Form";
            Padding = new Padding(3);
            Sizable = false;
            Text = "Visit_Form";
            tabControl_visits_form.ResumeLayout(false);
            tabPage_visit_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_visits_pets).EndInit();
            panel_conatiner_main_buttons.ResumeLayout(false);
            tabPage_visit_details.ResumeLayout(false);
            panel_container.ResumeLayout(false);
            panel_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_visit_id).EndInit();
            panel_buttons_container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl_visits_form;
        private TabPage tabPage_visit_list;
        private DataGridView dataGridView_visits_pets;
        private MaterialSkin.Controls.MaterialButton button_visit_search;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_visit_search;
        private TabPage tabPage_visit_details;
        private Panel panel_container;
        private Panel panel_buttons_container;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialComboBox comboBox_visit_pet_id;
        private MaterialSkin.Controls.MaterialButton button_visit_delete;
        private MaterialSkin.Controls.MaterialButton button_visit_edit;
        private MaterialSkin.Controls.MaterialButton button_visit_add_new_visit;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_visit_type;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton button_visit_save;
        private MaterialSkin.Controls.MaterialButton button_visit_edit_pet;
        private MaterialSkin.Controls.MaterialButton button_visit_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel_visit_date;
        private NumericUpDown numericUpDown_visit_id;
        private DateTimePicker dateTimePicker_visit_date;
        private MaterialSkin.Controls.MaterialLabel materialLabel_visits_pet;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textBox_visit_description;
        private Panel panel_conatiner_main_buttons;
        private MaterialSkin.Controls.MaterialLabel materialLabel_visit_date_datetime_mask;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21_visit_id_mask;
    }
}