namespace foodsDesktop
{
    partial class ZakazForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelDishes = new System.Windows.Forms.Panel();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabCMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tablePanelDishes = new System.Windows.Forms.FlowLayoutPanel();
            this.gbxSchet = new System.Windows.Forms.GroupBox();
            this.dgvSchet = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTovar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelDishes.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.tabCMenu.SuspendLayout();
            this.gbxSchet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbxSchet);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("PT Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelDishes);
            this.splitContainer1.Panel2.Controls.Add(this.panelTab);
            this.splitContainer1.Panel2.Controls.Add(this.btnLeft);
            this.splitContainer1.Panel2.Controls.Add(this.btnRight);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Size = new System.Drawing.Size(1418, 721);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelDishes
            // 
            this.panelDishes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDishes.AutoScroll = true;
            this.panelDishes.Controls.Add(this.tablePanelDishes);
            this.panelDishes.Location = new System.Drawing.Point(4, 164);
            this.panelDishes.Name = "panelDishes";
            this.panelDishes.Size = new System.Drawing.Size(1048, 557);
            this.panelDishes.TabIndex = 4;
            // 
            // panelTab
            // 
            this.panelTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTab.Controls.Add(this.tabCMenu);
            this.panelTab.Location = new System.Drawing.Point(210, 3);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(796, 155);
            this.panelTab.TabIndex = 0;
            // 
            // tabCMenu
            // 
            this.tabCMenu.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCMenu.Controls.Add(this.tabPage1);
            this.tabCMenu.Controls.Add(this.tabPage2);
            this.tabCMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCMenu.Location = new System.Drawing.Point(0, 0);
            this.tabCMenu.Name = "tabCMenu";
            this.tabCMenu.SelectedIndex = 0;
            this.tabCMenu.Size = new System.Drawing.Size(796, 155);
            this.tabCMenu.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 115);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 126);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(155, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(49, 115);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeftRight_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.Location = new System.Drawing.Point(1012, 6);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(49, 115);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnLeftRight_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 115);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tablePanelDishes
            // 
            this.tablePanelDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelDishes.AutoScroll = true;
            this.tablePanelDishes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanelDishes.Location = new System.Drawing.Point(6, 15);
            this.tablePanelDishes.Name = "tablePanelDishes";
            this.tablePanelDishes.Size = new System.Drawing.Size(1039, 475);
            this.tablePanelDishes.TabIndex = 4;
            // 
            // gbxSchet
            // 
            this.gbxSchet.Controls.Add(this.dgvSchet);
            this.gbxSchet.Location = new System.Drawing.Point(3, 145);
            this.gbxSchet.Name = "gbxSchet";
            this.gbxSchet.Size = new System.Drawing.Size(344, 525);
            this.gbxSchet.TabIndex = 0;
            this.gbxSchet.TabStop = false;
            this.gbxSchet.Text = "Счёт";
            // 
            // dgvSchet
            // 
            this.dgvSchet.AllowUserToResizeColumns = false;
            this.dgvSchet.AllowUserToResizeRows = false;
            this.dgvSchet.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvSchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.NameTovar,
            this.count,
            this.price});
            this.dgvSchet.Location = new System.Drawing.Point(9, 33);
            this.dgvSchet.Name = "dgvSchet";
            this.dgvSchet.RowHeadersVisible = false;
            this.dgvSchet.RowTemplate.Height = 24;
            this.dgvSchet.Size = new System.Drawing.Size(329, 517);
            this.dgvSchet.TabIndex = 0;
            // 
            // number
            // 
            this.number.HeaderText = "#";
            this.number.Name = "number";
            this.number.Width = 30;
            // 
            // NameTovar
            // 
            this.NameTovar.HeaderText = "Имя товара";
            this.NameTovar.Name = "NameTovar";
            this.NameTovar.Width = 200;
            // 
            // count
            // 
            this.count.HeaderText = "Количетство";
            this.count.Name = "count";
            this.count.Width = 30;
            // 
            // price
            // 
            this.price.HeaderText = "сумма";
            this.price.Name = "price";
            this.price.Width = 70;
            // 
            // ZakazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1418, 721);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ZakazForm";
            this.Text = "Касса";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ZakazForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelDishes.ResumeLayout(false);
            this.panelTab.ResumeLayout(false);
            this.tabCMenu.ResumeLayout(false);
            this.gbxSchet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabCMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelDishes;
        private System.Windows.Forms.FlowLayoutPanel tablePanelDishes;
        private System.Windows.Forms.GroupBox gbxSchet;
        private System.Windows.Forms.DataGridView dgvSchet;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTovar;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;

    }
}