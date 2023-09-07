using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Reflection;
using Veterinary_CRUD_App.Presenters.Common;
using Timer = System.Windows.Forms.Timer;

namespace Veterinary_CRUD_App.Views
{
    public partial class Homepage : MaterialForm
    {
        // Variables

        private Timer? clock_timer;
        private readonly Point clock_center;
        private const int clock_radius = 150;
        private readonly double half_of_pi = Math.PI / 2;
        private readonly double pi_over_six = Math.PI / 6;
        private const int clock_number_offset = 20;
        private const int date_offset = 40;
        private const double hand_angle_offset = 90.0;
        private Bitmap? clock_face_cache;
        private readonly MaterialSkinManager sking_manager;
        private readonly Font font_numbers;
        private readonly Font font_date;
        private DateTime? last_displayed_date = null;

        // Constructor
        public Homepage()
        {
            InitializeComponent();
            Initialize_Clock();

            Theme_Manager.Apply_Theme_To_Form(this);

            Subscribe_Controls();

            Set_Double_Buffered(panel_clock, true);

            sking_manager = MaterialSkinManager.Instance;
            font_numbers = sking_manager.getFontByType(MaterialSkinManager.fontType.H5);
            font_date = sking_manager.getFontByType(MaterialSkinManager.fontType.H6);
            clock_center = new Point(panel_clock.Width / 2, panel_clock.Height / 2);
        }

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // Set double buffered so the control does not flicker
        private static void Set_Double_Buffered(Control control, bool value)
        {
            var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop?.SetValue(control, value, null);
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // Subscribe buttons to events

        protected virtual void Subscribe_Controls()
        {
            panel_clock.Paint += Panel_Clock_Paint;
            FormClosed += Homepage_View_FormClosed;
        }

        // Unsubscribe buttons from events
        protected virtual void Unsubscribe_Controls()
        {
            clock_timer?.Dispose();
            clock_face_cache?.Dispose();
            font_numbers?.Dispose();
            font_date?.Dispose();
            panel_clock.Paint -= Panel_Clock_Paint;
            FormClosed -= Homepage_View_FormClosed;
        }

        // Unsubscribe from events by overriding the Dispose function
        private void Homepage_View_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Unsubscribe from events
            Unsubscribe_Controls();
        }

        // Events subscriptions ----------------------------------------------------------------------------------------------

        // CLOCK -------------------------------------------------------------------------------------------------------------

        // Initialize the clock
        // This function sets up a timer(clock_timer) that ticks every second(1000 milliseconds).
        // An event handler (Clock_Timer_Tick) is associated with this timer, which gets triggered on every tick.
        // The timer starts right away upon initialization.
        private void Initialize_Clock()
        {
            clock_timer = new Timer
            {
                Interval = 1000 // Update every second
            };

            clock_timer.Tick += Clock_Timer_Tick;
            clock_timer.Start();
        }

        // On every tick update the clock and if a new date comes and the application is still running update that date
        // This function is the event handler for the clock's timer.
        // It checks if the current date has changed from the last displayed date.
        // If there's a new date (or no date has been displayed yet), it will invalidate the clock's cached image (a saved snapshot of the clock's current state), recreate it, and then request the clock panel to repaint itself.
        private void Clock_Timer_Tick(object? sender, EventArgs e)
        {
            if (!last_displayed_date.HasValue || DateTime.Now.Date != last_displayed_date.Value.Date)
            {
                last_displayed_date = DateTime.Now.Date;
                Invalidate_Clock_Face_Cache();
                Create_Clock_Face_Cache();
            }
            panel_clock.Invalidate();
        }

        // Invalidate the clock cache so we can redraw the clock
        // It disposes of the current clock face cache image and sets its reference to null.
        // This means that the saved snapshot of the clock's current state is cleared.
        private void Invalidate_Clock_Face_Cache()
        {
            clock_face_cache?.Dispose();
            clock_face_cache = null;
        }

        // Draw the clock face
        // Draws numbers 1 to 12 around the clock face.
        // Calculates the position of each number based on trigonometric functions.
        // Draws the current date at the bottom of the clock face.
        private void Draw_Clock_Face(Graphics g)
        {
            using SolidBrush primary_brush = new(sking_manager.ColorScheme.PrimaryColor);

            for (int i = 1; i <= 12; i++)
            {
                double angle = half_of_pi - (i % 12) * pi_over_six;
                int tx = clock_center.X + (int)((clock_radius - clock_number_offset) * Math.Cos(angle));
                int ty = clock_center.Y - (int)((clock_radius - clock_number_offset) * Math.Sin(angle));

                string number_string = i.ToString();
                SizeF text_size = g.MeasureString(number_string, font_numbers);

                g.DrawString(number_string, font_numbers, primary_brush, tx - text_size.Width / 2, ty - text_size.Height / 2);
            }

            // Drawing the date
            string date_string = DateTime.Now.ToString("dd MMMM, yyyy");
            SizeF date_size = g.MeasureString(date_string, font_numbers);

            g.DrawString(date_string, font_numbers, primary_brush, clock_center.X - date_size.Width / 2, clock_center.Y + clock_radius - date_size.Height / 2 + date_offset);
        }

        // Create the clock cache
        // It first disposes of any existing cache.
        // Then, it creates a new blank bitmap with the dimensions of the clock panel.
        // It sets the drawing quality parameters for this bitmap.
        // It then calls Draw_Clock_Face to draw the clock face(numbers and date) onto this bitmap.
        private void Create_Clock_Face_Cache()
        {
            clock_face_cache?.Dispose();
            clock_face_cache = new Bitmap(panel_clock.Width, panel_clock.Height);

            using Graphics cache_graphics = Graphics.FromImage(clock_face_cache);
            cache_graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            cache_graphics.SmoothingMode = SmoothingMode.AntiAlias;
            cache_graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Draw_Clock_Face(cache_graphics);
        }

        // Draw the clock hand
        // This function draws a hand(either hour, minute, or second) onto the clock panel.
        // The hand's tip's position is determined using trigonometry based on the provided angle.
        // The base of the hand is drawn as a small circle.
        // The hand's body is drawn as a polygon with a pointy end (which points towards the clock's circumference).
        private static void Draw_Hand(Graphics g, Point center, int length, double angle, int width, SolidBrush brush)
        {
            double radian_angle = Math.PI * angle / 180.0;

            Point[] points = new Point[3];
            points[0] = new Point(center.X + (int)(length * Math.Cos(radian_angle)), center.Y + (int)(length * Math.Sin(radian_angle)));
            points[1] = new Point(center.X - (int)((width / 2) * Math.Sin(radian_angle)), center.Y + (int)((width / 2) * Math.Cos(radian_angle)));
            points[2] = new Point(center.X + (int)((width / 2) * Math.Sin(radian_angle)), center.Y - (int)((width / 2) * Math.Cos(radian_angle)));

            // Draw a circle at the base of the hand
            g.FillEllipse(brush, center.X - width / 2, center.Y - width / 2, width, width);

            // Draw the hand as a polygon (for the pointy end)
            g.FillPolygon(brush, points);
        }

        // Draw the clock hands
        // Given the current time and brushes for hour, minute, and second hands, it calculates the angles for each hand based on the current time.
        // Each hand is then drawn onto the clock panel using the Draw_Hand function.
        // Also, a center dot is drawn on the clock's center point.
        private void Draw_Hands(Graphics g, DateTime now, SolidBrush primary_brush, SolidBrush secondary_brush, SolidBrush seconds_brush)
        {
            // Hour hand
            double hour = (now.Hour % 12 + now.Minute / 60.0 + now.Second / 3600.0) * 30 - hand_angle_offset;
            Draw_Hand(g, clock_center, (int)(0.5 * clock_radius), hour, 8, primary_brush);

            // Minute hand
            double minute = now.Minute * 6 + now.Second * 0.1 - hand_angle_offset;
            Draw_Hand(g, clock_center, (int)(0.7 * clock_radius), minute, 6, secondary_brush);

            // Second hand
            double second = now.Second * 6 - hand_angle_offset;
            Draw_Hand(g, clock_center, (int)(0.9 * clock_radius), second, 4, seconds_brush);

            // Draw center dot
            g.FillEllipse(primary_brush, clock_center.X - 5, clock_center.Y - 5, 10, 10);
        }

        // Draw the clock on to the panel
        // This function handles the painting event of the clock panel.
        // It prepares brushes based on the provided color scheme.
        // It also retrieves the current time.
        // If the clock face cache is not set, it triggers its creation.
        // The cached image of the clock is drawn onto the clock panel.
        // The clock's hands (hour, minute, and second) are then drawn on top of the cached image.
        private void Panel_Clock_Paint(object? sender, PaintEventArgs e)
        {
            using SolidBrush primary_brush = new(sking_manager.ColorScheme.PrimaryColor),
                             secondary_brush = new(sking_manager.ColorScheme.AccentColor),
                             seconds_brush = new(Color.Red);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            DateTime now = DateTime.Now;

            if (clock_face_cache == null)
            {
                Create_Clock_Face_Cache();
            }

            e.Graphics.DrawImageUnscaled(clock_face_cache ?? throw new InvalidOperationException("Clock could not be found."), 0, 0);

            Draw_Hands(e.Graphics, now, primary_brush, secondary_brush, seconds_brush);
        }

        // CLOCK -------------------------------------------------------------------------------------------------------------

        // Theme change ------------------------------------------------------------------------------------------------------
        private void MaterialSwitch_Theme_CheckedChanged(object sender, EventArgs e)
        {
            var theme = materialSwitch_theme.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            Theme_Manager.Update_Theme(theme);
        }

        private void MaterialRadioButton_Color_Green_CheckedChanged(object sender, EventArgs e)
        {
            Theme_Manager.Update_Color_Scheme(new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE));
            Invalidate_Clock_Face_Cache();
            panel_clock.Invalidate();
        }

        private void MaterialRadioButton_Color_Amber_CheckedChanged(object sender, EventArgs e)
        {
            Theme_Manager.Update_Color_Scheme(new ColorScheme(Primary.Amber800, Primary.Amber900, Primary.Amber500, Accent.Amber200, TextShade.WHITE));
            Invalidate_Clock_Face_Cache();
            panel_clock.Invalidate();
        }

        private void MaterialRadioButton_Color_Pink_CheckedChanged(object sender, EventArgs e)
        {
            Theme_Manager.Update_Color_Scheme(new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE));
            Invalidate_Clock_Face_Cache();
            panel_clock.Invalidate();
        }

        private void MaterialRadioButton_Color_Blue_CheckedChanged(object sender, EventArgs e)
        {
            Theme_Manager.Update_Color_Scheme(new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE));
            Invalidate_Clock_Face_Cache();
            panel_clock.Invalidate();
        }

        private void MaterialRadioButton_Color_Red_CheckedChanged(object sender, EventArgs e)
        {
            Theme_Manager.Update_Color_Scheme(new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE));
            Invalidate_Clock_Face_Cache();
            panel_clock.Invalidate();
        }

        private void MaterialRadioButton_Color_Yellow_CheckedChanged(object sender, EventArgs e)
        {
            Theme_Manager.Update_Color_Scheme(new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE));
            Invalidate_Clock_Face_Cache();
            panel_clock.Invalidate();
        }

        // Theme change ------------------------------------------------------------------------------------------------------

        // Functions ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}