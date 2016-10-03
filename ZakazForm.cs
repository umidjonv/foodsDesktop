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
    public partial class ZakazForm : Form
    {
        
        public ZakazForm()
        {
            InitializeComponent();
            int w = this.Size.Width;
            int h = this.Size.Height;
            //label1.Location = new Point(w/2-175, label1.Location.Y);
            //label2.Location = new Point(w / 2 - 175, label2.Location.Y);
            //tbxLogin.Location = new Point(w / 2 - 175, tbxLogin.Location.Y);
            //tbxPass.Location = new Point(w / 2 - 175, tbxPass.Location.Y);
            //btnLogin.Location = new Point(w / 2 - 175, btnLogin.Location.Y);
            DBclass DB = new Classes.DBclass("dishtype");
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
                btn.Height = 100;

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
        }

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

        private void KassaForm_Load(object sender, EventArgs e)
        {

        }



        
    }
}
