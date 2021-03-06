﻿namespace foodsDesktop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbxStolNumber = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSumma = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.gbxSchet = new System.Windows.Forms.GroupBox();
            this.btnSchet = new System.Windows.Forms.Button();
            this.dgvSchet = new System.Windows.Forms.DataGridView();
            this.btnStopList = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.panelDishes = new System.Windows.Forms.Panel();
            this.tablePanelDishes = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabCMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbxStolNumber.SuspendLayout();
            this.gbxSchet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchet)).BeginInit();
            this.panelDishes.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.tabCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.gbxStolNumber);
            this.splitContainer1.Panel1.Controls.Add(this.gbxSchet);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("PT Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.btnStopList);
            this.splitContainer1.Panel2.Controls.Add(this.btnTables);
            this.splitContainer1.Panel2.Controls.Add(this.panelDishes);
            this.splitContainer1.Panel2.Controls.Add(this.panelTab);
            this.splitContainer1.Panel2.Controls.Add(this.btnLeft);
            this.splitContainer1.Panel2.Controls.Add(this.btnRight);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Size = new System.Drawing.Size(1006, 653);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbxStolNumber
            // 
            this.gbxStolNumber.Controls.Add(this.label2);
            this.gbxStolNumber.Controls.Add(this.label1);
            this.gbxStolNumber.Controls.Add(this.lblSumma);
            this.gbxStolNumber.Controls.Add(this.lblUser);
            this.gbxStolNumber.Font = new System.Drawing.Font("PT Serif", 12F);
            this.gbxStolNumber.Location = new System.Drawing.Point(12, 12);
            this.gbxStolNumber.Name = "gbxStolNumber";
            this.gbxStolNumber.Size = new System.Drawing.Size(329, 110);
            this.gbxStolNumber.TabIndex = 1;
            this.gbxStolNumber.TabStop = false;
            this.gbxStolNumber.Text = "Стол № ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сумма";
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(125, 66);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(23, 27);
            this.lblSumma.TabIndex = 6;
            this.lblSumma.Text = "0";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(125, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 27);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User";
            // 
            // gbxSchet
            // 
            this.gbxSchet.Controls.Add(this.btnSchet);
            this.gbxSchet.Controls.Add(this.dgvSchet);
            this.gbxSchet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxSchet.Font = new System.Drawing.Font("PT Serif", 10F);
            this.gbxSchet.Location = new System.Drawing.Point(0, 128);
            this.gbxSchet.Name = "gbxSchet";
            this.gbxSchet.Size = new System.Drawing.Size(248, 525);
            this.gbxSchet.TabIndex = 0;
            this.gbxSchet.TabStop = false;
            this.gbxSchet.Text = "Счёт";
            // 
            // btnSchet
            // 
            this.btnSchet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSchet.Font = new System.Drawing.Font("PT Serif", 12F);
            this.btnSchet.Location = new System.Drawing.Point(3, 461);
            this.btnSchet.Name = "btnSchet";
            this.btnSchet.Size = new System.Drawing.Size(242, 61);
            this.btnSchet.TabIndex = 2;
            this.btnSchet.Text = "Оформить счёт";
            this.btnSchet.UseVisualStyleBackColor = true;
            this.btnSchet.Click += new System.EventHandler(this.btnSchet_Click);
            // 
            // dgvSchet
            // 
            this.dgvSchet.AllowUserToAddRows = false;
            this.dgvSchet.AllowUserToResizeColumns = false;
            this.dgvSchet.AllowUserToResizeRows = false;
            this.dgvSchet.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PT Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSchet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSchet.Location = new System.Drawing.Point(3, 26);
            this.dgvSchet.MultiSelect = false;
            this.dgvSchet.Name = "dgvSchet";
            this.dgvSchet.RowHeadersVisible = false;
            this.dgvSchet.RowHeadersWidth = 50;
            this.dgvSchet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvSchet.RowTemplate.Height = 40;
            this.dgvSchet.Size = new System.Drawing.Size(242, 434);
            this.dgvSchet.TabIndex = 0;
            this.dgvSchet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchet_CellContentClick);
            this.dgvSchet.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvSchet_CellPainting);
            this.dgvSchet.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSchet_RowsAdded);
            // 
            // btnStopList
            // 
            this.btnStopList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStopList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStopList.Location = new System.Drawing.Point(300, 589);
            this.btnStopList.Name = "btnStopList";
            this.btnStopList.Size = new System.Drawing.Size(139, 58);
            this.btnStopList.TabIndex = 5;
            this.btnStopList.Text = "Стоп лист";
            this.btnStopList.UseVisualStyleBackColor = false;
            this.btnStopList.Click += new System.EventHandler(this.btnStopList_Click);
            // 
            // btnTables
            // 
            this.btnTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTables.Location = new System.Drawing.Point(7, 590);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(139, 58);
            this.btnTables.TabIndex = 5;
            this.btnTables.Text = "Назад";
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // panelDishes
            // 
            this.panelDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDishes.AutoScroll = true;
            this.panelDishes.BackColor = System.Drawing.SystemColors.Control;
            this.panelDishes.Controls.Add(this.tablePanelDishes);
            this.panelDishes.Location = new System.Drawing.Point(4, 145);
            this.panelDishes.Name = "panelDishes";
            this.panelDishes.Size = new System.Drawing.Size(747, 442);
            this.panelDishes.TabIndex = 4;
            // 
            // tablePanelDishes
            // 
            this.tablePanelDishes.AutoScroll = true;
            this.tablePanelDishes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablePanelDishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelDishes.Location = new System.Drawing.Point(0, 0);
            this.tablePanelDishes.Name = "tablePanelDishes";
            this.tablePanelDishes.Size = new System.Drawing.Size(747, 442);
            this.tablePanelDishes.TabIndex = 4;
            // 
            // panelTab
            // 
            this.panelTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTab.Controls.Add(this.tabCMenu);
            this.panelTab.Location = new System.Drawing.Point(210, 3);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(486, 136);
            this.panelTab.TabIndex = 0;
            // 
            // tabCMenu
            // 
            this.tabCMenu.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCMenu.Controls.Add(this.tabPage1);
            this.tabCMenu.Controls.Add(this.tabPage2);
            this.tabCMenu.Location = new System.Drawing.Point(0, 0);
            this.tabCMenu.Name = "tabCMenu";
            this.tabCMenu.SelectedIndex = 0;
            this.tabCMenu.Size = new System.Drawing.Size(486, 136);
            this.tabCMenu.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 107);
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
            this.btnRight.Location = new System.Drawing.Point(702, 6);
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
            // ZakazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZakazForm";
            this.Text = "Касса";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ZakazForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbxStolNumber.ResumeLayout(false);
            this.gbxStolNumber.PerformLayout();
            this.gbxSchet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchet)).EndInit();
            this.panelDishes.ResumeLayout(false);
            this.panelTab.ResumeLayout(false);
            this.tabCMenu.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbxStolNumber;
        private System.Windows.Forms.Label lblSumma;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSchet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnStopList;

    }
}