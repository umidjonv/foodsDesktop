namespace foodsDesktop
{
    partial class LoginForm_O
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
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassError = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxLogin
            // 
            this.tbxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxLogin.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLogin.Location = new System.Drawing.Point(310, 181);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(350, 34);
            this.tbxLogin.TabIndex = 1;
            this.tbxLogin.Visible = false;
            // 
            // tbxPass
            // 
            this.tbxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPass.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPass.Location = new System.Drawing.Point(310, 280);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(350, 34);
            this.tbxPass.TabIndex = 2;
            this.tbxPass.TextChanged += new System.EventHandler(this.tbxPass_TextChanged);
            this.tbxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPass_KeyDown);
            this.tbxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPass_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.ForeColor = System.Drawing.Color.Tomato;
            this.lblPassError.Location = new System.Drawing.Point(310, 369);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(473, 27);
            this.lblPassError.TabIndex = 3;
            this.lblPassError.Text = "Ошибка входа: Логин или пароль не правильный";
            this.lblPassError.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.Location = new System.Drawing.Point(310, 322);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(350, 44);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm_O
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPassError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxLogin);
            this.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm_O";
            this.Text = "Авторизация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.Button btnEnter;
    }
}