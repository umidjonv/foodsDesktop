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
            //There must be LoginForm
            Application.Run(new TableForm());

            while (window_type != 0)
            {
                switch (window_type)
                {
                    case 1:
                        Application.Run(new TableForm());
                        window_type = 0;
                        break;
                    case 2:
                        Application.Run(new ZakazForm());
                        window_type = 0;
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
    static class UserValues
    {
        public static string CurrentUser;
        public static int CurrentUserID;
        public static int CurrentTable;
        
    }
}
