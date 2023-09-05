using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary_CRUD_App.Interfaces;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Views
{
    public partial class Main_View : MaterialForm, IMain_View_Interface
    {
        // Constants

        private const string GITHUB_URL = "https://github.com/PinkFlamingoz";
        private const int COLLAPSED_MENU_WIDTH = 100;
        private const int EXPANDED_MENU_WIDTH = 250;
        private const int COLLAPSED_LOGO_CONTAINER_HEIGHT = 72;
        private const int EXPANDED_LOGO_CONTAINER_HEIGHT = 144;

        // Variables

        // Keeping track of the current button
        private IconButton? current_button;

        private readonly Panel left_border_button;

        // Events

        public event EventHandler? Show_Pet_View;

        public event EventHandler? Show_Owner_View;

        public event EventHandler? Show_Visit_View;

        public event EventHandler? Show_Homepage_View;

        public event EventHandler? Toggle_Menu_Event;

        // Constructor
        public Main_View()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            Subscribe_Button_Clicks_To_Invoking_Calls();
            left_border_button = new Panel
            {
                Size = new Size(7, 55)
            };
            panel_main_view.Controls.Add(left_border_button);
            this.DoubleBuffered = true;
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events

        protected virtual void Subscribe_Button_Clicks_To_Invoking_Calls()
        {
            button_main_view_pets.Click += Button_Main_View_Pet_Click;
            button_main_view_owners.Click += Button_Main_View_Owner_Click;
            button_main_view_visits.Click += Button_Main_View_Visit_Click;
            iconButton_home_page.Click += Button_Main_View_Homepage_Click;
            iconButton_toggle_menu.Click += Button_Main_View_Toggle_Menu_Click;
            iconButton_home.Click += Button_Main_View_Homepage_Click;
            iconButton_exit.Click += Button_Main_View_Exit_Click;
            FormClosed += Main_View_FormClosed;
        }

        // Unsubscribe buttons from events
        protected virtual void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            button_main_view_pets.Click -= Button_Main_View_Pet_Click;
            button_main_view_owners.Click -= Button_Main_View_Owner_Click;
            button_main_view_visits.Click -= Button_Main_View_Visit_Click;
            iconButton_home_page.Click -= Button_Main_View_Homepage_Click;
            iconButton_toggle_menu.Click -= Button_Main_View_Toggle_Menu_Click;
            iconButton_home.Click -= Button_Main_View_Homepage_Click;
            iconButton_exit.Click -= Button_Main_View_Exit_Click;
            FormClosed -= Main_View_FormClosed;
        }

        // Unsubscribe from events by overriding the Dispose function
        private void Main_View_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Unsubscribe from events
            Unsubscribe_Button_Clicks_To_Invoking_Calls();
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Button to open the pet view
        private void Button_Main_View_Pet_Click(object? sender, EventArgs e)
        {
            Activate_Button(sender, RGB_Colors.Color_1, "Pets");
            Show_Pet_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the visit view
        private void Button_Main_View_Visit_Click(object? sender, EventArgs e)
        {
            Activate_Button(sender, RGB_Colors.Color_2, "Visits");
            Show_Visit_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the owner view
        private void Button_Main_View_Owner_Click(object? sender, EventArgs e)
        {
            Activate_Button(sender, RGB_Colors.Color_3, "Owners");
            Show_Owner_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the homepage
        private void Button_Main_View_Homepage_Click(object? sender, EventArgs e)
        {
            Reset_Button();

            Show_Homepage_View?.Invoke(this, EventArgs.Empty);
        }

        private void Button_Main_View_Toggle_Menu_Click(object? sender, EventArgs e)
        {
            Toggle_Menu();
        }

        private void Button_Main_View_Exit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event functions ---------------------------------------------------------------------------------------------------

        // UI manipulation functions -----------------------------------------------------------------------------------------

        // On opening a form close the other forms
        public void Close_All_Forms_Except(Type exclude)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() != exclude)
                {
                    form.Hide();
                }
            }
        }

        private void Set_Button_Style_For_Expanded_Menu(IconButton button)
        {
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.TextImageRelation = TextImageRelation.TextBeforeImage;
            button.ImageAlign = ContentAlignment.MiddleRight;
            button.Text = button.Tag.ToString();
            button.Padding = new Padding(10, 0, 50, 0);
        }

        private void Set_Button_Style_Disabled_For_Expanded_Menu(IconButton button)
        {
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Text = button.Tag.ToString();
            button.Padding = new Padding(10, 0, 50, 0);
        }

        private void Set_Button_Style_For_Collapsed_Menu(IconButton button)
        {
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.Text = "";
            button.Padding = new Padding(0);
        }

        // Disable a button
        private void Disable_Button()
        {
            if (current_button != null)
            {
                current_button.BackColor = RGB_Colors.Main_background_color;
                current_button.ForeColor = Color.White;
                current_button.IconColor = Color.White;

                if (panel_main_view.Width > COLLAPSED_MENU_WIDTH)
                {
                    Set_Button_Style_Disabled_For_Expanded_Menu(current_button);
                }
                else
                {
                    Set_Button_Style_For_Collapsed_Menu(current_button);
                }
            }
        }

        // Active button
        private void Activate_Button(object? sender, Color color, string title = "")
        {
            if (sender is IconButton button)
            {
                Disable_Button();

                // Button
                current_button = button;
                current_button.BackColor = RGB_Colors.Main_background_color_highlight;
                current_button.ForeColor = color;
                current_button.IconColor = color;

                // Adjust button properties based on menu width
                if (panel_main_view.Width > COLLAPSED_MENU_WIDTH)
                {
                    Set_Button_Style_For_Expanded_Menu(current_button);
                }
                else
                {
                    Set_Button_Style_For_Collapsed_Menu(current_button);
                }

                // Left border button
                left_border_button.BackColor = color;
                left_border_button.Location = new Point(0, current_button.Location.Y);
                left_border_button.Visible = true;
                left_border_button.BringToFront();

                // Current Child Form Icon
                iconPictureBox_current_child_form_icon.IconChar = current_button.IconChar;
                iconPictureBox_current_child_form_icon.IconColor = color;

                // Title
                label_current_child_form_name.Text = title;
            }
        }

        // Reset the button
        private void Reset_Button()
        {
            Disable_Button();
            left_border_button.Visible = false;
            iconPictureBox_current_child_form_icon.IconChar = IconChar.Home;
            iconPictureBox_current_child_form_icon.IconColor = Color.White;
            label_current_child_form_name.Text = "Home";
        }

        private void Expand_Menu()
        {
            panel_main_view.Width = EXPANDED_MENU_WIDTH;
            iconButton_home_page.Visible = true;
            panel_greet_container.Visible = true;
            iconButton_toggle_menu.Dock = DockStyle.None;
            panel_logo_container.Height = EXPANDED_LOGO_CONTAINER_HEIGHT;
            iconButton_home.Visible = false;

            foreach (IconButton menu_button in panel_main_view.Controls.OfType<IconButton>())
            {
                // Don't change the appearance of the current_button
                if (menu_button != current_button)
                {
                    Set_Button_Style_Disabled_For_Expanded_Menu(menu_button);
                }
                else
                {
                    Set_Button_Style_For_Expanded_Menu(menu_button);
                }
            }

            if (current_button != null)
            {
                left_border_button.Location = new Point(0, current_button.Location.Y);
            }
        }

        private void Collapse_Menu()
        {
            panel_main_view.Width = COLLAPSED_MENU_WIDTH;
            iconButton_home_page.Visible = false;
            panel_greet_container.Visible = false;
            iconButton_toggle_menu.Dock = DockStyle.Fill;
            panel_logo_container.Height = COLLAPSED_LOGO_CONTAINER_HEIGHT;
            iconButton_home.Visible = true;

            foreach (IconButton menu_button in panel_main_view.Controls.OfType<IconButton>())
            {
                Set_Button_Style_For_Collapsed_Menu(menu_button);
            }

            if (current_button != null)
            {
                left_border_button.Location = new Point(0, current_button.Location.Y + current_button.Height / 2 - left_border_button.Height / 2);
            }
        }

        // Toggle the menu
        private void Toggle_Menu()
        {
            if (panel_main_view.Width > COLLAPSED_MENU_WIDTH) //Collapse menu
            {
                Collapse_Menu();
            }
            else //Expand menu
            {
                Expand_Menu();
            }
        }

        // Link myself
        private void LinkLabel_Me_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new()
                {
                    FileName = GITHUB_URL,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // UI manipulation functions -----------------------------------------------------------------------------------------
    }
}