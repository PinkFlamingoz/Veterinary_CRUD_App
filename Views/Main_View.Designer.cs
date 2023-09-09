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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_View));
            materialTabControl_menu = new MaterialSkin.Controls.MaterialTabControl();
            tabPage_home = new TabPage();
            tabPage_pets = new TabPage();
            tabPage_visits = new TabPage();
            tabPage_owners = new TabPage();
            tabPage_exit = new TabPage();
            imageList_menu_icons = new ImageList(components);
            materialTabControl_menu.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl_menu
            // 
            materialTabControl_menu.Anchor = AnchorStyles.None;
            materialTabControl_menu.Controls.Add(tabPage_home);
            materialTabControl_menu.Controls.Add(tabPage_pets);
            materialTabControl_menu.Controls.Add(tabPage_visits);
            materialTabControl_menu.Controls.Add(tabPage_owners);
            materialTabControl_menu.Controls.Add(tabPage_exit);
            materialTabControl_menu.Depth = 0;
            materialTabControl_menu.ImageList = imageList_menu_icons;
            materialTabControl_menu.Location = new Point(662, 351);
            materialTabControl_menu.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl_menu.Multiline = true;
            materialTabControl_menu.Name = "materialTabControl_menu";
            materialTabControl_menu.SelectedIndex = 0;
            materialTabControl_menu.Size = new Size(0, 0);
            materialTabControl_menu.TabIndex = 5;
            // 
            // tabPage_home
            // 
            tabPage_home.ImageKey = "icons8-home-384.png";
            tabPage_home.Location = new Point(4, 179);
            tabPage_home.Name = "tabPage_home";
            tabPage_home.Padding = new Padding(3);
            tabPage_home.Size = new Size(0, 0);
            tabPage_home.TabIndex = 0;
            tabPage_home.Text = "Home";
            tabPage_home.UseVisualStyleBackColor = true;
            // 
            // tabPage_pets
            // 
            tabPage_pets.ImageKey = "icons8-pets-90.png";
            tabPage_pets.Location = new Point(4, 179);
            tabPage_pets.Name = "tabPage_pets";
            tabPage_pets.Padding = new Padding(3);
            tabPage_pets.Size = new Size(0, 0);
            tabPage_pets.TabIndex = 1;
            tabPage_pets.Text = "Pets";
            tabPage_pets.UseVisualStyleBackColor = true;
            // 
            // tabPage_visits
            // 
            tabPage_visits.ImageKey = "icons8-appointment-64.png";
            tabPage_visits.Location = new Point(4, 179);
            tabPage_visits.Name = "tabPage_visits";
            tabPage_visits.Size = new Size(0, 0);
            tabPage_visits.TabIndex = 2;
            tabPage_visits.Text = "Visits";
            tabPage_visits.UseVisualStyleBackColor = true;
            // 
            // tabPage_owners
            // 
            tabPage_owners.ImageKey = "icons8-person-90.png";
            tabPage_owners.Location = new Point(4, 179);
            tabPage_owners.Name = "tabPage_owners";
            tabPage_owners.Size = new Size(0, 0);
            tabPage_owners.TabIndex = 3;
            tabPage_owners.Text = "Owners";
            tabPage_owners.UseVisualStyleBackColor = true;
            // 
            // tabPage_exit
            // 
            tabPage_exit.ImageKey = "icons8-exit-100.png";
            tabPage_exit.Location = new Point(4, 179);
            tabPage_exit.Name = "tabPage_exit";
            tabPage_exit.Size = new Size(0, 0);
            tabPage_exit.TabIndex = 4;
            tabPage_exit.Text = "Exit";
            tabPage_exit.UseVisualStyleBackColor = true;
            // 
            // imageList_menu_icons
            // 
            imageList_menu_icons.ColorDepth = ColorDepth.Depth32Bit;
            imageList_menu_icons.ImageStream = (ImageListStreamer)resources.GetObject("imageList_menu_icons.ImageStream");
            imageList_menu_icons.TransparentColor = Color.Transparent;
            imageList_menu_icons.Images.SetKeyName(0, "icons8-appointment-64.png");
            imageList_menu_icons.Images.SetKeyName(1, "icons8-exit-100.png");
            imageList_menu_icons.Images.SetKeyName(2, "icons8-home-384.png");
            imageList_menu_icons.Images.SetKeyName(3, "icons8-person-90.png");
            imageList_menu_icons.Images.SetKeyName(4, "icons8-pets-90.png");
            // 
            // Main_View
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(materialTabControl_menu);
            DrawerAutoShow = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl_menu;
            DrawerUseColors = true;
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = FormStyles.ActionBar_48;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Main_View";
            Padding = new Padding(3);
            Text = "Cat A Log";
            materialTabControl_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl_menu;
        private TabPage tabPage_home;
        private TabPage tabPage_pets;
        private TabPage tabPage_visits;
        private TabPage tabPage_owners;
        private TabPage tabPage_exit;
        private ImageList imageList_menu_icons;
    }
}