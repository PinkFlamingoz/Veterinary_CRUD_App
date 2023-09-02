using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary_CRUD_App.Interfaces;

namespace Veterinary_CRUD_App.Views
{
    internal partial class Main_View : Form, IMain_View_Interface
    {
        // Events

        public event EventHandler? Show_Pet_View;

        public event EventHandler? Show_Owner_View;

        public event EventHandler? Show_Visit_View;

        // Constructor
        public Main_View()
        {
            InitializeComponent();
            Subscribe_Button_Clicks_To_Invoking_Calls();
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events

        protected virtual void Subscribe_Button_Clicks_To_Invoking_Calls()
        {
            button_main_view_pets.Click += Button_Main_View_Pet_Click;
            button_main_view_owners.Click += Button_Main_View_Owner_Click;
            button_main_view_visits.Click += Button_Main_View_Visit_Click;
            FormClosed += Main_View_FormClosed;
        }

        // Unsubscribe buttons from events
        protected virtual void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            button_main_view_pets.Click -= Button_Main_View_Pet_Click;
            button_main_view_owners.Click -= Button_Main_View_Owner_Click;
            button_main_view_visits.Click -= Button_Main_View_Visit_Click;
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
            Show_Pet_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the owner view
        private void Button_Main_View_Owner_Click(object? sender, EventArgs e)
        {
            Show_Owner_View?.Invoke(this, EventArgs.Empty);
        }

        // Button to open the visit view
        private void Button_Main_View_Visit_Click(object? sender, EventArgs e)
        {
            Show_Visit_View?.Invoke(this, EventArgs.Empty);
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
    }
}