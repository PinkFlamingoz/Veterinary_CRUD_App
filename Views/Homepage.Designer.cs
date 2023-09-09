namespace Veterinary_CRUD_App.Views
{
    partial class Homepage
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
            panel_application_name_container = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            pictureBox_application_logo = new PictureBox();
            label_application_name = new MaterialSkin.Controls.MaterialLabel();
            label_heart = new MaterialSkin.Controls.MaterialLabel();
            panel_clock_container = new Panel();
            panel_clock = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            materialRadioButton_color_yellow = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton_color_pink = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton_color_red = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton_color_amber = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton_color_blue = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton_color_green = new MaterialSkin.Controls.MaterialRadioButton();
            materialLabel_color_settings = new MaterialSkin.Controls.MaterialLabel();
            materialLabel_theme_settings = new MaterialSkin.Controls.MaterialLabel();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            materialLabel_settings = new MaterialSkin.Controls.MaterialLabel();
            materialSwitch_theme = new MaterialSkin.Controls.MaterialSwitch();
            materialLabel_link_lable = new MaterialSkin.Controls.MaterialLabel();
            panel_application_name_container.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_application_logo).BeginInit();
            panel_clock_container.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_application_name_container
            // 
            panel_application_name_container.Controls.Add(materialCard2);
            panel_application_name_container.Dock = DockStyle.Top;
            panel_application_name_container.Location = new Point(3, 3);
            panel_application_name_container.Name = "panel_application_name_container";
            panel_application_name_container.Size = new Size(1360, 131);
            panel_application_name_container.TabIndex = 30;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.None;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialLabel_link_lable);
            materialCard2.Controls.Add(pictureBox_application_logo);
            materialCard2.Controls.Add(label_application_name);
            materialCard2.Controls.Add(label_heart);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(459, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(448, 100);
            materialCard2.TabIndex = 32;
            // 
            // pictureBox_application_logo
            // 
            pictureBox_application_logo.Anchor = AnchorStyles.None;
            pictureBox_application_logo.Image = Properties.Resources.Default_Pet_Image;
            pictureBox_application_logo.Location = new Point(45, 8);
            pictureBox_application_logo.Name = "pictureBox_application_logo";
            pictureBox_application_logo.Size = new Size(100, 85);
            pictureBox_application_logo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_application_logo.TabIndex = 31;
            pictureBox_application_logo.TabStop = false;
            // 
            // label_application_name
            // 
            label_application_name.Anchor = AnchorStyles.None;
            label_application_name.AutoSize = true;
            label_application_name.Depth = 0;
            label_application_name.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            label_application_name.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            label_application_name.Location = new Point(174, 18);
            label_application_name.MouseState = MaterialSkin.MouseState.HOVER;
            label_application_name.Name = "label_application_name";
            label_application_name.Size = new Size(147, 41);
            label_application_name.TabIndex = 30;
            label_application_name.Text = "Cat A Log";
            // 
            // label_heart
            // 
            label_heart.Anchor = AnchorStyles.None;
            label_heart.AutoSize = true;
            label_heart.Depth = 0;
            label_heart.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            label_heart.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            label_heart.HighEmphasis = true;
            label_heart.Location = new Point(318, 8);
            label_heart.MouseState = MaterialSkin.MouseState.HOVER;
            label_heart.Name = "label_heart";
            label_heart.Size = new Size(60, 58);
            label_heart.TabIndex = 30;
            label_heart.Text = "❤";
            label_heart.UseAccent = true;
            // 
            // panel_clock_container
            // 
            panel_clock_container.Controls.Add(panel_clock);
            panel_clock_container.Controls.Add(materialCard1);
            panel_clock_container.Dock = DockStyle.Fill;
            panel_clock_container.Location = new Point(3, 134);
            panel_clock_container.Name = "panel_clock_container";
            panel_clock_container.Size = new Size(1360, 631);
            panel_clock_container.TabIndex = 32;
            // 
            // panel_clock
            // 
            panel_clock.Anchor = AnchorStyles.None;
            panel_clock.Location = new Point(0, 0);
            panel_clock.Name = "panel_clock";
            panel_clock.Size = new Size(1360, 431);
            panel_clock.TabIndex = 32;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialDivider4);
            materialCard1.Controls.Add(materialDivider3);
            materialCard1.Controls.Add(materialRadioButton_color_yellow);
            materialCard1.Controls.Add(materialRadioButton_color_pink);
            materialCard1.Controls.Add(materialRadioButton_color_red);
            materialCard1.Controls.Add(materialRadioButton_color_amber);
            materialCard1.Controls.Add(materialRadioButton_color_blue);
            materialCard1.Controls.Add(materialRadioButton_color_green);
            materialCard1.Controls.Add(materialLabel_color_settings);
            materialCard1.Controls.Add(materialLabel_theme_settings);
            materialCard1.Controls.Add(materialDivider2);
            materialCard1.Controls.Add(materialDivider1);
            materialCard1.Controls.Add(materialLabel_settings);
            materialCard1.Controls.Add(materialSwitch_theme);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Bottom;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 430);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1360, 201);
            materialCard1.TabIndex = 31;
            // 
            // materialDivider4
            // 
            materialDivider4.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider4.Depth = 0;
            materialDivider4.Location = new Point(315, 78);
            materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider4.Name = "materialDivider4";
            materialDivider4.Size = new Size(3, 20);
            materialDivider4.TabIndex = 43;
            materialDivider4.Text = "materialDivider4";
            // 
            // materialDivider3
            // 
            materialDivider3.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(31, 79);
            materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(3, 20);
            materialDivider3.TabIndex = 42;
            materialDivider3.Text = "materialDivider3";
            // 
            // materialRadioButton_color_yellow
            // 
            materialRadioButton_color_yellow.AutoSize = true;
            materialRadioButton_color_yellow.Depth = 0;
            materialRadioButton_color_yellow.Location = new Point(500, 145);
            materialRadioButton_color_yellow.Margin = new Padding(0);
            materialRadioButton_color_yellow.MouseLocation = new Point(-1, -1);
            materialRadioButton_color_yellow.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton_color_yellow.Name = "materialRadioButton_color_yellow";
            materialRadioButton_color_yellow.Ripple = true;
            materialRadioButton_color_yellow.Size = new Size(82, 37);
            materialRadioButton_color_yellow.TabIndex = 41;
            materialRadioButton_color_yellow.TabStop = true;
            materialRadioButton_color_yellow.Text = "Yellow";
            materialRadioButton_color_yellow.UseVisualStyleBackColor = true;
            materialRadioButton_color_yellow.CheckedChanged += MaterialRadioButton_Color_Yellow_CheckedChanged;
            // 
            // materialRadioButton_color_pink
            // 
            materialRadioButton_color_pink.AutoSize = true;
            materialRadioButton_color_pink.Depth = 0;
            materialRadioButton_color_pink.Location = new Point(500, 108);
            materialRadioButton_color_pink.Margin = new Padding(0);
            materialRadioButton_color_pink.MouseLocation = new Point(-1, -1);
            materialRadioButton_color_pink.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton_color_pink.Name = "materialRadioButton_color_pink";
            materialRadioButton_color_pink.Ripple = true;
            materialRadioButton_color_pink.Size = new Size(66, 37);
            materialRadioButton_color_pink.TabIndex = 40;
            materialRadioButton_color_pink.TabStop = true;
            materialRadioButton_color_pink.Text = "Pink";
            materialRadioButton_color_pink.UseVisualStyleBackColor = true;
            materialRadioButton_color_pink.CheckedChanged += MaterialRadioButton_Color_Pink_CheckedChanged;
            // 
            // materialRadioButton_color_red
            // 
            materialRadioButton_color_red.AutoSize = true;
            materialRadioButton_color_red.Depth = 0;
            materialRadioButton_color_red.Location = new Point(405, 145);
            materialRadioButton_color_red.Margin = new Padding(0);
            materialRadioButton_color_red.MouseLocation = new Point(-1, -1);
            materialRadioButton_color_red.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton_color_red.Name = "materialRadioButton_color_red";
            materialRadioButton_color_red.Ripple = true;
            materialRadioButton_color_red.Size = new Size(62, 37);
            materialRadioButton_color_red.TabIndex = 39;
            materialRadioButton_color_red.TabStop = true;
            materialRadioButton_color_red.Text = "Red";
            materialRadioButton_color_red.UseVisualStyleBackColor = true;
            materialRadioButton_color_red.CheckedChanged += MaterialRadioButton_Color_Red_CheckedChanged;
            // 
            // materialRadioButton_color_amber
            // 
            materialRadioButton_color_amber.AutoSize = true;
            materialRadioButton_color_amber.Depth = 0;
            materialRadioButton_color_amber.Location = new Point(405, 108);
            materialRadioButton_color_amber.Margin = new Padding(0);
            materialRadioButton_color_amber.MouseLocation = new Point(-1, -1);
            materialRadioButton_color_amber.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton_color_amber.Name = "materialRadioButton_color_amber";
            materialRadioButton_color_amber.Ripple = true;
            materialRadioButton_color_amber.Size = new Size(81, 37);
            materialRadioButton_color_amber.TabIndex = 38;
            materialRadioButton_color_amber.TabStop = true;
            materialRadioButton_color_amber.Text = "Amber";
            materialRadioButton_color_amber.UseVisualStyleBackColor = true;
            materialRadioButton_color_amber.CheckedChanged += MaterialRadioButton_Color_Amber_CheckedChanged;
            // 
            // materialRadioButton_color_blue
            // 
            materialRadioButton_color_blue.AutoSize = true;
            materialRadioButton_color_blue.Depth = 0;
            materialRadioButton_color_blue.Location = new Point(312, 145);
            materialRadioButton_color_blue.Margin = new Padding(0);
            materialRadioButton_color_blue.MouseLocation = new Point(-1, -1);
            materialRadioButton_color_blue.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton_color_blue.Name = "materialRadioButton_color_blue";
            materialRadioButton_color_blue.Ripple = true;
            materialRadioButton_color_blue.Size = new Size(66, 37);
            materialRadioButton_color_blue.TabIndex = 37;
            materialRadioButton_color_blue.TabStop = true;
            materialRadioButton_color_blue.Text = "Blue";
            materialRadioButton_color_blue.UseVisualStyleBackColor = true;
            materialRadioButton_color_blue.CheckedChanged += MaterialRadioButton_Color_Blue_CheckedChanged;
            // 
            // materialRadioButton_color_green
            // 
            materialRadioButton_color_green.AutoSize = true;
            materialRadioButton_color_green.Depth = 0;
            materialRadioButton_color_green.Location = new Point(312, 108);
            materialRadioButton_color_green.Margin = new Padding(0);
            materialRadioButton_color_green.MouseLocation = new Point(-1, -1);
            materialRadioButton_color_green.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton_color_green.Name = "materialRadioButton_color_green";
            materialRadioButton_color_green.Ripple = true;
            materialRadioButton_color_green.Size = new Size(76, 37);
            materialRadioButton_color_green.TabIndex = 36;
            materialRadioButton_color_green.TabStop = true;
            materialRadioButton_color_green.Text = "Green";
            materialRadioButton_color_green.UseVisualStyleBackColor = true;
            materialRadioButton_color_green.CheckedChanged += MaterialRadioButton_Color_Green_CheckedChanged;
            // 
            // materialLabel_color_settings
            // 
            materialLabel_color_settings.AutoSize = true;
            materialLabel_color_settings.Depth = 0;
            materialLabel_color_settings.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel_color_settings.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel_color_settings.Location = new Point(324, 79);
            materialLabel_color_settings.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_color_settings.Name = "materialLabel_color_settings";
            materialLabel_color_settings.Size = new Size(38, 19);
            materialLabel_color_settings.TabIndex = 35;
            materialLabel_color_settings.Text = "Color";
            // 
            // materialLabel_theme_settings
            // 
            materialLabel_theme_settings.AutoSize = true;
            materialLabel_theme_settings.Depth = 0;
            materialLabel_theme_settings.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel_theme_settings.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel_theme_settings.Location = new Point(40, 80);
            materialLabel_theme_settings.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_theme_settings.Name = "materialLabel_theme_settings";
            materialLabel_theme_settings.Size = new Size(50, 19);
            materialLabel_theme_settings.TabIndex = 34;
            materialLabel_theme_settings.Text = "Theme";
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(299, 50);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(255, 3);
            materialDivider2.TabIndex = 33;
            materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(14, 50);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(255, 3);
            materialDivider1.TabIndex = 32;
            materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel_settings
            // 
            materialLabel_settings.AutoSize = true;
            materialLabel_settings.Depth = 0;
            materialLabel_settings.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_settings.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel_settings.Location = new Point(31, 14);
            materialLabel_settings.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_settings.Name = "materialLabel_settings";
            materialLabel_settings.Size = new Size(88, 29);
            materialLabel_settings.TabIndex = 31;
            materialLabel_settings.Text = "Settings";
            // 
            // materialSwitch_theme
            // 
            materialSwitch_theme.AutoSize = true;
            materialSwitch_theme.Depth = 0;
            materialSwitch_theme.Location = new Point(28, 109);
            materialSwitch_theme.Margin = new Padding(0);
            materialSwitch_theme.MouseLocation = new Point(-1, -1);
            materialSwitch_theme.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch_theme.Name = "materialSwitch_theme";
            materialSwitch_theme.Ripple = true;
            materialSwitch_theme.Size = new Size(142, 37);
            materialSwitch_theme.TabIndex = 30;
            materialSwitch_theme.Text = "Light / Dark";
            materialSwitch_theme.UseVisualStyleBackColor = true;
            materialSwitch_theme.CheckedChanged += MaterialSwitch_Theme_CheckedChanged;
            // 
            // materialLabel_link_lable
            // 
            materialLabel_link_lable.AutoSize = true;
            materialLabel_link_lable.Cursor = Cursors.Hand;
            materialLabel_link_lable.Depth = 0;
            materialLabel_link_lable.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel_link_lable.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel_link_lable.HighEmphasis = true;
            materialLabel_link_lable.Location = new Point(174, 69);
            materialLabel_link_lable.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel_link_lable.Name = "materialLabel_link_lable";
            materialLabel_link_lable.Size = new Size(164, 17);
            materialLabel_link_lable.TabIndex = 32;
            materialLabel_link_lable.Text = "Made by Hristijan Stavrov";
            materialLabel_link_lable.UseAccent = true;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel_clock_container);
            Controls.Add(panel_application_name_container);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "Homepage";
            Padding = new Padding(3);
            Sizable = false;
            Text = "Homepage";
            panel_application_name_container.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_application_logo).EndInit();
            panel_clock_container.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_application_name_container;
        private Panel panel_clock_container;
        private MaterialSkin.Controls.MaterialLabel label_Date;
        private MaterialSkin.Controls.MaterialLabel label_Time;
        private MaterialSkin.Controls.MaterialLabel label_heart;
        private MaterialSkin.Controls.MaterialLabel label_application_name;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel_settings;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch_theme;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel_color_settings;
        private MaterialSkin.Controls.MaterialLabel materialLabel_theme_settings;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton_color_green;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton_color_amber;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton_color_blue;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton_color_yellow;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton_color_pink;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton_color_red;
        private PictureBox pictureBox_application_logo;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Panel panel_clock;
        private MaterialSkin.Controls.MaterialLabel materialLabel_link_lable;
    }
}