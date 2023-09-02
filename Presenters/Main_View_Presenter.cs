using Microsoft.Extensions.Configuration;
using System.Reflection;
using Veterinary_CRUD_App.Interfaces;
using Veterinary_CRUD_App.Interfaces.Owner;
using Veterinary_CRUD_App.Interfaces.Pets;
using Veterinary_CRUD_App.Interfaces.Visits;
using Veterinary_CRUD_App.Presenters.Common;
using Veterinary_CRUD_App.Views;
using static Veterinary_CRUD_App.Program;

namespace Veterinary_CRUD_App.Presenters
{
    internal class Main_View_Presenter
    {
        // Common values

        private readonly Dictionary<Type, Form> form_cashe = new();
        private readonly Dictionary<Type, object> repository_cashe = new();
        private readonly Dictionary<Type, object> presenter_cashe = new();

        private readonly IMain_View_Interface main_view_interface;
        private readonly IConfiguration configuration;

        private readonly Main_View main_view_instance;

        // Constructor
        public Main_View_Presenter(IMain_View_Interface main_view_interface, IConfiguration configuration)
        {
            this.main_view_interface = main_view_interface;
            this.configuration = configuration;
            this.main_view_instance = main_view_interface as Main_View ?? throw new InvalidOperationException("The provided view is not of type Main_View");

            Subscribe_Events_To_Functions();
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events
        private void Subscribe_Events_To_Functions()
        {
            main_view_interface.Show_Pet_View += Show_Pet_View;
            main_view_interface.Show_Owner_View += Show_Owner_View;
            main_view_interface.Show_Visit_View += Show_Visit_View;
            Event_Aggregator.Instance.Request_Open_Form += Open_Specific_Form_With_Id;

            if (main_view_interface is Form form_view)
            {
                form_view.FormClosed += On_Form_Closed;
            }
        }

        // Unsubscribe buttons from events
        private void Unsubscribe_Events_To_Functions()
        {
            main_view_interface.Show_Pet_View -= Show_Pet_View;
            main_view_interface.Show_Owner_View -= Show_Owner_View;
            main_view_interface.Show_Visit_View -= Show_Visit_View;
            Event_Aggregator.Instance.Request_Open_Form -= Open_Specific_Form_With_Id;

            if (main_view_interface is Form form_view)
            {
                form_view.FormClosed -= On_Form_Closed;
            }
        }

        // On form Close unsubscribe the events
        private void On_Form_Closed(object? sender, FormClosedEventArgs e)
        {
            Unsubscribe_Events_To_Functions();
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Standard open form ------------------------------------------------------------------------------------------------

        // Helper functions for opening a form --------------------

        // Get the instance of a form
        // This function's primary goal is to fetch or create an instance of a specified form and configure its appearance and behavior in the context of the parent container (like an MDI parent).
        // The sequence of operations is as follows:
        // Fetch or create the form instance using Get_Or_Create_Form function.
        // Set the form's MDI parent.
        // Change the form's border style to "None" for seamless embedding.
        // Set the form to fill its parent container.
        // If the form was minimized, it's restored to its normal state.
        // The form is brought to the forefront of other forms.
        // Lastly, the form is displayed.
        private Form Get_Form_Instance(Type Form_Type, Form Parent_Container)
        {
            var form_instance = Get_Or_Create_Form(Form_Type);

            form_instance.MdiParent = Parent_Container;
            form_instance.FormBorderStyle = FormBorderStyle.None;
            form_instance.Dock = DockStyle.Fill;

            if (form_instance.WindowState == FormWindowState.Minimized)
            {
                form_instance.WindowState = FormWindowState.Normal;
            }

            form_instance.BringToFront();
            form_instance.Show();

            return form_instance;
        }

        // Retrieves a form instance from cache or creates a new one if it doesn't exist
        private Form Get_Or_Create_Form(Type Form_Type)
        {
            if (!form_cashe.ContainsKey(Form_Type))
            {
                if (Activator.CreateInstance(Form_Type) is not Form instance)
                {
                    throw new InvalidOperationException($"Failed to create an instance of {Form_Type.Name} or it's not of type Form.");
                }

                form_cashe[Form_Type] = instance;
            }
            return form_cashe[Form_Type];
        }

        // Retrieves a repository instance from cache or fetches a new one using the service locator
        private object Get_Or_Create_Repository(Type Repository_Interface_Type)
        {
            if (!repository_cashe.ContainsKey(Repository_Interface_Type))
            {
                repository_cashe[Repository_Interface_Type] = Service_Locator.Get_Service(Repository_Interface_Type) ?? throw new InvalidOperationException("Repository could not be located."); ;
            }
            return repository_cashe[Repository_Interface_Type];
        }

        // Retrieves a presenter instance from cache or creates a new one dynamically
        private object Get_Or_Create_Presenter(Form Form_Type, Type Presenter_Type, object Repository_Interface_Type)
        {
            if (!presenter_cashe.ContainsKey(Presenter_Type))
            {
                presenter_cashe[Presenter_Type] = Presenter_Type.GetConstructors().First().Invoke(new object[] { Form_Type, Repository_Interface_Type });
            }
            return presenter_cashe[Presenter_Type];
        }

        // Helper functions for opening a form --------------------

        // Main method to show a form
        // All open forms are closed except the one being opened.
        // A form instance is fetched or created.
        // A repository instance is fetched or created.
        // A presenter instance is fetched or created, linking the form and repository.
        // Any exception during these operations is logged to the console.
        private object? Show_Form(Type Form_Type, Type Repository_Interface_Type, Type Presenter_Type)
        {
            object? presenter = null;

            main_view_instance.Close_All_Forms_Except(Form_Type);

            var form_instance = Get_Form_Instance(Form_Type, main_view_instance);

            try
            {
                // Get the repository instance using DI
                var repository = Get_Or_Create_Repository(Repository_Interface_Type) ?? throw new InvalidOperationException($"Failed to get an instance of {Repository_Interface_Type.Name}");

                // Create the presenter using DI
                presenter = Get_Or_Create_Presenter(form_instance, Presenter_Type, repository) ?? throw new InvalidOperationException($"Failed to create an instance of {Presenter_Type.Name}");
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine($"Error while creating instances: {ex.Message}");
            }

            return presenter;
        }

        // Open the pet view
        private void Show_Pet_View(object? sender, EventArgs e)
        {
            Show_Form(typeof(Pet_Form), typeof(IPet_Repository_Interface), typeof(Pet_Form_Presenter));
        }

        // Open the owner view
        private void Show_Owner_View(object? sender, EventArgs e)
        {
            Show_Form(typeof(Owner_Form), typeof(IOwner_Repository_Interface), typeof(Owner_Form_Presenter));
        }

        // Open the visit view
        private void Show_Visit_View(object? sender, EventArgs e)
        {
            Show_Form(typeof(Visit_Form), typeof(IVisit_Repository_Interface), typeof(Visit_Form_Presenter));
        }

        // Standard open form ------------------------------------------------------------------------------------------------

        // Open a specific form
        // The method first uses Show_Form to initialize and display the form.
        // It then uses reflection to locate the method Load_Data_By_Id on the presenter.
        // If the method is found, it's invoked with the provided ID, allowing the form to load specific data based on this ID.
        private void Open_Specific_Form_With_Id(object? sender, Form_Open_Request_Event_Args e)
        {
            var presenter = Show_Form(e.Form_Type, e.Repository_Type, e.Presenter_Type) ?? throw new InvalidOperationException("Failed to create an instance of presenter");

            // Look up the Load_Data_By_Id method with reflection
            MethodInfo? load_method = presenter.GetType().GetMethod("Load_Data_By_Id", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(int?) }, null);

            // Invoke the method even if e.Id is null
            load_method?.Invoke(presenter, new object[] { e.Id });
        }
    }
}