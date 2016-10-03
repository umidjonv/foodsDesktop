using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace foodsDesktop
{
    static class Program
    {
        public static int window_type;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ZakazForm());
            switch (window_type)
            {
                case 2:
                    Application.Run(new ZakazForm());
                    break;
            }
        }
    }
}
