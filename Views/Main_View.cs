using MaterialSkin.Controls;
using Veterinary_CRUD_App.Interfaces;
using Veterinary_CRUD_App.Presenters.Common;

namespace Veterinary_CRUD_App.Views
{
    public partial class Main_View : MaterialForm, IMain_View_Interface
    {
        // Variables

        public Dictionary<Type, string> Form_To_Tab_Map { get; } = new()
        {
            { typeof(Homepage), nameof(tabPage_home) },
            { typeof(Pet_Form), nameof(tabPage_pets) },
            { typeof(Visit_Form), nameof(tabPage_visits) },
            { typeof(Owner_Form), nameof(tabPage_owners) },
        };

        public MaterialTabControl Material_Tab_Control_Menu => materialTabControl_menu;

        // Events

        public event EventHandler? Show_Pet_View;

        public event EventHandler? Show_Owner_View;

        public event EventHandler? Show_Visit_View;

        public event EventHandler? Show_Homepage_View;

        // Constructor
        public Main_View()
        {
            InitializeComponent();
            Subscribe_Button_Clicks_To_Invoking_Calls();
            Utilities.Set_Double_Buffered_Recursively(this, true);
            Theme_Manager.Apply_Theme_To_Form(this);
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events

        protected virtual void Subscribe_Button_Clicks_To_Invoking_Calls()
        {
            materialTabControl_menu.SelectedIndexChanged += Selected_Index_Changed;
            FormClosed += Main_View_Form_Closed;
        }

        // Unsubscribe buttons from events
        protected virtual void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            materialTabControl_menu.SelectedIndexChanged -= Selected_Index_Changed;
            FormClosed -= Main_View_Form_Closed;
        }

        private void Selected_Index_Changed(object? sender, EventArgs e)
        {
            switch (materialTabControl_menu.SelectedTab.Name)
            {
                case nameof(tabPage_home):
                    Button_Main_View_Homepage_Click(sender, e);
                    break;

                case nameof(tabPage_pets):
                    Button_Main_View_Pet_Click(sender, e);
                    break;

                case nameof(tabPage_visits):
                    Button_Main_View_Visit_Click(sender, e);
                    break;

                case nameof(tabPage_owners):
                    Button_Main_View_Owner_Click(sender, e);
                    break;

                case nameof(tabPage_exit):
                    Button_Main_View_Exit_Click(sender, e);
                    break;

                default:
                    Button_Main_View_Homepage_Click(sender, e);
                    break;
            }
        }

        // Unsubscribe from events by overriding the Dispose function
        private void Main_View_Form_Closed(object? sender, FormClosedEventArgs e)
        {
            // Unsubscribe from events
            Unsubscribe_Button_Clicks_To_Invoking_Calls();
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Event functions ---------------------------------------------------------------------------------------------------

        // Button to open the pet view
        private void Button_Main_View_Pet_Click(object? sender, EventArgs e)
        {
            Show_Pet_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the visit view
        private void Button_Main_View_Visit_Click(object? sender, EventArgs e)
        {
            Show_Visit_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the owner view
        private void Button_Main_View_Owner_Click(object? sender, EventArgs e)
        {
            Show_Owner_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the homepage
        private void Button_Main_View_Homepage_Click(object? sender, EventArgs e)
        {
            Show_Homepage_View?.Invoke(this, EventArgs.Empty);
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

        // UI manipulation functions -----------------------------------------------------------------------------------------

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}