using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace foodsDesktop
{
    static class Program
    {
        public static int window_type;
        public static bool onClose = false;
        public static int oldWindow_type;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //There must be LoginForm
            Application.Run(new FormMain());

            
        }
    }
    static class UserValues
    {
        public static string CurrentUser;
        public static int CurrentUserID;
        public static int CurrentTable;
        public static int expense_id;
        
    }
}
