using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodsDesktop
{
    public partial class FormMain : Form
    {
        LoginForm_O loginform;
        TableForm tableform;
        ZakazForm zakazform;
        public FormMain()
        {
            InitializeComponent();
            loginform = new LoginForm_O();
            tableform = new TableForm();
            zakazform = new ZakazForm();
            
            loginform.Show();
            loginform.TopMost = true;
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.onClose)
            {
                Form form = new Form() ;
                if (Program.window_type != 0)
                {
                    switch (Program.window_type)
                    {
                        case 1:
                            tableform = new TableForm();
                            tableform.SendToBack();
                            tableform.Show();
                            form = tableform;
                            if (Program.window_type == 1) Program.window_type = 0;
                            break;
                        case 2:
                            zakazform = new ZakazForm();
                            zakazform.SendToBack();
                            zakazform.Show();
                            if (Program.window_type == 2) Program.window_type = 0;
                            break;
                        case 3:
                            loginform = new LoginForm_O();
                            loginform.SendToBack();
                            loginform.Show();
                            if (Program.window_type == 3) Program.window_type = 0;
                            break;
                        case 0:
                            break;
                    }
                    Program.onClose = false;
                    switch (Program.oldWindow_type)
                    {
                        case 1: tableform.Close();
                            break;
                        case 2: zakazform.Close();
                            break;
                        case 3: loginform.Close();
                            break;
                    }
                    form.TopMost = true;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
