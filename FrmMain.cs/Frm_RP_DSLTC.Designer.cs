namespace FrmMain.cs.Report
{
    partial class Frm_RP_DSLTC
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
            this.labelHocKi = new System.Windows.Forms.Label();
            this.labelNienKhoa = new System.Windows.Forms.Label();
            this.txtHocKi = new System.Windows.Forms.TextBox();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.button_THOAT = new System.Windows.Forms.Button();
            this.button_IN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "IN DANH SÁCH LỚP TÍN CHỈ";
            // 
            // labelHocKi
            // 
            this.labelHocKi.AutoSize = true;
            this.labelHocKi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHocKi.Location = new System.Drawing.Point(81, 140);
            this.labelHocKi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHocKi.Name = "labelHocKi";
            this.labelHocKi.Size = new System.Drawing.Size(90, 28);
            this.labelHocKi.TabIndex = 26;
            this.labelHocKi.Text = "Học Kì";
            // 
            // labelNienKhoa
            // 
            this.labelNienKhoa.AutoSize = true;
            this.labelNienKhoa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNienKhoa.Location = new System.Drawing.Point(81, 102);
            this.labelNienKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNienKhoa.Name = "labelNienKhoa";
            this.labelNienKhoa.Size = new System.Drawing.Size(129, 28);
            this.labelNienKhoa.TabIndex = 25;
            this.labelNienKhoa.Text = "Niên Khóa";
            // 
            // txtHocKi
            // 
            this.txtHocKi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKi.Location = new System.Drawing.Point(224, 136);
            this.txtHocKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Size = new System.Drawing.Size(385, 30);
            this.txtHocKi.TabIndex = 24;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNienKhoa.Location = new System.Drawing.Point(224, 98);
            this.txtNienKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(385, 30);
            this.txtNienKhoa.TabIndex = 23;
            // 
            // button_THOAT
            // 
            this.button_THOAT.BackColor = System.Drawing.Color.LightCoral;
            this.button_THOAT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_THOAT.Location = new System.Drawing.Point(426, 246);
            this.button_THOAT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_THOAT.Name = "button_THOAT";
            this.button_THOAT.Size = new System.Drawing.Size(112, 48);
            this.button_THOAT.TabIndex = 22;
            this.button_THOAT.Text = "THOÁT";
            this.button_THOAT.UseVisualStyleBackColor = false;
            this.button_THOAT.Click += new System.EventHandler(this.button_THOAT_Click);
            // 
            // button_IN
            // 
            this.button_IN.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_IN.Location = new System.Drawing.Point(264, 246);
            this.button_IN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_IN.Name = "button_IN";
            this.button_IN.Size = new System.Drawing.Size(112, 48);
            this.button_IN.TabIndex = 21;
            this.button_IN.Text = "IN";
            this.button_IN.UseVisualStyleBackColor = false;
            this.button_IN.Click += new System.EventHandler(this.button_IN_Click);
            // 
            // Frm_RP_DSLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelHocKi);
            this.Controls.Add(this.labelNienKhoa);
            this.Controls.Add(this.txtHocKi);
            this.Controls.Add(this.txtNienKhoa);
            this.Controls.Add(this.button_THOAT);
            this.Controls.Add(this.button_IN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_RP_DSLTC";
            this.Text = "DANH SÁCH LỚP TÍN CHỈ";
            this.Load += new System.EventHandler(this.Frm_RP_DSLTC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelHocKi;
        private System.Windows.Forms.Label labelNienKhoa;
        private System.Windows.Forms.TextBox txtHocKi;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.Button button_THOAT;
        private System.Windows.Forms.Button button_IN;
    }
}