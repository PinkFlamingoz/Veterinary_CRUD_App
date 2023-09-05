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
            label_Date = new Label();
            label_heart = new Label();
            label_application_name = new Label();
            iconPictureBox_application_logo = new FontAwesome.Sharp.IconPictureBox();
            panel_application_name_container = new Panel();
            panel_clock_container = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox_application_logo).BeginInit();
            panel_application_name_container.SuspendLayout();
            panel_clock_container.SuspendLayout();
            SuspendLayout();
            // 
            // label_Date
            // 
            label_Date.Anchor = AnchorStyles.None;
            label_Date.AutoSize = true;
            label_Date.Font = new Font("Cascadia Code", 33F, FontStyle.Regular, GraphicsUnit.Point);
            label_Date.ForeColor = Color.White;
            label_Date.Location = new Point(165, 78);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(363, 58);
            label_Date.TabIndex = 27;
            label_Date.Text = "MMMM dd, yyyy";
            label_Date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_heart
            // 
            label_heart.Anchor = AnchorStyles.None;
            label_heart.AutoSize = true;
            label_heart.BackColor = Color.Transparent;
            label_heart.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_heart.ForeColor = Color.IndianRed;
            label_heart.Location = new Point(510, 38);
            label_heart.Name = "label_heart";
            label_heart.Size = new Size(48, 32);
            label_heart.TabIndex = 25;
            label_heart.Text = "❤";
            label_heart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_application_name
            // 
            label_application_name.Anchor = AnchorStyles.None;
            label_application_name.AutoSize = true;
            label_application_name.Font = new Font("Cascadia Code", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label_application_name.Location = new Point(325, 32);
            label_application_name.Name = "label_application_name";
            label_application_name.Size = new Size(179, 40);
            label_application_name.TabIndex = 28;
            label_application_name.Text = "Cat A Log";
            // 
            // iconPictureBox_application_logo
            // 
            iconPictureBox_application_logo.Anchor = AnchorStyles.None;
            iconPictureBox_application_logo.BackColor = Color.Transparent;
            iconPictureBox_application_logo.ForeColor = SystemColors.ControlText;
            iconPictureBox_application_logo.IconChar = FontAwesome.Sharp.IconChar.ShieldCat;
            iconPictureBox_application_logo.IconColor = SystemColors.ControlText;
            iconPictureBox_application_logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox_application_logo.IconSize = 86;
            iconPictureBox_application_logo.Location = new Point(243, 11);
            iconPictureBox_application_logo.Name = "iconPictureBox_application_logo";
            iconPictureBox_application_logo.Size = new Size(106, 86);
            iconPictureBox_application_logo.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox_application_logo.TabIndex = 29;
            iconPictureBox_application_logo.TabStop = false;
            // 
            // panel_application_name_container
            // 
            panel_application_name_container.Controls.Add(label_heart);
            panel_application_name_container.Controls.Add(label_application_name);
            panel_application_name_container.Controls.Add(iconPictureBox_application_logo);
            panel_application_name_container.Dock = DockStyle.Top;
            panel_application_name_container.Location = new Point(0, 0);
            panel_application_name_container.Name = "panel_application_name_container";
            panel_application_name_container.Size = new Size(800, 100);
            panel_application_name_container.TabIndex = 30;
            // 
            // panel_clock_container
            // 
            panel_clock_container.Controls.Add(label_Date);
            panel_clock_container.Dock = DockStyle.Fill;
            panel_clock_container.Location = new Point(0, 100);
            panel_clock_container.Name = "panel_clock_container";
            panel_clock_container.Size = new Size(800, 380);
            panel_clock_container.TabIndex = 32;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 228, 140);
            ClientSize = new Size(800, 480);
            Controls.Add(panel_clock_container);
            Controls.Add(panel_application_name_container);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Homepage";
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox_application_logo).EndInit();
            panel_application_name_container.ResumeLayout(false);
            panel_application_name_container.PerformLayout();
            panel_clock_container.ResumeLayout(false);
            panel_clock_container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label_heart;
        private Label label_Date;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_application_logo;
        private Label label_application_name;
        private Panel panel_application_name_container;
        private Panel panel_clock_container;
    }
}