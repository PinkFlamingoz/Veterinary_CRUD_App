using Microsoft.Extensions.DependencyInjection;
using Veterinary_CRUD_App.Interfaces;
using Veterinary_CRUD_App.Interfaces.Owner;
using Veterinary_CRUD_App.Interfaces.Pets;
using Veterinary_CRUD_App.Interfaces.Visits;
using Veterinary_CRUD_App.Presenters;
using Veterinary_CRUD_App.Presenters.Common;
using Veterinary_CRUD_App.Repository;
using Veterinary_CRUD_App.Views;

namespace Veterinary_CRUD_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Initialization logic for the application's configuration.
            ApplicationConfiguration.Initialize();

            // Setup the Dependency Injection container by registering all required services.
            Configure_Services();

            try
            {
                // Starting the main loop of the application.
                Start_Application();
            }
            catch (Exception ex)
            {
                // In case of any unhandled exceptions, show a message box with the error.
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Start the application
        private static void Start_Application()
        {
            // Get the main view of the application from the Service Locator.
            IMain_View_Interface main_view = Service_Locator.Get_Service<IMain_View_Interface>() ?? throw new InvalidOperationException("Main view could not be located.");

            // Retrieving the Main_View_Presenter. Initialization of main view.
            Service_Locator.Get_Service<Main_View_Presenter>();

            // Starting the Windows Forms application with the retrieved main view.
            Application.Run((Form)main_view);
        }

        // Configure the services that we will need
        private static void Configure_Services()
        {
            // Creating a new Service Collection - the builder for our DI container.
            var services = new ServiceCollection();

            // Registering WinForms forms as singletons, ensuring only one instance of each exists during the app life cycle.
            services.AddSingleton<Pet_Form>();
            services.AddSingleton<Owner_Form>();
            services.AddSingleton<Visit_Form>();

            // Registering repositories. This allows the application to switch data storage strategies without changing the rest of the app.
            services.AddSingleton<IPet_Repository_Interface, Pet_Repository>();
            services.AddSingleton<IOwner_Repository_Interface, Owner_Repository>();
            services.AddSingleton<IVisit_Repository_Interface, Visit_Repository>();

            // Registering presenters. Presenters are part of the MVP pattern and handle the logic of updating the view and model.
            services.AddSingleton<Pet_Form_Presenter>();
            services.AddSingleton<Owner_Form_Presenter>();
            services.AddSingleton<Visit_Form_Presenter>();

            // Register the Main_View_Presenter
            services.AddSingleton<Main_View_Presenter>();

            // Register other services
            services.AddSingleton<IMain_View_Interface, Main_View>();
            services.AddSingleton(Utilities.Get_Configuration());

            // Build the DI container and set the service provider in the Service_Locator.
            Service_Locator.Set_Service_Provider(services.BuildServiceProvider());
        }
    }
}