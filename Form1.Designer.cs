
namespace QLY_DSV_HTC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_ChonServer = new System.Windows.Forms.ComboBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_ChonServer
            // 
            this.cb_ChonServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_ChonServer.FormattingEnabled = true;
            this.cb_ChonServer.Location = new System.Drawing.Point(200, 108);
            this.cb_ChonServer.Name = "cb_ChonServer";
            this.cb_ChonServer.Size = new System.Drawing.Size(209, 23);
            this.cb_ChonServer.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(101, 155);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(88, 15);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Tên đăng nhập:";
            this.lbUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(129, 202);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(63, 15);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Mật khẩu: ";
            this.lbPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(200, 152);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 23);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(200, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // lbServer
            // 
            this.lbServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(119, 111);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(73, 15);
            this.lbServer.TabIndex = 5;
            this.lbServer.Text = "Chọn server:";
            this.lbServer.Click += new System.EventHandler(this.lbServer_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(101, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(419, 32);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "QUẢN LÝ ĐIỂM SINH VIÊN HỆ TÍN CHỈ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 350);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.cb_ChonServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ChonServer;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label lbTitle;
    }
}

