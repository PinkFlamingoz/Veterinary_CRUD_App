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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            button_visit_delete = new MaterialSkin.Controls.MaterialButton();
            button_visit_edit = new MaterialSkin.Controls.MaterialButton();
            button_visit_add_new_visit = new MaterialSkin.Controls.MaterialButton();
            button_visit_search = new MaterialSkin.Controls.MaterialButton();
            textBox_visit_search = new MaterialSkin.Controls.MaterialTextBox2();
            tabPage_visit_details = new TabPage();
            panel_container = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            materialLabel_visit_id = new MaterialSkin.Controls.MaterialLabel();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            panel_buttons_container = new Panel();
            button_visit_save = new MaterialSkin.Controls.MaterialButton();
            button_visit_edit_pet = new MaterialSkin.Controls.MaterialButton();
            button_visit_cancel = new MaterialSkin.Controls.MaterialButton();
            materialLabel_visit_date = new MaterialSkin.Controls.MaterialLabel();
            materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            numericUpDown_visit_id = new NumericUpDown();
            dateTimePicker_visit_date = new DateTimePicker();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            textBox_visit_type = new MaterialSkin.Controls.MaterialTextBox2();
            comboBox_visit_pet_id = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel_visits_pet = new MaterialSkin.Controls.MaterialLabel();
            textBox_visit_description = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            tabControl_visits_form.SuspendLayout();
            tabPage_visit_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_visits_pets).BeginInit();
            materialCard1.SuspendLayout();
            tabPage_visit_details.SuspendLayout();
            panel_container.SuspendLayout();
            materialCard2.SuspendLayout();
            panel_buttons_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_visit_id).BeginInit();
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
            tabControl_visits_form.Size = new Size(1330, 762);
            tabControl_visits_form.TabIndex = 19;
            // 
            // tabPage_visit_list
            // 
            tabPage_visit_list.Controls.Add(dataGridView_visits_pets);
            tabPage_visit_list.Controls.Add(materialCard1);
            tabPage_visit_list.Location = new Point(4, 24);
            tabPage_visit_list.Name = "tabPage_visit_list";
            tabPage_visit_list.Padding = new Padding(3);
            tabPage_visit_list.Size = new Size(1322, 734);
            tabPage_visit_list.TabIndex = 0;
            tabPage_visit_list.Text = "Visits";
            tabPage_visit_list.UseVisualStyleBackColor = true;
            // 
            // dataGridView_visits_pets
            // 
            dataGridView_visits_pets.AllowUserToAddRows = false;
            dataGridView_visits_pets.AllowUserToDeleteRows = false;
            dataGridView_visits_pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_visits_pets.Dock = DockStyle.Bottom;
            dataGridView_visits_pets.Location = new Point(3, 289);
            dataGridView_visits_pets.MultiSelect = false;
            dataGridView_visits_pets.Name = "dataGridView_visits_pets";
            dataGridView_visits_pets.ReadOnly = true;
            dataGridView_visits_pets.RowTemplate.Height = 25;
            dataGridView_visits_pets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_visits_pets.Size = new Size(1316, 442);
            dataGridView_visits_pets.TabIndex = 6;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(button_visit_delete);
            materialCard1.Controls.Add(button_visit_edit);
            materialCard1.Controls.Add(button_visit_add_new_visit);
            materialCard1.Controls.Add(button_visit_search);
            materialCard1.Controls.Add(textBox_visit_search);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 3);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1316, 85);
            materialCard1.TabIndex = 7;
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
            button_visit_delete.Location = new Point(1186, 20);
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
            button_visit_edit.Location = new Point(1066, 20);
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
            // button_visit_add_new_visit
            // 
            button_visit_add_new_visit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_visit_add_new_visit.AutoSize = false;
            button_visit_add_new_visit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_visit_add_new_visit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_visit_add_new_visit.Depth = 0;
            button_visit_add_new_visit.HighEmphasis = true;
            button_visit_add_new_visit.Icon = Properties.Resources.icons8_appointment_64;
            button_visit_add_new_visit.Location = new Point(946, 20);
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
            button_visit_search.Location = new Point(503, 20);
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
            // textBox_visit_search
            // 
            textBox_visit_search.AnimateReadOnly = false;
            textBox_visit_search.BackgroundImageLayout = ImageLayout.None;
            textBox_visit_search.CharacterCasing = CharacterCasing.Normal;
            textBox_visit_search.Depth = 0;
            textBox_visit_search.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_visit_search.HideSelection = true;
            textBox_visit_search.LeadingIcon = Properties.Resources.icons8_appointment_64;
            textBox_visit_search.Location = new Point(17, 17);
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
            // tabPage_visit_details
            // 
            tabPage_visit_details.Controls.Add(panel_container);
            tabPage_visit_details.Location = new Point(4, 24);
            tabPage_visit_details.Name = "tabPage_visit_details";
            tabPage_visit_details.Padding = new Padding(3);
            tabPage_visit_details.Size = new Size(1322, 734);
            tabPage_visit_details.TabIndex = 1;
            tabPage_visit_details.Text = "Details";
            tabPage_visit_details.UseVisualStyleBackColor = true;
            // 
            // panel_container
            // 
            panel_container.Controls.Add(materialCard2);
            panel_container.Dock = DockStyle.Left;
            panel_container.Location = new Point(3, 3);
            panel_container.Margin = new Padding(22);
            panel_container.Name = "panel_container";
            panel_container.Padding = new Padding(22);
            panel_container.Size = new Size(804, 728);
            panel_container.TabIndex = 33;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialLabel_visits_pet);
            materialCard2.Controls.Add(materialDivider4);
            materialCard2.Controls.Add(textBox_visit_description);
            materialCard2.Controls.Add(materialLabel_visit_id);
            materialCard2.Controls.Add(materialDivider1);
            materialCard2.Controls.Add(panel_buttons_container);
            materialCard2.Controls.Add(materialLabel_visit_date);
            materialCard2.Controls.Add(materialDivider5);
            materialCard2.Controls.Add(numericUpDown_visit_id);
            materialCard2.Controls.Add(dateTimePicker_visit_date);
            materialCard2.Controls.Add(materialDivider3);
            materialCard2.Controls.Add(textBox_visit_type);
            materialCard2.Controls.Add(comboBox_visit_pet_id);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(22, 22);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(760, 684);
            materialCard2.TabIndex = 32;
            // 
            // materialDivider4
            // 
            materialDivider4.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider4.Depth = 0;
            materialDivider4.Location = new Point(501, 79);
            materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider4.Name = "materialDivider4";
            materialDivider4.Size = new Size(133, 3);
            materialDivider4.TabIndex = 41;
            materialDivider4.Text = "materialDivider4";
            // 
            // materialLabel_visit_id
            // 
            materialLabel_visit_id.AutoSize = true;
            materialLabel_visit_id.Depth = 0;
            materialLabel_visit_id.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_visit_id.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_visit_id.Location = new Point(500, 52);
            materialLabel_visit_id.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_visit_id.Name = "materialLabel_visit_id";
            materialLabel_visit_id.Size = new Size(65, 24);
            materialLabel_visit_id.TabIndex = 40;
            materialLabel_visit_id.Text = "Visit ID";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(499, 186);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(133, 3);
            materialDivider1.TabIndex = 39;
            materialDivider1.Text = "materialDivider1";
            // 
            // panel_buttons_container
            // 
            panel_buttons_container.Controls.Add(button_visit_save);
            panel_buttons_container.Controls.Add(button_visit_edit_pet);
            panel_buttons_container.Controls.Add(button_visit_cancel);
            panel_buttons_container.Dock = DockStyle.Bottom;
            panel_buttons_container.Location = new Point(14, 538);
            panel_buttons_container.Name = "panel_buttons_container";
            panel_buttons_container.Size = new Size(732, 132);
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
            button_visit_save.Location = new Point(181, 48);
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
            button_visit_edit_pet.Location = new Point(409, 48);
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
            button_visit_cancel.Location = new Point(295, 48);
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
            // materialLabel_visit_date
            // 
            materialLabel_visit_date.AutoSize = true;
            materialLabel_visit_date.Depth = 0;
            materialLabel_visit_date.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_visit_date.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_visit_date.Location = new Point(498, 159);
            materialLabel_visit_date.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_visit_date.Name = "materialLabel_visit_date";
            materialLabel_visit_date.Size = new Size(88, 24);
            materialLabel_visit_date.TabIndex = 37;
            materialLabel_visit_date.Text = "Visit Date";
            // 
            // materialDivider5
            // 
            materialDivider5.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider5.Depth = 0;
            materialDivider5.Location = new Point(498, 299);
            materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider5.Name = "materialDivider5";
            materialDivider5.Size = new Size(166, 3);
            materialDivider5.TabIndex = 31;
            materialDivider5.Text = "materialDivider5";
            // 
            // numericUpDown_visit_id
            // 
            numericUpDown_visit_id.AutoSize = true;
            numericUpDown_visit_id.BorderStyle = BorderStyle.None;
            numericUpDown_visit_id.Enabled = false;
            numericUpDown_visit_id.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_visit_id.Location = new Point(501, 91);
            numericUpDown_visit_id.Name = "numericUpDown_visit_id";
            numericUpDown_visit_id.ReadOnly = true;
            numericUpDown_visit_id.Size = new Size(164, 32);
            numericUpDown_visit_id.TabIndex = 38;
            // 
            // dateTimePicker_visit_date
            // 
            dateTimePicker_visit_date.Location = new Point(499, 201);
            dateTimePicker_visit_date.Name = "dateTimePicker_visit_date";
            dateTimePicker_visit_date.Size = new Size(167, 23);
            dateTimePicker_visit_date.TabIndex = 36;
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(467, 67);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(3, 450);
            materialDivider3.TabIndex = 27;
            materialDivider3.Text = "materialDivider3";
            // 
            // textBox_visit_type
            // 
            textBox_visit_type.AnimateReadOnly = false;
            textBox_visit_type.BackgroundImageLayout = ImageLayout.None;
            textBox_visit_type.CharacterCasing = CharacterCasing.Normal;
            textBox_visit_type.Depth = 0;
            textBox_visit_type.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_visit_type.HelperText = "                      Enter The Type Of Visit";
            textBox_visit_type.HideSelection = true;
            textBox_visit_type.LeadingIcon = Properties.Resources.icons8_appointment_64;
            textBox_visit_type.Location = new Point(17, 52);
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
            textBox_visit_type.Size = new Size(422, 64);
            textBox_visit_type.TabIndex = 10;
            textBox_visit_type.TabStop = false;
            textBox_visit_type.TextAlign = HorizontalAlignment.Left;
            textBox_visit_type.TrailingIcon = null;
            textBox_visit_type.UseSystemPasswordChar = false;
            // 
            // comboBox_visit_pet_id
            // 
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
            comboBox_visit_pet_id.Location = new Point(497, 314);
            comboBox_visit_pet_id.MaxDropDownItems = 4;
            comboBox_visit_pet_id.MouseState = MaterialSkin.MouseState.OUT;
            comboBox_visit_pet_id.Name = "comboBox_visit_pet_id";
            comboBox_visit_pet_id.Size = new Size(246, 49);
            comboBox_visit_pet_id.StartIndex = 0;
            comboBox_visit_pet_id.TabIndex = 9;
            // 
            // materialLabel_visits_pet
            // 
            materialLabel_visits_pet.AutoSize = true;
            materialLabel_visits_pet.Depth = 0;
            materialLabel_visits_pet.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_visits_pet.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel_visits_pet.Location = new Point(498, 262);
            materialLabel_visits_pet.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_visits_pet.Name = "materialLabel_visits_pet";
            materialLabel_visits_pet.Size = new Size(32, 24);
            materialLabel_visits_pet.TabIndex = 42;
            materialLabel_visits_pet.Text = "Pet";
            // 
            // textBox_visit_description
            // 
            textBox_visit_description.AnimateReadOnly = false;
            textBox_visit_description.BackgroundImageLayout = ImageLayout.None;
            textBox_visit_description.CharacterCasing = CharacterCasing.Normal;
            textBox_visit_description.Depth = 0;
            textBox_visit_description.HideSelection = true;
            textBox_visit_description.Hint = "Enter Visit Description";
            textBox_visit_description.Location = new Point(17, 124);
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
            textBox_visit_description.Size = new Size(422, 393);
            textBox_visit_description.TabIndex = 35;
            textBox_visit_description.TabStop = false;
            textBox_visit_description.TextAlign = HorizontalAlignment.Left;
            textBox_visit_description.UseSystemPasswordChar = false;
            // 
            // Visit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 768);
            Controls.Add(tabControl_visits_form);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Visit_Form";
            Padding = new Padding(3);
            Sizable = false;
            Text = "Visit_Form";
            tabControl_visits_form.ResumeLayout(false);
            tabPage_visit_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_visits_pets).EndInit();
            materialCard1.ResumeLayout(false);
            tabPage_visit_details.ResumeLayout(false);
            panel_container.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            panel_buttons_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_visit_id).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl_visits_form;
        private TabPage tabPage_visit_list;
        private DataGridView dataGridView_visits_pets;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton button_visit_search;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_visit_search;
        private TabPage tabPage_visit_details;
        private Panel panel_container_data;
        private Panel panel_container;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panel_buttons_container;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialComboBox comboBox_visit_pet_id;
        private MaterialSkin.Controls.MaterialButton button_visit_delete;
        private MaterialSkin.Controls.MaterialButton button_visit_edit;
        private MaterialSkin.Controls.MaterialButton button_visit_add_new_visit;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_visit_type;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialLabel materialLabel_visit_id;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton button_visit_save;
        private MaterialSkin.Controls.MaterialButton button_visit_edit_pet;
        private MaterialSkin.Controls.MaterialButton button_visit_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel_visit_date;
        private NumericUpDown numericUpDown_visit_id;
        private DateTimePicker dateTimePicker_visit_date;
        private MaterialSkin.Controls.MaterialLabel materialLabel_visits_pet;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 textBox_visit_description;
    }
}