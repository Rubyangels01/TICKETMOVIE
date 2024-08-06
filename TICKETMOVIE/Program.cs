using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICKETMOVIE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetDefaultFont("Palatino Linotype", 10);
            Application.Run(new Logincs());
        }
        static void SetDefaultFont(string fontFamily, float fontSize)
        {
            var defaultFont = new Font(fontFamily, fontSize);
            foreach (Form form in Application.OpenForms)
            {
                SetFontRecursive(form, defaultFont);
            }
        }
        static void SetFontRecursive(Control control, Font font)
        {
            control.Font = font;
            foreach (Control childControl in control.Controls)
            {
                SetFontRecursive(childControl, font);
            }
        }
    }
}
