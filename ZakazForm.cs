﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Drawing.Printing;
using Microsoft.Win32;

using foodsDesktop.Classes;
using foodsDesktop.DB;

using System.Windows.Forms;

namespace foodsDesktop
{
    public partial class ZakazForm : Form
    {
        
        public ZakazForm()
        {
            InitializeComponent();

            UserValues.expense_id = -1;
            DataTable table = new DataTable();
            table.Columns.Add("order_id", typeof(int));
            table.Columns.Add("just_id", typeof(int));
            table.Columns.Add("NameTovar");
            table.Columns.Add("type");
            table.Columns.Add("count", typeof(int));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("summaOne", typeof(decimal), "count*price");
            table.Columns["order_id"].AutoIncrement = true;
            table.Columns["order_id"].AutoIncrementSeed = 1;
            table.Columns["order_id"].AutoIncrementStep = 1;
            dgvSchet.DataSource = table;
            

            int w = this.Size.Width;
            int h = this.Size.Height;
            //label1.Location = new Point(w/2-175, label1.Location.Y);
            //label2.Location = new Point(w / 2 - 175, label2.Location.Y);
            //tbxLogin.Location = new Point(w / 2 - 175, tbxLogin.Location.Y);
            //tbxPass.Location = new Point(w / 2 - 175, tbxPass.Location.Y);
            //btnLogin.Location = new Point(w / 2 - 175, btnLogin.Location.Y);
            DB = new Classes.DBclass("dishtype");
            DataSet ds = DBclass.DS;
            
            
            tabCMenu.Controls.Clear();
            TableLayoutPanel tablepanel = new TableLayoutPanel();
            TabPage page1 = new TabPage("1");
            Button btn;
            
            
            //page1.Size = new Size(tabCMenu.Width-10, page1.Size.Height);
            int i = 0;
            int pages = 0;
            int size_w = tablepanel.Size.Width;
            bool nextTab = true;
            DataRowCollection drcol = ds.Tables["dishtype"].Rows;
            for (int counter = 0; counter < drcol.Count; counter++)
            {
                DataRow dr = drcol[counter];
                if (nextTab)
                {
                    tablepanel = new TableLayoutPanel();
                    tablepanel.Name = "tablePanel" + (++pages).ToString();
                    page1 = new TabPage(pages.ToString());
                    
                    page1.Controls.Add(tablepanel);
                    tablepanel.Dock = DockStyle.Top;
                    tabCMenu.Controls.Add(page1);

                    tablepanel.ColumnStyles.Clear();
                    tablepanel.ColumnCount = 2;
                    tablepanel.RowCount = 1;

                    page1.Size = new Size(tabCMenu.Width - 10, page1.Size.Height);

                    nextTab = false;
                }
                btn = new Button();
                //btn.AutoSize = true;
                btn.Margin = new System.Windows.Forms.Padding(0);
                btn.Text = dr["name"].ToString();
                btn.Tag = dr["type_id"];
                btn.Height = 100;
                btn.Click += ClickMenu;
                using (Graphics gr = this.CreateGraphics())
                {
                    SizeF size = gr.MeasureString(dr["name"].ToString(), this.Font);

                    //btn.Padding = new System.Windows.Forms.Padding(3);
                    btn.Width = (int)size.Width + 12;
                    tablepanel.ColumnCount = i + 1;
                    tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize, (int)size.Width + 6));
                    tablepanel.Controls.Add(btn, i, 0);
                    i++;
                    if (drcol.Count != (counter + 1))
                    {
                        DataRow drNext = drcol[counter+1];
                        SizeF sizeNext = gr.MeasureString(drNext["name"].ToString(), this.Font);
                        if (tablepanel.Width <= btn.Location.X + btn.Width + sizeNext.Width+12)
                        {
                            //tablepanel.Controls.Remove(btn);

                            nextTab = true;
                        }
                    }
                    
                }


            }
            // Generate view for all dishes with their categories
            DB.FillMenu_Dishes();

            ExpenseDB.Expense exp = (ExpenseDB.Expense)DBclass.DS.Tables["expense"];
            DataRow[] existRow = exp.Select("employee_id = "+UserValues.CurrentUserID+" and table="+UserValues.CurrentTable);

            if (existRow.Length > 0)
            {
                DB.FillOrders((int)existRow[0]["expense_id"]);
                DataTable dtOrders = DBclass.DS.Tables["orders"];
                foreach (DataRow dr in dtOrders.Select("expense_id = " + existRow[0]["expense_id"].ToString()))
                {
                    DataRow drT = table.NewRow();
                    drT["just_id"] = dr["just_id"];
                    //drT["expense_id"] = dr["expense_id"];
                    drT["type"] = dr["type"];
                    drT["count"] = dr["count"];

                    var results = (from myRow in DBclass.DS.Tables["menu_dishes_v"].AsEnumerable()
                                   where myRow.Field<int>("dish_id") == (int)dr["just_id"]
                                   select myRow).FirstOrDefault();
                    drT["NameTovar"] = results["dishname"];
                    drT["price"] = results["price"];

                    //results[""]
                    //var user = (from u in dc.Users
                    //            where u.UserName == usn
                    //            select u).FirstOrDefault();
                    table.Rows.Add(drT);
                }
                UserValues.expense_id = (int)existRow[0]["expense_id"];
            }
        }
        DBclass DB;
        int dish_col_count;
        private void btnLeftRight_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnLeft")
            {
                tabCMenu.SelectedIndex = tabCMenu.SelectedIndex - 1 >= 0 ? tabCMenu.SelectedIndex - 1 : tabCMenu.SelectedIndex; 
            }
            else
            {
                tabCMenu.SelectedIndex = tabCMenu.TabPages.Count >= tabCMenu.SelectedIndex + 1 ? tabCMenu.SelectedIndex + 1 : tabCMenu.SelectedIndex;  
            }
        }
        private void ClickMenu(object sender, EventArgs e)
        {
            
            
            int id = Convert.ToInt32((sender as Button).Tag);
            DataRow[] drDishes = DB.GetDishesRow(id);

            // TableLayoutPanel calculate size
            TablePanelDishes newPanelDishes = new TablePanelDishes();
            
            int i = 1;
            
            foreach (DataRow dr in drDishes)
            {

                
                PanelExtend panel = new PanelExtend((int)dr["dish_id"], dr["dishname"].ToString(), (dr["price"]!=DBNull.Value?((float)dr["price"]):0), (int)dr["type"]);
                panel.Dock = DockStyle.None;
                panel.Width = 170;
                panel.Height = 170;
                panel.PanelButton.Click+=Dish_Click;
                //panel.Tag = dr["type"];
                newPanelDishes.Controls.Add(panel);
                i++;
 
            }
            newPanelDishes.Visible = true;
            
            panelDishes.Controls.Add(newPanelDishes);
            panelDishes.Controls.Remove(tablePanelDishes);
            tablePanelDishes.Visible = false;
            //panelDishes.Paint += panelDishes_Paint;
            tablePanelDishes = newPanelDishes;
            GC.Collect();
            //tablePanelDishes.Height += 100;
            //PanelExtend panel = new PanelExtend("Салат Цезарь", "7 000");
            //tablePanelDishes.Controls.Add(panel);
        }

        void panelDishes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ZakazForm_Load(object sender, EventArgs e)
        {
            tablePanelDishes.Refresh();
            tablePanelDishes.Width = panelDishes.Width;
            tablePanelDishes.BackColor = System.Drawing.Color.Transparent;
            dish_col_count = tablePanelDishes.Width / 170;
            lblUser.Text = UserValues.CurrentUser;
            gbxStolNumber.Text += UserValues.CurrentTable;

            dgvSchet.Columns["just_id"].Visible = false;
            dgvSchet.Columns["summaOne"].Visible = false;
            dgvSchet.Columns["type"].Visible = false;
            dgvSchet.Columns["order_id"].Width = 30;
            dgvSchet.Columns["NameTovar"].Width = 160;
            dgvSchet.Columns["count"].Width = 30;
            dgvSchet.Columns["price"].Width = 50;
            dgvSchet.Columns["order_id"].HeaderText = "№";
            dgvSchet.Columns["NameTovar"].HeaderText = "Наим.";
            dgvSchet.Columns["count"].HeaderText = "Кол.";
            dgvSchet.Columns["price"].HeaderText = "Цена";

            DataGridViewButtonColumn cellBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            cellBtn.HeaderText = "";
            cellBtn.Name = "colBtn";
            cellBtn.Width = 40;
            dgvSchet.Columns.Add(cellBtn);
            var dtable = (DataTable)dgvSchet.DataSource;
            var query = dtable.AsEnumerable().Sum(x => x.Field<decimal>("summaOne"));
            lblSumma.Text = query.ToString();


            
        }
        private void Dish_Click(object sender, EventArgs e)
        {
            
            Button eve = sender as Button;
            DishProdHstuf dph = (DishProdHstuf)eve.Parent.Tag;
            int id = dph.ID;
            DataTable table = dgvSchet.DataSource as DataTable;
            DataRow[] drs = table.Select("just_id = " + id);
            if (drs.Length != 0)
            {
                int count = (int)drs[0]["count"];
                drs[0]["count"] = count + 1;
            }
            else
            {
                DataRow drNew = table.NewRow();
                drNew["NameTovar"] = eve.Text;
                drNew["just_id"] = id;
                drNew["type"] = dph.type;
                PanelExtend panel = eve.Parent as PanelExtend;
                drNew["price"] = panel.PanelLabel.Text;
                drNew["count"] = 1;
                table.Rows.Add(drNew);
            }
            var dtable = (DataTable)dgvSchet.DataSource;
            var query = dtable.AsEnumerable().Sum(x => x.Field<decimal>("summaOne"));
            lblSumma.Text = query.ToString();
            //orderRow["expense_id"] = id;
            //orderRow["type"] = 2;
            //DataGridViewRow dgvRow = new DataGridViewRow();
            //dgvRow.Cells["NameTovar"].Value = eve.Text;
            

            //dgvRow.Cells["price"].Value = panel.PanelLabel.Text;
            

            
            
        }
        List<string[]> drPrintCol;
        private void btnSchet_Click(object sender, EventArgs e)
        {
            OrdersDB.Orders orders = (OrdersDB.Orders)DBclass.DS.Tables["orders"];
            ExpenseDB.Expense exp = (ExpenseDB.Expense)DBclass.DS.Tables["expense"];
            DataTable dtable = (DataTable)dgvSchet.DataSource;
            
            int id = 0;
            if (UserValues.expense_id == -1)
            {
                DataRow dr = exp.NewRow();
                dr["order_date"] = DateTime.Now;
                dr["employee_id"] = UserValues.CurrentUserID;
                dr["table"] = UserValues.CurrentTable;
                dr["status"] = 1;
                dr["deleted"] = 0;

                exp.Rows.Add(dr);

                id = DB.UIDExpense();
            }
            else
            {
                id = UserValues.expense_id; 
            }

            drPrintCol = new List<string[]>();

            
            foreach (DataRow drOrders in dtable.Rows)
            {
                DataRow[] oRows = orders.Select("expense_id = " + id+" and just_id="+drOrders["just_id"]);
                if (oRows.Length != 0)
                {
                    int razcount = (int)drOrders["count"] - (int)oRows[0]["count"];
                    oRows[0]["count"] = drOrders["count"];
                    if(razcount!=0)
                    drPrintCol.Add(new string[] { drOrders["NameTovar"].ToString(), razcount.ToString(), drOrders["price"].ToString() });
                    
                }
                else
                {
                    DataRow oRowNew = orders.NewRow();
                    oRowNew["expense_id"] = id;
                    oRowNew["just_id"] = drOrders["just_id"];
                    oRowNew["type"] = drOrders["type"];
                    oRowNew["employee_id"] = UserValues.CurrentUserID;
                    oRowNew["count"] = drOrders["count"];
                    oRowNew["status"] = 1;
                    oRowNew["count"] = drOrders["count"];
                    oRowNew["refuse"] = 0;
                    oRowNew["deleted"] = 0;
                    oRowNew["notificate"] = 0;
                    orders.Rows.Add(oRowNew);

                    drPrintCol.Add(new string[] { drOrders["NameTovar"].ToString(), drOrders["count"].ToString(), drOrders["price"].ToString() });
                }
                
            }
            DB.UIDOrders(id);

            if (drPrintCol.Count != 0)
                forPrinting(drPrintCol, id);

            CloseWindow();

            //this.Columns.Add(new DataColumn("order_date", typeof(DateTime)));
            //this.Columns.Add(new DataColumn("employee_id", typeof(int)));
            //this.Columns.Add(new DataColumn("table", typeof(int)));
            //this.Columns.Add(new DataColumn("status", typeof(int)));
            //this.Columns.Add(new DataColumn("deleted", typeof(int)));
            
        }
        private void CloseWindow()
        {
            Program.window_type = 1;
            Program.oldWindow_type = 2;
            Program.onClose = true;
        }
        private void forPrinting(List<string[]> data, int nomerZakaza)
        {
            int price = 0;
            string dataHtml = "";
            int num = 1;
            StreamWriter sw = new StreamWriter(System.IO.Path.GetTempPath()+"\\tempData.htm");
            decimal summa = 0;
            foreach (string[] sr in data)
            {
                dataHtml += "<tr><td>"+sr[0]+"</td><td>"+ sr[1]+"</td><td>"+ sr[2]+"</td></tr>";
                summa += decimal.Parse(sr[2]);
                num++;
            }
            dataHtml += "<tr><td><b>Итог:</b></td><td><b>" + summa + "</b></td><td></td><td></td></tr>";
            dataHtml = GenerateHTML(dataHtml, nomerZakaza);
            //string zakaz = "<h4>Номер заказа: " + nomerZakaza + "</h4>";
            //string oficiant = "<h4>Официант: " + lblUser.Text + "</h4>";
            //dataHtml = zakaz+oficiant+"<h4>Официант: " + DateTime.Now.ToString("dd.MM.YYYY HH:mm")+ "</h4>" + dataHtml;
            sw.Write(dataHtml);
            sw.Close();
            //printing();
            string keyName = @"Software\Microsoft\Internet Explorer\PageSetup";
            using ( RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key != null)
                {
                    string old_footer = (string)key.GetValue("footer");
                    string old_header = (string)key.GetValue("header");
                    key.SetValue("footer", "");
                    key.SetValue("header", "");

                    WebBrowser browser = new WebBrowser();
                    browser.DocumentText = dataHtml;
                    browser.DocumentCompleted += browser_DocumentCompleted;
                    browser.Print();
                    if(old_footer!=null)
                    key.SetValue("footer", old_footer);
                    if(old_header!=null)
                    key.SetValue("header", old_header);
                }
            }
            
            //PrintClass cl = new PrintClass();
            //cl.Printing();
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = sender as WebBrowser;
            browser.Print();
        }
        private string GenerateHTML(string dataHtml, int nomerZakaza)
        {
            string html = "<head></head><body>"+
                "<table>"+
                "<tr><td style=\"text-align:right\">Дата: </td><td>" + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "</td></tr>" +
                "<tr><td style=\"text-align:right\">Официант: </td><td>" + lblUser.Text + "</td></tr>" +
                "<tr><td style=\"text-align:right\">Счет №: </td><td>" + nomerZakaza + "</td></tr>" +
                "<tr><td style=\"text-align:right\">Стол №: </td><td>" + UserValues.CurrentTable + "</td></tr>" +
                
                "</table><br/>"+
                
                 
                "<table>"+
                    "<thead>"+
                        "<tr>"+
                            
                            "<td>Заказ</td>" +
                            "<td>Кол.</td>" +
                            "<td>Цена</td>" +
                        "</tr>"+
                    "<thead>" +
                        
                    "<tbody>"+dataHtml+
                    "<tbody>"+
                "</table>"+
                "</body>";
            return html;
        }
        
        
        private void btnTables_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void dgvSchet_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgvSchet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if ((int)grid.Rows[e.RowIndex].Cells["count"].Value > 0)
                {
                    int kol = (int)grid.Rows[e.RowIndex].Cells["count"].Value;
                    kol--;
                    grid.Rows[e.RowIndex].Cells["count"].Value = kol;
                }
            }
        }

        private void dgvSchet_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.ColumnIndex==dgvSchet.Columns.Count-1 &&e.RowIndex>=0)
            {
                DataGridViewButtonCell dgvCell = (DataGridViewButtonCell)dgvSchet.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvCell.Value = "-";
            }
            
        }

        

        private void btnStopList_Click(object sender, EventArgs e)
        {
            OrdersDB.Orders orders = (OrdersDB.Orders)DBclass.DS.Tables["orders"];
            ExpenseDB.Expense exp = (ExpenseDB.Expense)DBclass.DS.Tables["expense"];
            DataTable dtable = (DataTable)dgvSchet.DataSource;

            int id = 0;
            if (UserValues.expense_id == -1)
            {
                DataRow dr = exp.NewRow();
                dr["order_date"] = DateTime.Now;
                dr["employee_id"] = UserValues.CurrentUserID;
                dr["table"] = UserValues.CurrentTable;
                dr["status"] = 0;
                dr["deleted"] = 0;

                exp.Rows.Add(dr);

                id = DB.UIDExpense();
            }
            else
            {
                id = UserValues.expense_id;
                DataRow[] rws = exp.Select("expense_id="+id);
                foreach (DataRow dr in rws)
                {
                    dr["status"] = 0;
 
                }
            }

            drPrintCol = new List<string[]>();


            foreach (DataRow drOrders in dtable.Rows)
            {
                DataRow[] oRows = orders.Select("expense_id = " + id + " and just_id=" + drOrders["just_id"]);
                if (oRows.Length != 0)
                {
                    int razcount = (int)drOrders["count"] - (int)oRows[0]["count"];
                    oRows[0]["count"] = drOrders["count"];
                    oRows[0]["status"] = 0;
                    if (razcount != 0)
                        drPrintCol.Add(new string[] { drOrders["NameTovar"].ToString(), razcount.ToString(), drOrders["price"].ToString() });

                }
                else
                {
                    DataRow oRowNew = orders.NewRow();
                    oRowNew["expense_id"] = id;
                    oRowNew["just_id"] = drOrders["just_id"];
                    oRowNew["type"] = drOrders["type"];
                    oRowNew["employee_id"] = UserValues.CurrentUserID;
                    oRowNew["count"] = drOrders["count"];
                    oRowNew["status"] = 0;
                    oRowNew["count"] = drOrders["count"];
                    oRowNew["refuse"] = 0;
                    oRowNew["deleted"] = 0;
                    oRowNew["notificate"] = 0;
                    orders.Rows.Add(oRowNew);

                    drPrintCol.Add(new string[] { drOrders["NameTovar"].ToString(), drOrders["count"].ToString(), drOrders["price"].ToString() });
                }

            }
            DB.UIDOrders(id);
            DB.UIDExpense();
            if (drPrintCol.Count != 0)
                forPrinting(drPrintCol, id);

            CloseWindow();
        }
        
        
        


        
    }
}
