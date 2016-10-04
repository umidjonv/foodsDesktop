using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace foodsDesktop.Classes
{
    class PanelExtend : Panel
    {
        

        public PanelExtend()
        {
            InitializeComponents();
        }
        public PanelExtend(string btnText, string labelText)
        {

            InitializeComponents(); 
            btn.Text = btnText;
            lbl.Text = labelText;
            this.Refresh();
            lbl.Location = new System.Drawing.Point(this.Width-100, this.Height / 3 * 2);

        }
        private void InitializeComponents()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = System.Drawing.Color.Cornsilk;
            btn = new Button();
            
            lbl = new Label();
            lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn.Dock = DockStyle.Top;
            btn.Width = 100;
            btn.Height = 130;
            btn.BackColor = System.Drawing.Color.MediumSpringGreen;  
            lbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            //lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            this.Controls.Add(btn);
            this.Controls.Add(lbl); 
        }
        Button btn;
        Label lbl;
        public Button PanelButton { get { return btn; } }
        public Label PanelLabel { get { return lbl; } }
    }
}
