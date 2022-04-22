namespace FrmMain.cs.Report
{
    partial class Frm_RP_DSDHP
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
            this.button_THOAT = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtHocKi = new System.Windows.Forms.TextBox();
            this.txtNienkhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "IN DANH SÁCH ĐÓNG HỌC PHÍ";
            // 
            // button_THOAT
            // 
            this.button_THOAT.BackColor = System.Drawing.Color.LightCoral;
            this.button_THOAT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THOAT.Location = new System.Drawing.Point(447, 173);
            this.button_THOAT.Name = "button_THOAT";
            this.button_THOAT.Size = new System.Drawing.Size(75, 33);
            this.button_THOAT.TabIndex = 37;
            this.button_THOAT.Text = "THOÁT";
            this.button_THOAT.UseVisualStyleBackColor = false;
            this.button_THOAT.Click += new System.EventHandler(this.button_THOAT_Click);
            // 
            // button_IN
            // 
            this.button_IN.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(447, 89);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(75, 33);
            this.button_IN.TabIndex = 36;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(183, 184);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(207, 26);
            this.txtMaLop.TabIndex = 33;
            // 
            // txtHocKi
            // 
            this.txtHocKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKi.Location = new System.Drawing.Point(183, 133);
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Size = new System.Drawing.Size(207, 26);
            this.txtHocKi.TabIndex = 34;
            // 
            // txtNienkhoa
            // 
            this.txtNienkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienkhoa.Location = new System.Drawing.Point(183, 89);
            this.txtNienkhoa.Name = "txtNienkhoa";
            this.txtNienkhoa.Size = new System.Drawing.Size(207, 26);
            this.txtNienkhoa.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mã Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Niên khóa";
            // 
            // Frm_RP_DSDHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 268);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_THOAT);
            this.Controls.Add(this.button_IN);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtHocKi);
            this.Controls.Add(this.txtNienkhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_RP_DSDHP";
            this.Text = "DANH SÁCH ĐÓNG HỌC PHÍ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_THOAT;
        private System.Windows.Forms.Button button_IN;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtHocKi;
        private System.Windows.Forms.TextBox txtNienkhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}