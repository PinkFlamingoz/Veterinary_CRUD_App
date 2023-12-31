﻿namespace Veterinary_CRUD_App.Views
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
            tabControl_owner_form = new MaterialSkin.Controls.MaterialTabControl();
            tabPage_owners = new TabPage();
            dataGridView_owners = new DataGridView();
            panel_container_main_buttons = new Panel();
            button_owner_delete = new MaterialSkin.Controls.MaterialButton();
            button_owner_edit = new MaterialSkin.Controls.MaterialButton();
            textBox_owner_search = new MaterialSkin.Controls.MaterialTextBox2();
            button_owner_add_owner = new MaterialSkin.Controls.MaterialButton();
            button_owner_search = new MaterialSkin.Controls.MaterialButton();
            tabPage_owner_details = new TabPage();
            panel_container_data = new Panel();
            dataGridView_owner_pets = new DataGridView();
            panel_container = new Panel();
            materialTextBox21_owner_id_mask = new MaterialSkin.Controls.MaterialTextBox2();
            panel_buttons_container = new Panel();
            button_owner_save = new MaterialSkin.Controls.MaterialButton();
            button_owner_delete_pet = new MaterialSkin.Controls.MaterialButton();
            button_owner_add_new_pet = new MaterialSkin.Controls.MaterialButton();
            button_owner_cancel = new MaterialSkin.Controls.MaterialButton();
            button_owner_edit_pet = new MaterialSkin.Controls.MaterialButton();
            numericUpDown_owner_id = new NumericUpDown();
            textBox_owner_name = new MaterialSkin.Controls.MaterialTextBox2();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            textBox_owner_phone = new MaterialSkin.Controls.MaterialTextBox2();
            textBox_owner_email = new MaterialSkin.Controls.MaterialTextBox2();
            tabControl_owner_form.SuspendLayout();
            tabPage_owners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_owners).BeginInit();
            panel_container_main_buttons.SuspendLayout();
            tabPage_owner_details.SuspendLayout();
            panel_container_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_owner_pets).BeginInit();
            panel_container.SuspendLayout();
            panel_buttons_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_owner_id).BeginInit();
            SuspendLayout();
            // 
            // tabControl_owner_form
            // 
            tabControl_owner_form.Controls.Add(tabPage_owners);
            tabControl_owner_form.Controls.Add(tabPage_owner_details);
            tabControl_owner_form.Depth = 0;
            tabControl_owner_form.Dock = DockStyle.Fill;
            tabControl_owner_form.Location = new Point(3, 3);
            tabControl_owner_form.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl_owner_form.Multiline = true;
            tabControl_owner_form.Name = "tabControl_owner_form";
            tabControl_owner_form.SelectedIndex = 0;
            tabControl_owner_form.Size = new Size(1594, 894);
            tabControl_owner_form.TabIndex = 19;
            // 
            // tabPage_owners
            // 
            tabPage_owners.Controls.Add(dataGridView_owners);
            tabPage_owners.Controls.Add(panel_container_main_buttons);
            tabPage_owners.Location = new Point(4, 24);
            tabPage_owners.Name = "tabPage_owners";
            tabPage_owners.Padding = new Padding(3);
            tabPage_owners.Size = new Size(1586, 866);
            tabPage_owners.TabIndex = 0;
            tabPage_owners.Text = "Owners";
            tabPage_owners.UseVisualStyleBackColor = true;
            // 
            // dataGridView_owners
            // 
            dataGridView_owners.AllowUserToAddRows = false;
            dataGridView_owners.AllowUserToDeleteRows = false;
            dataGridView_owners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_owners.Dock = DockStyle.Fill;
            dataGridView_owners.Location = new Point(3, 103);
            dataGridView_owners.MultiSelect = false;
            dataGridView_owners.Name = "dataGridView_owners";
            dataGridView_owners.ReadOnly = true;
            dataGridView_owners.RowTemplate.Height = 25;
            dataGridView_owners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_owners.Size = new Size(1580, 760);
            dataGridView_owners.TabIndex = 8;
            // 
            // panel_container_main_buttons
            // 
            panel_container_main_buttons.Controls.Add(button_owner_delete);
            panel_container_main_buttons.Controls.Add(button_owner_edit);
            panel_container_main_buttons.Controls.Add(textBox_owner_search);
            panel_container_main_buttons.Controls.Add(button_owner_add_owner);
            panel_container_main_buttons.Controls.Add(button_owner_search);
            panel_container_main_buttons.Dock = DockStyle.Top;
            panel_container_main_buttons.Location = new Point(3, 3);
            panel_container_main_buttons.Name = "panel_container_main_buttons";
            panel_container_main_buttons.Size = new Size(1580, 100);
            panel_container_main_buttons.TabIndex = 9;
            // 
            // button_owner_delete
            // 
            button_owner_delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_owner_delete.AutoSize = false;
            button_owner_delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_delete.Depth = 0;
            button_owner_delete.HighEmphasis = true;
            button_owner_delete.Icon = Properties.Resources.icons8_delete_480;
            button_owner_delete.Location = new Point(1451, 22);
            button_owner_delete.Margin = new Padding(4, 6, 4, 6);
            button_owner_delete.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_delete.Name = "button_owner_delete";
            button_owner_delete.NoAccentTextColor = Color.Empty;
            button_owner_delete.Size = new Size(112, 45);
            button_owner_delete.TabIndex = 13;
            button_owner_delete.Text = "Delete";
            button_owner_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_delete.UseAccentColor = false;
            button_owner_delete.UseVisualStyleBackColor = true;
            // 
            // button_owner_edit
            // 
            button_owner_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_owner_edit.AutoSize = false;
            button_owner_edit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_edit.Depth = 0;
            button_owner_edit.HighEmphasis = true;
            button_owner_edit.Icon = Properties.Resources.icons8_edit_512;
            button_owner_edit.Location = new Point(1331, 22);
            button_owner_edit.Margin = new Padding(4, 6, 4, 6);
            button_owner_edit.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_edit.Name = "button_owner_edit";
            button_owner_edit.NoAccentTextColor = Color.Empty;
            button_owner_edit.Size = new Size(112, 45);
            button_owner_edit.TabIndex = 12;
            button_owner_edit.Text = "Edit";
            button_owner_edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_edit.UseAccentColor = false;
            button_owner_edit.UseVisualStyleBackColor = true;
            // 
            // textBox_owner_search
            // 
            textBox_owner_search.AnimateReadOnly = false;
            textBox_owner_search.BackgroundImageLayout = ImageLayout.None;
            textBox_owner_search.CharacterCasing = CharacterCasing.Normal;
            textBox_owner_search.Depth = 0;
            textBox_owner_search.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_owner_search.HideSelection = true;
            textBox_owner_search.LeadingIcon = Properties.Resources.icons8_person_90;
            textBox_owner_search.Location = new Point(32, 19);
            textBox_owner_search.MaxLength = 32767;
            textBox_owner_search.MouseState = MaterialSkin.MouseState.OUT;
            textBox_owner_search.Name = "textBox_owner_search";
            textBox_owner_search.PasswordChar = '\0';
            textBox_owner_search.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_owner_search.PrefixSuffixText = "Search";
            textBox_owner_search.ReadOnly = false;
            textBox_owner_search.RightToLeft = RightToLeft.No;
            textBox_owner_search.SelectedText = "";
            textBox_owner_search.SelectionLength = 0;
            textBox_owner_search.SelectionStart = 0;
            textBox_owner_search.ShortcutsEnabled = true;
            textBox_owner_search.Size = new Size(464, 48);
            textBox_owner_search.TabIndex = 0;
            textBox_owner_search.TabStop = false;
            textBox_owner_search.TextAlign = HorizontalAlignment.Left;
            textBox_owner_search.TrailingIcon = Properties.Resources.icons8_search_500;
            textBox_owner_search.UseSystemPasswordChar = false;
            // 
            // button_owner_add_owner
            // 
            button_owner_add_owner.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_owner_add_owner.AutoSize = false;
            button_owner_add_owner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_add_owner.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_add_owner.Depth = 0;
            button_owner_add_owner.HighEmphasis = true;
            button_owner_add_owner.Icon = Properties.Resources.icons8_person_90;
            button_owner_add_owner.Location = new Point(1211, 22);
            button_owner_add_owner.Margin = new Padding(4, 6, 4, 6);
            button_owner_add_owner.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_add_owner.Name = "button_owner_add_owner";
            button_owner_add_owner.NoAccentTextColor = Color.Empty;
            button_owner_add_owner.Size = new Size(112, 45);
            button_owner_add_owner.TabIndex = 11;
            button_owner_add_owner.Text = "Add";
            button_owner_add_owner.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_add_owner.UseAccentColor = false;
            button_owner_add_owner.UseVisualStyleBackColor = true;
            // 
            // button_owner_search
            // 
            button_owner_search.AutoSize = false;
            button_owner_search.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_search.Cursor = Cursors.Help;
            button_owner_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_search.Depth = 0;
            button_owner_search.HighEmphasis = true;
            button_owner_search.Icon = null;
            button_owner_search.Location = new Point(518, 22);
            button_owner_search.Margin = new Padding(4, 6, 4, 6);
            button_owner_search.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_search.Name = "button_owner_search";
            button_owner_search.NoAccentTextColor = Color.Empty;
            button_owner_search.Size = new Size(140, 45);
            button_owner_search.TabIndex = 1;
            button_owner_search.Text = "Search";
            button_owner_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_search.UseAccentColor = true;
            button_owner_search.UseVisualStyleBackColor = true;
            // 
            // tabPage_owner_details
            // 
            tabPage_owner_details.Controls.Add(panel_container_data);
            tabPage_owner_details.Controls.Add(panel_container);
            tabPage_owner_details.Location = new Point(4, 24);
            tabPage_owner_details.Name = "tabPage_owner_details";
            tabPage_owner_details.Padding = new Padding(3);
            tabPage_owner_details.Size = new Size(1586, 866);
            tabPage_owner_details.TabIndex = 1;
            tabPage_owner_details.Text = "Details";
            tabPage_owner_details.UseVisualStyleBackColor = true;
            // 
            // panel_container_data
            // 
            panel_container_data.Controls.Add(dataGridView_owner_pets);
            panel_container_data.Dock = DockStyle.Fill;
            panel_container_data.Location = new Point(655, 3);
            panel_container_data.Margin = new Padding(22);
            panel_container_data.Name = "panel_container_data";
            panel_container_data.Padding = new Padding(22);
            panel_container_data.Size = new Size(928, 860);
            panel_container_data.TabIndex = 33;
            // 
            // dataGridView_owner_pets
            // 
            dataGridView_owner_pets.AllowUserToAddRows = false;
            dataGridView_owner_pets.AllowUserToDeleteRows = false;
            dataGridView_owner_pets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_owner_pets.Dock = DockStyle.Fill;
            dataGridView_owner_pets.Location = new Point(22, 22);
            dataGridView_owner_pets.MultiSelect = false;
            dataGridView_owner_pets.Name = "dataGridView_owner_pets";
            dataGridView_owner_pets.ReadOnly = true;
            dataGridView_owner_pets.RowTemplate.Height = 25;
            dataGridView_owner_pets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_owner_pets.Size = new Size(884, 816);
            dataGridView_owner_pets.TabIndex = 20;
            // 
            // panel_container
            // 
            panel_container.Controls.Add(materialTextBox21_owner_id_mask);
            panel_container.Controls.Add(panel_buttons_container);
            panel_container.Controls.Add(numericUpDown_owner_id);
            panel_container.Controls.Add(textBox_owner_name);
            panel_container.Controls.Add(materialDivider3);
            panel_container.Controls.Add(textBox_owner_phone);
            panel_container.Controls.Add(textBox_owner_email);
            panel_container.Dock = DockStyle.Left;
            panel_container.Location = new Point(3, 3);
            panel_container.Margin = new Padding(22);
            panel_container.Name = "panel_container";
            panel_container.Padding = new Padding(22);
            panel_container.Size = new Size(652, 860);
            panel_container.TabIndex = 33;
            // 
            // materialTextBox21_owner_id_mask
            // 
            materialTextBox21_owner_id_mask.Anchor = AnchorStyles.None;
            materialTextBox21_owner_id_mask.AnimateReadOnly = true;
            materialTextBox21_owner_id_mask.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21_owner_id_mask.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21_owner_id_mask.Depth = 0;
            materialTextBox21_owner_id_mask.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21_owner_id_mask.HideSelection = true;
            materialTextBox21_owner_id_mask.LeadingIcon = Properties.Resources.icons8_person_90;
            materialTextBox21_owner_id_mask.Location = new Point(48, 48);
            materialTextBox21_owner_id_mask.MaxLength = 32767;
            materialTextBox21_owner_id_mask.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21_owner_id_mask.Name = "materialTextBox21_owner_id_mask";
            materialTextBox21_owner_id_mask.PasswordChar = '\0';
            materialTextBox21_owner_id_mask.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            materialTextBox21_owner_id_mask.PrefixSuffixText = "Owner ID";
            materialTextBox21_owner_id_mask.ReadOnly = true;
            materialTextBox21_owner_id_mask.RightToLeft = RightToLeft.No;
            materialTextBox21_owner_id_mask.SelectedText = "";
            materialTextBox21_owner_id_mask.SelectionLength = 0;
            materialTextBox21_owner_id_mask.SelectionStart = 0;
            materialTextBox21_owner_id_mask.ShortcutsEnabled = true;
            materialTextBox21_owner_id_mask.Size = new Size(204, 48);
            materialTextBox21_owner_id_mask.TabIndex = 37;
            materialTextBox21_owner_id_mask.TabStop = false;
            materialTextBox21_owner_id_mask.TextAlign = HorizontalAlignment.Left;
            materialTextBox21_owner_id_mask.TrailingIcon = null;
            materialTextBox21_owner_id_mask.UseSystemPasswordChar = false;
            // 
            // panel_buttons_container
            // 
            panel_buttons_container.Controls.Add(button_owner_save);
            panel_buttons_container.Controls.Add(button_owner_delete_pet);
            panel_buttons_container.Controls.Add(button_owner_add_new_pet);
            panel_buttons_container.Controls.Add(button_owner_cancel);
            panel_buttons_container.Controls.Add(button_owner_edit_pet);
            panel_buttons_container.Dock = DockStyle.Bottom;
            panel_buttons_container.Location = new Point(22, 706);
            panel_buttons_container.Name = "panel_buttons_container";
            panel_buttons_container.Size = new Size(608, 132);
            panel_buttons_container.TabIndex = 34;
            // 
            // button_owner_save
            // 
            button_owner_save.Anchor = AnchorStyles.None;
            button_owner_save.AutoSize = false;
            button_owner_save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_save.Depth = 0;
            button_owner_save.HighEmphasis = true;
            button_owner_save.Icon = Properties.Resources.icons8_save_90;
            button_owner_save.Location = new Point(27, 25);
            button_owner_save.Margin = new Padding(4, 6, 4, 6);
            button_owner_save.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_save.Name = "button_owner_save";
            button_owner_save.NoAccentTextColor = Color.Empty;
            button_owner_save.Size = new Size(106, 36);
            button_owner_save.TabIndex = 0;
            button_owner_save.Text = "Save";
            button_owner_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_save.UseAccentColor = true;
            button_owner_save.UseVisualStyleBackColor = true;
            // 
            // button_owner_delete_pet
            // 
            button_owner_delete_pet.Anchor = AnchorStyles.None;
            button_owner_delete_pet.AutoSize = false;
            button_owner_delete_pet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_delete_pet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_delete_pet.Depth = 0;
            button_owner_delete_pet.HighEmphasis = true;
            button_owner_delete_pet.Icon = Properties.Resources.icons8_delete_480;
            button_owner_delete_pet.Location = new Point(433, 25);
            button_owner_delete_pet.Margin = new Padding(4, 6, 4, 6);
            button_owner_delete_pet.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_delete_pet.Name = "button_owner_delete_pet";
            button_owner_delete_pet.NoAccentTextColor = Color.Empty;
            button_owner_delete_pet.Size = new Size(142, 85);
            button_owner_delete_pet.TabIndex = 6;
            button_owner_delete_pet.Text = "Delete Pet";
            button_owner_delete_pet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_delete_pet.UseAccentColor = true;
            button_owner_delete_pet.UseVisualStyleBackColor = true;
            // 
            // button_owner_add_new_pet
            // 
            button_owner_add_new_pet.Anchor = AnchorStyles.None;
            button_owner_add_new_pet.AutoSize = false;
            button_owner_add_new_pet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_add_new_pet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_add_new_pet.Depth = 0;
            button_owner_add_new_pet.HighEmphasis = true;
            button_owner_add_new_pet.Icon = Properties.Resources.icons8_cat_face_96;
            button_owner_add_new_pet.Location = new Point(283, 25);
            button_owner_add_new_pet.Margin = new Padding(4, 6, 4, 6);
            button_owner_add_new_pet.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_add_new_pet.Name = "button_owner_add_new_pet";
            button_owner_add_new_pet.NoAccentTextColor = Color.Empty;
            button_owner_add_new_pet.Size = new Size(142, 36);
            button_owner_add_new_pet.TabIndex = 5;
            button_owner_add_new_pet.Text = "Add Pet";
            button_owner_add_new_pet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_add_new_pet.UseAccentColor = true;
            button_owner_add_new_pet.UseVisualStyleBackColor = true;
            // 
            // button_owner_cancel
            // 
            button_owner_cancel.Anchor = AnchorStyles.None;
            button_owner_cancel.AutoSize = false;
            button_owner_cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_cancel.Depth = 0;
            button_owner_cancel.HighEmphasis = true;
            button_owner_cancel.Icon = null;
            button_owner_cancel.Location = new Point(141, 25);
            button_owner_cancel.Margin = new Padding(4, 6, 4, 6);
            button_owner_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_cancel.Name = "button_owner_cancel";
            button_owner_cancel.NoAccentTextColor = Color.Empty;
            button_owner_cancel.Size = new Size(106, 36);
            button_owner_cancel.TabIndex = 2;
            button_owner_cancel.Text = "Cancel";
            button_owner_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_cancel.UseAccentColor = false;
            button_owner_cancel.UseVisualStyleBackColor = true;
            // 
            // button_owner_edit_pet
            // 
            button_owner_edit_pet.Anchor = AnchorStyles.None;
            button_owner_edit_pet.AutoSize = false;
            button_owner_edit_pet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_owner_edit_pet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_owner_edit_pet.Depth = 0;
            button_owner_edit_pet.HighEmphasis = true;
            button_owner_edit_pet.Icon = Properties.Resources.icons8_edit_512;
            button_owner_edit_pet.Location = new Point(283, 74);
            button_owner_edit_pet.Margin = new Padding(4, 6, 4, 6);
            button_owner_edit_pet.MouseState = MaterialSkin.MouseState.HOVER;
            button_owner_edit_pet.Name = "button_owner_edit_pet";
            button_owner_edit_pet.NoAccentTextColor = Color.Empty;
            button_owner_edit_pet.Size = new Size(142, 36);
            button_owner_edit_pet.TabIndex = 3;
            button_owner_edit_pet.Text = "Edit Pet";
            button_owner_edit_pet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_owner_edit_pet.UseAccentColor = false;
            button_owner_edit_pet.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_owner_id
            // 
            numericUpDown_owner_id.Anchor = AnchorStyles.None;
            numericUpDown_owner_id.AutoSize = true;
            numericUpDown_owner_id.BorderStyle = BorderStyle.None;
            numericUpDown_owner_id.Enabled = false;
            numericUpDown_owner_id.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_owner_id.ImeMode = ImeMode.NoControl;
            numericUpDown_owner_id.Location = new Point(48, 48);
            numericUpDown_owner_id.Name = "numericUpDown_owner_id";
            numericUpDown_owner_id.ReadOnly = true;
            numericUpDown_owner_id.Size = new Size(164, 32);
            numericUpDown_owner_id.TabIndex = 24;
            // 
            // textBox_owner_name
            // 
            textBox_owner_name.Anchor = AnchorStyles.None;
            textBox_owner_name.AnimateReadOnly = false;
            textBox_owner_name.BackgroundImageLayout = ImageLayout.None;
            textBox_owner_name.CharacterCasing = CharacterCasing.Normal;
            textBox_owner_name.Depth = 0;
            textBox_owner_name.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_owner_name.HelperText = "                      Enter Owner Name";
            textBox_owner_name.HideSelection = true;
            textBox_owner_name.LeadingIcon = Properties.Resources.icons8_person_90;
            textBox_owner_name.Location = new Point(48, 187);
            textBox_owner_name.MaxLength = 32767;
            textBox_owner_name.MouseState = MaterialSkin.MouseState.OUT;
            textBox_owner_name.Name = "textBox_owner_name";
            textBox_owner_name.PasswordChar = '\0';
            textBox_owner_name.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_owner_name.PrefixSuffixText = "Name";
            textBox_owner_name.ReadOnly = false;
            textBox_owner_name.RightToLeft = RightToLeft.No;
            textBox_owner_name.SelectedText = "";
            textBox_owner_name.SelectionLength = 0;
            textBox_owner_name.SelectionStart = 0;
            textBox_owner_name.ShortcutsEnabled = true;
            textBox_owner_name.ShowAssistiveText = true;
            textBox_owner_name.Size = new Size(548, 64);
            textBox_owner_name.TabIndex = 10;
            textBox_owner_name.TabStop = false;
            textBox_owner_name.TextAlign = HorizontalAlignment.Left;
            textBox_owner_name.TrailingIcon = null;
            textBox_owner_name.UseSystemPasswordChar = false;
            // 
            // materialDivider3
            // 
            materialDivider3.Anchor = AnchorStyles.None;
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(113, 141);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(420, 3);
            materialDivider3.TabIndex = 27;
            materialDivider3.Text = "materialDivider3";
            // 
            // textBox_owner_phone
            // 
            textBox_owner_phone.Anchor = AnchorStyles.None;
            textBox_owner_phone.AnimateReadOnly = false;
            textBox_owner_phone.BackgroundImageLayout = ImageLayout.None;
            textBox_owner_phone.CharacterCasing = CharacterCasing.Normal;
            textBox_owner_phone.Depth = 0;
            textBox_owner_phone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_owner_phone.HelperText = "                      Enter Owner Phone";
            textBox_owner_phone.HideSelection = true;
            textBox_owner_phone.LeadingIcon = Properties.Resources.icons8_person_90;
            textBox_owner_phone.Location = new Point(49, 275);
            textBox_owner_phone.MaxLength = 32767;
            textBox_owner_phone.MouseState = MaterialSkin.MouseState.OUT;
            textBox_owner_phone.Name = "textBox_owner_phone";
            textBox_owner_phone.PasswordChar = '\0';
            textBox_owner_phone.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_owner_phone.PrefixSuffixText = "Phone";
            textBox_owner_phone.ReadOnly = false;
            textBox_owner_phone.RightToLeft = RightToLeft.No;
            textBox_owner_phone.SelectedText = "";
            textBox_owner_phone.SelectionLength = 0;
            textBox_owner_phone.SelectionStart = 0;
            textBox_owner_phone.ShortcutsEnabled = true;
            textBox_owner_phone.ShowAssistiveText = true;
            textBox_owner_phone.Size = new Size(548, 64);
            textBox_owner_phone.TabIndex = 11;
            textBox_owner_phone.TabStop = false;
            textBox_owner_phone.TextAlign = HorizontalAlignment.Left;
            textBox_owner_phone.TrailingIcon = null;
            textBox_owner_phone.UseSystemPasswordChar = false;
            // 
            // textBox_owner_email
            // 
            textBox_owner_email.Anchor = AnchorStyles.None;
            textBox_owner_email.AnimateReadOnly = false;
            textBox_owner_email.BackgroundImageLayout = ImageLayout.None;
            textBox_owner_email.CharacterCasing = CharacterCasing.Normal;
            textBox_owner_email.Depth = 0;
            textBox_owner_email.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox_owner_email.HelperText = "                      Enter Owner Email";
            textBox_owner_email.HideSelection = true;
            textBox_owner_email.LeadingIcon = Properties.Resources.icons8_person_90;
            textBox_owner_email.Location = new Point(49, 364);
            textBox_owner_email.MaxLength = 32767;
            textBox_owner_email.MouseState = MaterialSkin.MouseState.OUT;
            textBox_owner_email.Name = "textBox_owner_email";
            textBox_owner_email.PasswordChar = '\0';
            textBox_owner_email.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            textBox_owner_email.PrefixSuffixText = "Email";
            textBox_owner_email.ReadOnly = false;
            textBox_owner_email.RightToLeft = RightToLeft.No;
            textBox_owner_email.SelectedText = "";
            textBox_owner_email.SelectionLength = 0;
            textBox_owner_email.SelectionStart = 0;
            textBox_owner_email.ShortcutsEnabled = true;
            textBox_owner_email.ShowAssistiveText = true;
            textBox_owner_email.Size = new Size(548, 64);
            textBox_owner_email.TabIndex = 12;
            textBox_owner_email.TabStop = false;
            textBox_owner_email.TextAlign = HorizontalAlignment.Left;
            textBox_owner_email.TrailingIcon = null;
            textBox_owner_email.UseSystemPasswordChar = false;
            // 
            // Owner_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(tabControl_owner_form);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Owner_Form";
            Padding = new Padding(3);
            Sizable = false;
            Text = "Owner_Form";
            tabControl_owner_form.ResumeLayout(false);
            tabPage_owners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_owners).EndInit();
            panel_container_main_buttons.ResumeLayout(false);
            tabPage_owner_details.ResumeLayout(false);
            panel_container_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_owner_pets).EndInit();
            panel_container.ResumeLayout(false);
            panel_container.PerformLayout();
            panel_buttons_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_owner_id).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControl_owner_form;
        private TabPage tabPage_owners;
        private MaterialSkin.Controls.MaterialButton button_owner_search;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_owner_search;
        private TabPage tabPage_owner_details;
        private Panel panel_buttons_container;
        private MaterialSkin.Controls.MaterialButton button_owner_save;
        private MaterialSkin.Controls.MaterialButton button_owner_delete_pet;
        private MaterialSkin.Controls.MaterialButton button_owner_add_new_pet;
        private MaterialSkin.Controls.MaterialButton button_owner_cancel;
        private MaterialSkin.Controls.MaterialButton button_owner_edit_pet;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_owner_phone;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_owner_name;
        private NumericUpDown numericUpDown_owner_id;
        private MaterialSkin.Controls.MaterialButton button_owner_delete;
        private MaterialSkin.Controls.MaterialButton button_owner_edit;
        private MaterialSkin.Controls.MaterialButton button_owner_add_owner;
        private MaterialSkin.Controls.MaterialTextBox2 textBox_owner_email;
        private Panel panel_container;
        private Panel panel_container_data;
        private DataGridView dataGridView_owners;
        private DataGridView dataGridView_owner_pets;
        private Panel panel_container_main_buttons;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21_owner_id_mask;
    }
}