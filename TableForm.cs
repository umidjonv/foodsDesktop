﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using foodsDesktop.Classes;
namespace foodsDesktop
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
            db = new DBclass("tables");
            Tables();
        }
        DBclass db;
        private void Tables()
        {
            DataTable tables = DBclass.DS.Tables["tables"];
            foreach (DataRow dr in tables.Rows)
            {
                Button btn = new Button();
                btn.Width = 200;
                btn.Height = 140;
                btn.Text = "Стол "+dr["table_num"].ToString();
                tablesLayoutPanel.Controls.Add(btn);
                btn.Click += btn_Click;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Program.window_type = 2;
            this.Close();
            string numberTable = (sender as Button).Text.Replace("Стол ", "");
            UserValues.CurrentTable = Convert.ToInt32(numberTable);
        }
    }
}
