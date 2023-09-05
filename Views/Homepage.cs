using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Veterinary_CRUD_App.Views
{
    public partial class Homepage : Form
    {
        // Variables

        private Timer? clock_timer;

        // Constructor
        public Homepage()
        {
            InitializeComponent();
            Initialize_Clock();
            Subscribe_Button_Clicks_To_Invoking_Calls();
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events

        protected virtual void Subscribe_Button_Clicks_To_Invoking_Calls()
        {
            FormClosed += Homepage_View_FormClosed;
        }

        // Unsubscribe buttons from events
        protected virtual void Unsubscribe_Button_Clicks_To_Invoking_Calls()
        {
            clock_timer?.Dispose();
            FormClosed -= Homepage_View_FormClosed;
        }

        // Unsubscribe from events by overriding the Dispose function
        private void Homepage_View_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Unsubscribe from events
            Unsubscribe_Button_Clicks_To_Invoking_Calls();
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Initialize the clock
        private void Initialize_Clock()
        {
            clock_timer = new Timer
            {
                Interval = 1000 // Update every second
            };

            clock_timer.Tick += Clock_Timer_Tick;
            clock_timer.Start();
            Update_Clock(); // Initial update
        }

        // On every tick update the clock label
        private void Clock_Timer_Tick(object? sender, EventArgs e)
        {
            Update_Clock();
        }

        // Update the text label
        private void Update_Clock()
        {
            label_Date.Text = DateTime.Now.ToString("HH:mm:ss\nMMMM dd, yyyy");
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}