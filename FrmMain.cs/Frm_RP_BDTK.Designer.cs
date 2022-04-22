namespace FrmMain.cs.Report
{
    partial class Frm_RP_BDTK
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
            this.label5 = new System.Windows.Forms.Label();
            this.labelNienKhoa = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.button_THOAT = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "IN BẢNG ĐIỂM TỔNG KẾT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelNienKhoa
            // 
            this.labelNienKhoa.AutoSize = true;
            this.labelNienKhoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNienKhoa.Location = new System.Drawing.Point(49, 88);
            this.labelNienKhoa.Name = "labelNienKhoa";
            this.labelNienKhoa.Size = new System.Drawing.Size(63, 19);
            this.labelNienKhoa.TabIndex = 24;
            this.labelNienKhoa.Text = "Mã Lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMalop.Location = new System.Drawing.Point(144, 85);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(258, 23);
            this.txtMalop.TabIndex = 23;
            // 
            // button_THOAT
            // 
            this.button_THOAT.BackColor = System.Drawing.Color.LightCoral;
            this.button_THOAT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THOAT.Location = new System.Drawing.Point(279, 186);
            this.button_THOAT.Name = "button_THOAT";
            this.button_THOAT.Size = new System.Drawing.Size(75, 33);
            this.button_THOAT.TabIndex = 22;
            this.button_THOAT.Text = "THOÁT";
            this.button_THOAT.UseVisualStyleBackColor = false;
            this.button_THOAT.Click += new System.EventHandler(this.button_THOAT_Click);
            // 
            // button_IN
            // 
            this.button_IN.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(171, 186);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(75, 33);
            this.button_IN.TabIndex = 21;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // Frm_RP_BDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 268);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNienKhoa);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.button_THOAT);
            this.Controls.Add(this.button_IN);
            this.Name = "Frm_RP_BDTK";
            this.Text = "BẢNG ĐIỂM TỔNG KẾT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNienKhoa;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Button button_THOAT;
        private System.Windows.Forms.Button button_IN;

    }
}