
namespace FrmMain.cs
{
    partial class FrmDangNhap
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
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.lblCN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbSV = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbCN
            // 
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(304, 116);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(343, 28);
            this.cmbCN.TabIndex = 0;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCN.Location = new System.Drawing.Point(121, 118);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(86, 26);
            this.lblCN.TabIndex = 1;
            this.lblCN.Text = "KHOA";
            this.lblCN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(304, 184);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(343, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(304, 251);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(343, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.Location = new System.Drawing.Point(342, 352);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(122, 31);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(506, 352);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 31);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbSV
            // 
            this.cbSV.AutoSize = true;
            this.cbSV.Location = new System.Drawing.Point(515, 298);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(103, 24);
            this.cbSV.TabIndex = 4;
            this.cbSV.Text = "Sinh Viên";
            this.cbSV.UseVisualStyleBackColor = true;
            this.cbSV.CheckedChanged += new System.EventHandler(this.cbSV_CheckedChanged);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.cmbCN);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox cbSV;
    }
}