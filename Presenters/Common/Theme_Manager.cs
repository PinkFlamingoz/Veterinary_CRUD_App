using MaterialSkin;
using MaterialSkin.Controls;

namespace Veterinary_CRUD_App.Presenters.Common
{
    public class Theme_Manager
    {
        // Declare a public static event that other parts of the application can subscribe to.
        // This event will be raised when the theme or color changes.
        public static event Action? Theme_Or_Color_Change;

        // Create a private static readonly instance of Material Skin Manager.
        // Material Skin Manager is responsible for managing themes and colors in Material Skin.
        private static readonly MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;

        // Static constructor of Theme_Manager class. This will run once when this class is first accessed.
        static Theme_Manager()
        {
            // Setting the theme to LIGHT by default.
            material_skin_manager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Setting a default color scheme for the theme.
            material_skin_manager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue200, TextShade.WHITE);
        }

        // Method to apply the theme to any Material Form passed to it.
        public static void Apply_Theme_To_Form(MaterialForm form)
        {
            // Add the given form to the list of managed forms.
            material_skin_manager.AddFormToManage(form);

            // Refresh the form to apply changes.
            form.Refresh();
        }

        // Update the current theme to either LIGHT or DARK.
        public static void Update_Theme(MaterialSkinManager.Themes theme)
        {
            // Set the theme.
            material_skin_manager.Theme = theme;

            // Refresh all managed forms to reflect the new theme.
            Refresh_All_Managed_Forms();

            // Raise the Theme_Or_Color_Change event to notify subscribers about the change.
            Theme_Or_Color_Change?.Invoke();
        }

        // Update the current color scheme of the theme.
        public static void Update_Color_Scheme(ColorScheme scheme)
        {
            // Set the color scheme.
            material_skin_manager.ColorScheme = scheme;

            // Refresh all managed forms to reflect the new color scheme.
            Refresh_All_Managed_Forms();

            // Raise the Theme_Or_Color_Change event to notify subscribers about the change.
            Theme_Or_Color_Change?.Invoke();
        }

        // Helper method to refresh all managed forms.
        private static void Refresh_All_Managed_Forms()
        {
            // Get the main form of the application.
            var main_form = Application.OpenForms.Cast<Form>().FirstOrDefault();

            // If no main form is found, exit the method.
            if (main_form == null) return;

            // Check if the current thread has access to the main form.
            if (main_form.InvokeRequired)
            {
                // If it doesn't have access, use the Invoke method to run the refresh on the main form's thread.
                main_form.Invoke((MethodInvoker)delegate
                {
                    Internal_Refresh_All_Managed_Forms();
                });
            }
            else
            {
                // If the current thread has access, directly call the method.
                Internal_Refresh_All_Managed_Forms();
            }
        }

        // Internal method to refresh all managed forms.
        private static void Internal_Refresh_All_Managed_Forms()
        {
            // Loop through each Material Form in the application's open forms.
            foreach (var form in Application.OpenForms.OfType<MaterialForm>())
            {
                // Invalidate and refresh each form to apply changes.
                form.Invalidate(true);
                form.Refresh();
            }
        }
    }
}