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
            button_main_view_owners = new Button();
            button_main_view_visits = new Button();
            button_main_view_pets = new Button();
            panel_main_view.SuspendLayout();
            SuspendLayout();
            // 
            // panel_main_view
            // 
            panel_main_view.Controls.Add(button_main_view_owners);
            panel_main_view.Controls.Add(button_main_view_visits);
            panel_main_view.Controls.Add(button_main_view_pets);
            panel_main_view.Dock = DockStyle.Left;
            panel_main_view.Location = new Point(0, 0);
            panel_main_view.Name = "panel_main_view";
            panel_main_view.Size = new Size(200, 765);
            panel_main_view.TabIndex = 0;
            // 
            // button_main_view_owners
            // 
            button_main_view_owners.Location = new Point(55, 283);
            button_main_view_owners.Name = "button_main_view_owners";
            button_main_view_owners.Size = new Size(75, 23);
            button_main_view_owners.TabIndex = 2;
            button_main_view_owners.Text = "Owners";
            button_main_view_owners.UseVisualStyleBackColor = true;
            // 
            // button_main_view_visits
            // 
            button_main_view_visits.Location = new Point(55, 254);
            button_main_view_visits.Name = "button_main_view_visits";
            button_main_view_visits.Size = new Size(75, 23);
            button_main_view_visits.TabIndex = 1;
            button_main_view_visits.Text = "Visits";
            button_main_view_visits.UseVisualStyleBackColor = true;
            // 
            // button_main_view_pets
            // 
            button_main_view_pets.Location = new Point(55, 225);
            button_main_view_pets.Name = "button_main_view_pets";
            button_main_view_pets.Size = new Size(75, 23);
            button_main_view_pets.TabIndex = 0;
            button_main_view_pets.Text = "Pets";
            button_main_view_pets.UseVisualStyleBackColor = true;
            // 
            // Main_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 765);
            Controls.Add(panel_main_view);
            IsMdiContainer = true;
            Name = "Main_View";
            Text = "Main_View";
            panel_main_view.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main_view;
        private Button button_main_view_visits;
        private Button button_main_view_owners;
        private Button button_main_view_pets;
    }
}