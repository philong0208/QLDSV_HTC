
namespace FrmMain.cs
{
    partial class FrmDangKyTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKyTK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGV = new System.Windows.Forms.ComboBox();
            this.pnRole = new DevExpress.XtraEditors.PanelControl();
            this.rdoPGV = new System.Windows.Forms.RadioButton();
            this.rdoKhoa = new System.Windows.Forms.RadioButton();
            this.rdoPKeToan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnRole)).BeginInit();
            this.pnRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.cmbGV);
            this.panel1.Controls.Add(this.pnRole);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Location = new System.Drawing.Point(518, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 424);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbGV
            // 
            this.cmbGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGV.FormattingEnabled = true;
            this.cmbGV.Location = new System.Drawing.Point(89, 226);
            this.cmbGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGV.Name = "cmbGV";
            this.cmbGV.Size = new System.Drawing.Size(203, 21);
            this.cmbGV.TabIndex = 24;
            // 
            // pnRole
            // 
            this.pnRole.Controls.Add(this.rdoPGV);
            this.pnRole.Controls.Add(this.rdoKhoa);
            this.pnRole.Controls.Add(this.rdoPKeToan);
            this.pnRole.Location = new System.Drawing.Point(90, 277);
            this.pnRole.Name = "pnRole";
            this.pnRole.Size = new System.Drawing.Size(203, 50);
            this.pnRole.TabIndex = 23;
            // 
            // rdoPGV
            // 
            this.rdoPGV.AutoSize = true;
            this.rdoPGV.Location = new System.Drawing.Point(15, 19);
            this.rdoPGV.Name = "rdoPGV";
            this.rdoPGV.Size = new System.Drawing.Size(44, 17);
            this.rdoPGV.TabIndex = 4;
            this.rdoPGV.TabStop = true;
            this.rdoPGV.Text = "PGV";
            this.rdoPGV.UseVisualStyleBackColor = true;
            // 
            // rdoKhoa
            // 
            this.rdoKhoa.AutoSize = true;
            this.rdoKhoa.Location = new System.Drawing.Point(68, 19);
            this.rdoKhoa.Name = "rdoKhoa";
            this.rdoKhoa.Size = new System.Drawing.Size(49, 17);
            this.rdoKhoa.TabIndex = 5;
            this.rdoKhoa.TabStop = true;
            this.rdoKhoa.Text = "Khoa";
            this.rdoKhoa.UseVisualStyleBackColor = true;
            // 
            // rdoPKeToan
            // 
            this.rdoPKeToan.AutoSize = true;
            this.rdoPKeToan.Location = new System.Drawing.Point(126, 19);
            this.rdoPKeToan.Name = "rdoPKeToan";
            this.rdoPKeToan.Size = new System.Drawing.Size(67, 17);
            this.rdoPKeToan.TabIndex = 6;
            this.rdoPKeToan.TabStop = true;
            this.rdoPKeToan.Text = "PKeToan";
            this.rdoPKeToan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(77, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 88);
            this.label5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Login";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DimGray;
            this.btnHuy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(185, 352);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(167, 39);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangKy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(3, 352);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(166, 39);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(90, 161);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogin.Properties.Appearance.Options.UseBackColor = true;
            this.txtLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtLogin.Properties.MaxLength = 25;
            this.txtLogin.Size = new System.Drawing.Size(201, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giảng Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(90, 190);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.Properties.Appearance.Options.UseBackColor = true;
            this.txtPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtPass.Properties.MaxLength = 25;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(201, 20);
            this.txtPass.TabIndex = 1;
            // 
            // FrmDangKyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 408);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDangKyTK";
            this.Text = "FrmDangKyTK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnRole)).EndInit();
            this.pnRole.ResumeLayout(false);
            this.pnRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGV;
        private DevExpress.XtraEditors.PanelControl pnRole;
        private System.Windows.Forms.RadioButton rdoPGV;
        private System.Windows.Forms.RadioButton rdoKhoa;
        private System.Windows.Forms.RadioButton rdoPKeToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKy;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPass;
    }
}