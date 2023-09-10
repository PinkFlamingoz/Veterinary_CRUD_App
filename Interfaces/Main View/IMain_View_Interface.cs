using MaterialSkin.Controls;

namespace Veterinary_CRUD_App.Interfaces
{
    // The 'IMain_View_Interface' represents a contract for the main view's interface.
    // This main view is the starting or central interface of the application from where users can navigate to different sections such as pets, owners, or visits.
    internal interface IMain_View_Interface
    {
        // EVENT DECLARATIONS:

        // This event is triggered when the user wants to navigate to the Pet view.
        // It will alert any listeners (args.g., a presenter or controller) that the user has chosen to interact with or view the Pet section.
        event EventHandler? Show_Pet_View;

        // This event is triggered when the user wants to navigate to the Owner view.
        // It will alert any listeners (args.g., a presenter or controller) that the user has chosen to interact with or view the Owner section.
        event EventHandler? Show_Owner_View;

        // This event is triggered when the user wants to navigate to the Visit view.
        // It will alert any listeners (args.g., a presenter or controller) that the user has chosen to interact with or view the Visit section.
        event EventHandler? Show_Visit_View;

        // This event is triggered when the user wants to navigate to the Homepage view.
        // It will alert any listeners (args.g., a presenter or controller) that the user has chosen to interact with or view the Homepage section.
        event EventHandler? Show_Homepage_View;

        // Represents a dictionary to keep track of what page tab to open in the main menu
        Dictionary<Type, string> Form_To_Tab_Map { get; }

        // Represents a access point to the Tab Control so we can access it in the presenter
        MaterialTabControl Material_Tab_Control_Menu { get; }

        // Represents a access point to the Tab Control so we can access it in the presenter
        void Selected_Index_Changed(object? sender, EventArgs e);
    }
}