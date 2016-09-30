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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            int w = this.Size.Width;
            int h = this.Size.Height;
            label1.Location = new Point(w/2-175, label1.Location.Y);
            label2.Location = new Point(w / 2 - 175, label2.Location.Y);
            tbxLogin.Location = new Point(w / 2 - 175, tbxLogin.Location.Y);
            tbxPass.Location = new Point(w / 2 - 175, tbxPass.Location.Y);
            btnLogin.Location = new Point(w / 2 - 175, btnLogin.Location.Y);
            DBclass DB = new Classes.DBclass("employee");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable table =  DBclass.DS.Tables["employee"];
            string hash = CalculateMD5Hash(tbxPass.Text);
            DataRow[] rows = table.Select("login='"+tbxLogin.Text+"'");
            if (rows.Length != 0)
            {
                string pas = rows[0]["password"].ToString();
                if (pas == hash)
                {
                    Program.window_type = 2;
                    this.Close();
                    return;
                }

            }
            MessageBox.Show("Логин или пароль не правильный", "Ошибка входа...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        public string CalculateMD5Hash(string input)
        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

    }
}
