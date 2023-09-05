namespace Veterinary_CRUD_App.Views
{
    partial class Main_View
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
            panel_main_view = new Panel();
            iconButton_exit = new FontAwesome.Sharp.IconButton();
            panel_greet_container = new Panel();
            label_greet = new Label();
            linkLabel_me = new LinkLabel();
            label_heart = new Label();
            button_main_view_owners = new FontAwesome.Sharp.IconButton();
            button_main_view_visits = new FontAwesome.Sharp.IconButton();
            button_main_view_pets = new FontAwesome.Sharp.IconButton();
            iconButton_home = new FontAwesome.Sharp.IconButton();
            panel_logo_container = new Panel();
            iconButton_toggle_menu = new FontAwesome.Sharp.IconButton();
            iconButton_home_page = new FontAwesome.Sharp.IconButton();
            panel_visits_title = new Panel();
            iconPictureBox_current_child_form_icon = new FontAwesome.Sharp.IconPictureBox();
            label_current_child_form_name = new Label();
            panel_main_view.SuspendLayout();
            panel_greet_container.SuspendLayout();
            panel_logo_container.SuspendLayout();
            panel_visits_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox_current_child_form_icon).BeginInit();
            SuspendLayout();
            // 
            // panel_main_view
            // 
            panel_main_view.BackColor = Color.FromArgb(27, 67, 50);
            panel_main_view.Controls.Add(iconButton_exit);
            panel_main_view.Controls.Add(panel_greet_container);
            panel_main_view.Controls.Add(button_main_view_owners);
            panel_main_view.Controls.Add(button_main_view_visits);
            panel_main_view.Controls.Add(button_main_view_pets);
            panel_main_view.Controls.Add(iconButton_home);
            panel_main_view.Controls.Add(panel_logo_container);
            panel_main_view.Dock = DockStyle.Left;
            panel_main_view.Location = new Point(3, 24);
            panel_main_view.Margin = new Padding(4, 2, 4, 2);
            panel_main_view.Name = "panel_main_view";
            panel_main_view.Size = new Size(250, 702);
            panel_main_view.TabIndex = 0;
            // 
            // iconButton_exit
            // 
            iconButton_exit.Dock = DockStyle.Bottom;
            iconButton_exit.FlatAppearance.BorderSize = 0;
            iconButton_exit.FlatStyle = FlatStyle.Flat;
            iconButton_exit.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton_exit.ForeColor = Color.White;
            iconButton_exit.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            iconButton_exit.IconColor = Color.White;
            iconButton_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_exit.IconSize = 44;
            iconButton_exit.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_exit.Location = new Point(0, 577);
            iconButton_exit.Margin = new Padding(4, 2, 4, 2);
            iconButton_exit.Name = "iconButton_exit";
            iconButton_exit.Padding = new Padding(10, 0, 50, 0);
            iconButton_exit.Size = new Size(250, 55);
            iconButton_exit.TabIndex = 30;
            iconButton_exit.Tag = "Exit";
            iconButton_exit.Text = "Exit";
            iconButton_exit.TextAlign = ContentAlignment.MiddleLeft;
            iconButton_exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton_exit.UseVisualStyleBackColor = true;
            // 
            // panel_greet_container
            // 
            panel_greet_container.Controls.Add(label_greet);
            panel_greet_container.Controls.Add(linkLabel_me);
            panel_greet_container.Controls.Add(label_heart);
            panel_greet_container.Dock = DockStyle.Bottom;
            panel_greet_container.Location = new Point(0, 632);
            panel_greet_container.Name = "panel_greet_container";
            panel_greet_container.Size = new Size(250, 70);
            panel_greet_container.TabIndex = 28;
            // 
            // label_greet
            // 
            label_greet.AutoSize = true;
            label_greet.BackColor = Color.Transparent;
            label_greet.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_greet.ForeColor = Color.White;
            label_greet.Location = new Point(12, 11);
            label_greet.Name = "label_greet";
            label_greet.Size = new Size(203, 16);
            label_greet.TabIndex = 23;
            label_greet.Text = "Looking forward to work with";
            // 
            // linkLabel_me
            // 
            linkLabel_me.AutoSize = true;
            linkLabel_me.LinkColor = Color.FromArgb(167, 209, 41);
            linkLabel_me.Location = new Point(32, 32);
            linkLabel_me.Name = "linkLabel_me";
            linkLabel_me.Size = new Size(182, 16);
            linkLabel_me.TabIndex = 24;
            linkLabel_me.TabStop = true;
            linkLabel_me.Text = "Made by Hristijan Stavrov";
            linkLabel_me.LinkClicked += LinkLabel_Me_LinkClicked;
            // 
            // label_heart
            // 
            label_heart.AutoSize = true;
            label_heart.BackColor = Color.Transparent;
            label_heart.Font = new Font("Cascadia Code", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label_heart.ForeColor = Color.IndianRed;
            label_heart.Location = new Point(215, 11);
            label_heart.Name = "label_heart";
            label_heart.Size = new Size(27, 18);
            label_heart.TabIndex = 25;
            label_heart.Text = "❤";
            // 
            // button_main_view_owners
            // 
            button_main_view_owners.Dock = DockStyle.Top;
            button_main_view_owners.FlatAppearance.BorderSize = 0;
            button_main_view_owners.FlatStyle = FlatStyle.Flat;
            button_main_view_owners.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_main_view_owners.ForeColor = Color.White;
            button_main_view_owners.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            button_main_view_owners.IconColor = Color.White;
            button_main_view_owners.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button_main_view_owners.IconSize = 44;
            button_main_view_owners.ImageAlign = ContentAlignment.MiddleLeft;
            button_main_view_owners.Location = new Point(0, 309);
            button_main_view_owners.Margin = new Padding(4, 2, 4, 2);
            button_main_view_owners.Name = "button_main_view_owners";
            button_main_view_owners.Padding = new Padding(10, 0, 50, 0);
            button_main_view_owners.Size = new Size(250, 55);
            button_main_view_owners.TabIndex = 5;
            button_main_view_owners.Tag = "Owners";
            button_main_view_owners.Text = "Owners";
            button_main_view_owners.TextAlign = ContentAlignment.MiddleLeft;
            button_main_view_owners.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_main_view_owners.UseVisualStyleBackColor = true;
            // 
            // button_main_view_visits
            // 
            button_main_view_visits.Dock = DockStyle.Top;
            button_main_view_visits.FlatAppearance.BorderSize = 0;
            button_main_view_visits.FlatStyle = FlatStyle.Flat;
            button_main_view_visits.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_main_view_visits.ForeColor = Color.White;
            button_main_view_visits.IconChar = FontAwesome.Sharp.IconChar.Eye;
            button_main_view_visits.IconColor = Color.White;
            button_main_view_visits.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button_main_view_visits.IconSize = 44;
            button_main_view_visits.ImageAlign = ContentAlignment.MiddleLeft;
            button_main_view_visits.Location = new Point(0, 254);
            button_main_view_visits.Margin = new Padding(4, 2, 4, 2);
            button_main_view_visits.Name = "button_main_view_visits";
            button_main_view_visits.Padding = new Padding(10, 0, 50, 0);
            button_main_view_visits.Size = new Size(250, 55);
            button_main_view_visits.TabIndex = 4;
            button_main_view_visits.Tag = "Visits";
            button_main_view_visits.Text = "Visits";
            button_main_view_visits.TextAlign = ContentAlignment.MiddleLeft;
            button_main_view_visits.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_main_view_visits.UseVisualStyleBackColor = true;
            // 
            // button_main_view_pets
            // 
            button_main_view_pets.Dock = DockStyle.Top;
            button_main_view_pets.FlatAppearance.BorderSize = 0;
            button_main_view_pets.FlatStyle = FlatStyle.Flat;
            button_main_view_pets.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_main_view_pets.ForeColor = Color.White;
            button_main_view_pets.IconChar = FontAwesome.Sharp.IconChar.Cat;
            button_main_view_pets.IconColor = Color.White;
            button_main_view_pets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            button_main_view_pets.IconSize = 44;
            button_main_view_pets.ImageAlign = ContentAlignment.MiddleLeft;
            button_main_view_pets.Location = new Point(0, 199);
            button_main_view_pets.Margin = new Padding(4, 2, 4, 2);
            button_main_view_pets.Name = "button_main_view_pets";
            button_main_view_pets.Padding = new Padding(10, 0, 50, 0);
            button_main_view_pets.Size = new Size(250, 55);
            button_main_view_pets.TabIndex = 3;
            button_main_view_pets.Tag = "Pets";
            button_main_view_pets.Text = "Pets";
            button_main_view_pets.TextAlign = ContentAlignment.MiddleLeft;
            button_main_view_pets.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_main_view_pets.UseVisualStyleBackColor = true;
            // 
            // iconButton_home
            // 
            iconButton_home.Dock = DockStyle.Top;
            iconButton_home.FlatAppearance.BorderSize = 0;
            iconButton_home.FlatStyle = FlatStyle.Flat;
            iconButton_home.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton_home.ForeColor = Color.White;
            iconButton_home.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton_home.IconColor = Color.White;
            iconButton_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_home.IconSize = 44;
            iconButton_home.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_home.Location = new Point(0, 144);
            iconButton_home.Margin = new Padding(4, 2, 4, 2);
            iconButton_home.Name = "iconButton_home";
            iconButton_home.Padding = new Padding(10, 0, 50, 0);
            iconButton_home.Size = new Size(250, 55);
            iconButton_home.TabIndex = 29;
            iconButton_home.Tag = "Home";
            iconButton_home.Text = "Home";
            iconButton_home.TextAlign = ContentAlignment.MiddleLeft;
            iconButton_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton_home.UseVisualStyleBackColor = true;
            iconButton_home.Visible = false;
            // 
            // panel_logo_container
            // 
            panel_logo_container.Controls.Add(iconButton_toggle_menu);
            panel_logo_container.Controls.Add(iconButton_home_page);
            panel_logo_container.Dock = DockStyle.Top;
            panel_logo_container.Location = new Point(0, 0);
            panel_logo_container.Name = "panel_logo_container";
            panel_logo_container.Size = new Size(250, 144);
            panel_logo_container.TabIndex = 6;
            // 
            // iconButton_toggle_menu
            // 
            iconButton_toggle_menu.FlatAppearance.BorderSize = 0;
            iconButton_toggle_menu.FlatStyle = FlatStyle.Flat;
            iconButton_toggle_menu.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            iconButton_toggle_menu.IconColor = Color.White;
            iconButton_toggle_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_toggle_menu.IconSize = 33;
            iconButton_toggle_menu.Location = new Point(179, 12);
            iconButton_toggle_menu.Name = "iconButton_toggle_menu";
            iconButton_toggle_menu.Size = new Size(68, 60);
            iconButton_toggle_menu.TabIndex = 27;
            iconButton_toggle_menu.UseVisualStyleBackColor = true;
            // 
            // iconButton_home_page
            // 
            iconButton_home_page.FlatAppearance.BorderSize = 0;
            iconButton_home_page.FlatStyle = FlatStyle.Flat;
            iconButton_home_page.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton_home_page.ForeColor = Color.White;
            iconButton_home_page.IconChar = FontAwesome.Sharp.IconChar.ShieldCat;
            iconButton_home_page.IconColor = Color.White;
            iconButton_home_page.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_home_page.IconSize = 44;
            iconButton_home_page.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_home_page.Location = new Point(12, 12);
            iconButton_home_page.Name = "iconButton_home_page";
            iconButton_home_page.Size = new Size(164, 60);
            iconButton_home_page.TabIndex = 26;
            iconButton_home_page.Text = "Cat A Log";
            iconButton_home_page.TextAlign = ContentAlignment.MiddleLeft;
            iconButton_home_page.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton_home_page.UseVisualStyleBackColor = true;
            // 
            // panel_visits_title
            // 
            panel_visits_title.BackColor = Color.FromArgb(27, 67, 50);
            panel_visits_title.Controls.Add(iconPictureBox_current_child_form_icon);
            panel_visits_title.Controls.Add(label_current_child_form_name);
            panel_visits_title.Dock = DockStyle.Top;
            panel_visits_title.Location = new Point(253, 24);
            panel_visits_title.Name = "panel_visits_title";
            panel_visits_title.Size = new Size(1094, 72);
            panel_visits_title.TabIndex = 3;
            // 
            // iconPictureBox_current_child_form_icon
            // 
            iconPictureBox_current_child_form_icon.BackColor = Color.FromArgb(27, 67, 50);
            iconPictureBox_current_child_form_icon.IconChar = FontAwesome.Sharp.IconChar.House;
            iconPictureBox_current_child_form_icon.IconColor = Color.White;
            iconPictureBox_current_child_form_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox_current_child_form_icon.IconSize = 44;
            iconPictureBox_current_child_form_icon.Location = new Point(28, 12);
            iconPictureBox_current_child_form_icon.Name = "iconPictureBox_current_child_form_icon";
            iconPictureBox_current_child_form_icon.Size = new Size(58, 44);
            iconPictureBox_current_child_form_icon.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox_current_child_form_icon.TabIndex = 1;
            iconPictureBox_current_child_form_icon.TabStop = false;
            // 
            // label_current_child_form_name
            // 
            label_current_child_form_name.AutoSize = true;
            label_current_child_form_name.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_current_child_form_name.ForeColor = Color.White;
            label_current_child_form_name.Location = new Point(92, 23);
            label_current_child_form_name.Name = "label_current_child_form_name";
            label_current_child_form_name.Size = new Size(46, 21);
            label_current_child_form_name.TabIndex = 0;
            label_current_child_form_name.Text = "Home";
            // 
            // Main_View
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel_visits_title);
            Controls.Add(panel_main_view);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = FormStyles.ActionBar_None;
            IsMdiContainer = true;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Main_View";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Main_View";
            panel_main_view.ResumeLayout(false);
            panel_greet_container.ResumeLayout(false);
            panel_greet_container.PerformLayout();
            panel_logo_container.ResumeLayout(false);
            panel_visits_title.ResumeLayout(false);
            panel_visits_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox_current_child_form_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main_view;
        private FontAwesome.Sharp.IconButton button_main_view_pets;
        private FontAwesome.Sharp.IconButton button_main_view_owners;
        private FontAwesome.Sharp.IconButton button_main_view_visits;
        private Panel panel_logo_container;
        private Label label_heart;
        private LinkLabel linkLabel_me;
        private Label label_greet;
        private FontAwesome.Sharp.IconButton iconButton_home_page;
        private Panel panel_visits_title;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_current_child_form_icon;
        private Label label_current_child_form_name;
        private FontAwesome.Sharp.IconButton iconButton_toggle_menu;
        private Panel panel_greet_container;
        private FontAwesome.Sharp.IconButton iconButton_home;
        private FontAwesome.Sharp.IconButton iconButton_exit;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
    }
}