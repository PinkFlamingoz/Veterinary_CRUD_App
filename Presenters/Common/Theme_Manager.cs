using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.Linq;

namespace Veterinary_CRUD_App.Presenters.Common
{
    public class Theme_Manager
    {
        public static MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;

        static Theme_Manager()
        {
            material_skin_manager.Theme = MaterialSkinManager.Themes.LIGHT;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public static void Apply_Theme_To_Form(MaterialForm form)
        {
            material_skin_manager.AddFormToManage(form);
            form.Refresh();
        }

        public static void Update_Theme(MaterialSkinManager.Themes theme)
        {
            material_skin_manager.Theme = theme;
            Refresh_All_Managed_Forms();
        }

        public static void Update_Color_Scheme(ColorScheme scheme)
        {
            material_skin_manager.ColorScheme = scheme;
            Refresh_All_Managed_Forms();
        }

        public static void Refresh_All_Managed_Forms()
        {
            var main_form = Application.OpenForms.Cast<Form>().FirstOrDefault();
            if (main_form == null) return;

            if (main_form.InvokeRequired)
            {
                main_form.Invoke((MethodInvoker)delegate
                {
                    Internal_Refresh_All_Managed_Forms();
                });
            }
            else
            {
                Internal_Refresh_All_Managed_Forms();
            }
        }

        private static void Internal_Refresh_All_Managed_Forms()
        {
            foreach (var form in Application.OpenForms.OfType<MaterialForm>())
            {
                form.Invalidate(true);
                form.Refresh();
            }
        }
    }
}