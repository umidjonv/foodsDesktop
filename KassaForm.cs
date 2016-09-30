using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using foodsDesktop.Classes;
using System.Windows.Forms;

namespace foodsDesktop
{
    public partial class KassaForm : Form
    {
        
        public KassaForm()
        {
            InitializeComponent();
            int w = this.Size.Width;
            int h = this.Size.Height;
            //label1.Location = new Point(w/2-175, label1.Location.Y);
            //label2.Location = new Point(w / 2 - 175, label2.Location.Y);
            //tbxLogin.Location = new Point(w / 2 - 175, tbxLogin.Location.Y);
            //tbxPass.Location = new Point(w / 2 - 175, tbxPass.Location.Y);
            //btnLogin.Location = new Point(w / 2 - 175, btnLogin.Location.Y);
            DBclass DB = new Classes.DBclass("employee");
        }

        
    }
}
