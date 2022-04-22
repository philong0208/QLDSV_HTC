
namespace FrmMain.cs
{
    partial class FrmDiem
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
            System.Windows.Forms.Label tENMHLabel;
            this.groupControlThongtin = new DevExpress.XtraEditors.GroupControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.spinNhom = new DevExpress.XtraEditors.SpinEdit();
            this.spinHK = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new FrmMain.cs.DS();
            this.gcDieuKhien = new DevExpress.XtraEditors.GroupControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.gcDiem = new DevExpress.XtraGrid.GridControl();
            this.gvDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongtin)).BeginInit();
            this.groupControlThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDieuKhien)).BeginInit();
            this.gcDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(109, 178);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(88, 19);
            tENMHLabel.TabIndex = 6;
            tENMHLabel.Text = "MÔN HỌC:";
            // 
            // groupControlThongtin
            // 
            this.groupControlThongtin.Controls.Add(this.cmbMonHoc);
            this.groupControlThongtin.Controls.Add(this.cmbKhoa);
            this.groupControlThongtin.Controls.Add(tENMHLabel);
            this.groupControlThongtin.Controls.Add(this.spinNhom);
            this.groupControlThongtin.Controls.Add(this.spinHK);
            this.groupControlThongtin.Controls.Add(this.label2);
            this.groupControlThongtin.Controls.Add(this.label4);
            this.groupControlThongtin.Controls.Add(this.txtNienKhoa);
            this.groupControlThongtin.Controls.Add(this.label3);
            this.groupControlThongtin.Controls.Add(this.label1);
            this.groupControlThongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlThongtin.Location = new System.Drawing.Point(0, 0);
            this.groupControlThongtin.Name = "groupControlThongtin";
            this.groupControlThongtin.Size = new System.Drawing.Size(1365, 244);
            this.groupControlThongtin.TabIndex = 0;
            this.groupControlThongtin.Text = "Thông Tin";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(241, 57);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(303, 27);
            this.cmbKhoa.TabIndex = 8;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // spinNhom
            // 
            this.spinNhom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNhom.Location = new System.Drawing.Point(757, 174);
            this.spinNhom.Name = "spinNhom";
            this.spinNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNhom.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinNhom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNhom.Size = new System.Drawing.Size(68, 28);
            this.spinNhom.TabIndex = 2;
            // 
            // spinHK
            // 
            this.spinHK.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHK.Location = new System.Drawing.Point(757, 110);
            this.spinHK.Name = "spinHK";
            this.spinHK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHK.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinHK.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHK.Size = new System.Drawing.Size(68, 28);
            this.spinHK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "KHOA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "NHÓM";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(241, 110);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(303, 27);
            this.txtNienKhoa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "HỌC KÌ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIÊN KHOÁ";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gcDieuKhien
            // 
            this.gcDieuKhien.Controls.Add(this.btnLuu);
            this.gcDieuKhien.Controls.Add(this.btnNhap);
            this.gcDieuKhien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDieuKhien.Location = new System.Drawing.Point(0, 244);
            this.gcDieuKhien.Name = "gcDieuKhien";
            this.gcDieuKhien.Size = new System.Drawing.Size(1365, 113);
            this.gcDieuKhien.TabIndex = 2;
            this.gcDieuKhien.Text = "Điều Khiển";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(218, 47);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 46);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(44, 47);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(117, 46);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Bắt đầu";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // gcDiem
            // 
            this.gcDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiem.Location = new System.Drawing.Point(0, 357);
            this.gcDiem.MainView = this.gvDiem;
            this.gcDiem.Name = "gcDiem";
            this.gcDiem.Size = new System.Drawing.Size(1365, 414);
            this.gcDiem.TabIndex = 3;
            this.gcDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiem});
            this.gcDiem.Click += new System.EventHandler(this.gcDiem_Click);
            // 
            // gvDiem
            // 
            this.gvDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MASV,
            this.HOTEN,
            this.DIEM_CC,
            this.DIEM_GK,
            this.DIEM_CK,
            this.DIEMTK});
            this.gvDiem.GridControl = this.gcDiem;
            this.gvDiem.Name = "gvDiem";
            this.gvDiem.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvDiem.ViewCaption = "BẢNG ĐIỂM MÔN HỌC";
            this.gvDiem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvDiem_RowCellStyle);
            this.gvDiem.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvDiem_ValidatingEditor);
            // 
            // MASV
            // 
            this.MASV.Caption = "MÃ SV";
            this.MASV.FieldName = "MASV";
            this.MASV.MinWidth = 30;
            this.MASV.Name = "MASV";
            this.MASV.OptionsColumn.ReadOnly = true;
            this.MASV.Visible = true;
            this.MASV.VisibleIndex = 0;
            this.MASV.Width = 112;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MinWidth = 30;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.OptionsColumn.ReadOnly = true;
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 112;
            // 
            // DIEM_CC
            // 
            this.DIEM_CC.AppearanceCell.Options.UseTextOptions = true;
            this.DIEM_CC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIEM_CC.Caption = "ĐIỂM CC";
            this.DIEM_CC.FieldName = "DIEM_CC";
            this.DIEM_CC.MinWidth = 30;
            this.DIEM_CC.Name = "DIEM_CC";
            this.DIEM_CC.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.DIEM_CC.Visible = true;
            this.DIEM_CC.VisibleIndex = 2;
            this.DIEM_CC.Width = 112;
            // 
            // DIEM_GK
            // 
            this.DIEM_GK.AppearanceCell.Options.UseTextOptions = true;
            this.DIEM_GK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIEM_GK.Caption = "ĐIỂM GK";
            this.DIEM_GK.FieldName = "DIEM_GK";
            this.DIEM_GK.MinWidth = 30;
            this.DIEM_GK.Name = "DIEM_GK";
            this.DIEM_GK.UnboundExpression = "Round([DIEM_GK] * 2) / 2";
            this.DIEM_GK.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.DIEM_GK.Visible = true;
            this.DIEM_GK.VisibleIndex = 3;
            this.DIEM_GK.Width = 112;
            // 
            // DIEM_CK
            // 
            this.DIEM_CK.AppearanceCell.Options.UseTextOptions = true;
            this.DIEM_CK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DIEM_CK.Caption = "ĐIỂM CK";
            this.DIEM_CK.FieldName = "DIEM_CK";
            this.DIEM_CK.MinWidth = 30;
            this.DIEM_CK.Name = "DIEM_CK";
            this.DIEM_CK.Visible = true;
            this.DIEM_CK.VisibleIndex = 4;
            this.DIEM_CK.Width = 112;
            // 
            // DIEMTK
            // 
            this.DIEMTK.Caption = "ĐIỂM HẾT MÔN";
            this.DIEMTK.FieldName = "DIEMTK";
            this.DIEMTK.MinWidth = 30;
            this.DIEMTK.Name = "DIEMTK";
            this.DIEMTK.OptionsColumn.ReadOnly = true;
            this.DIEMTK.UnboundExpression = "Round([DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6, 1)";
            this.DIEMTK.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.DIEMTK.Visible = true;
            this.DIEMTK.VisibleIndex = 5;
            this.DIEMTK.Width = 112;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(241, 168);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(303, 27);
            this.cmbMonHoc.TabIndex = 9;
            // 
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 771);
            this.Controls.Add(this.gcDiem);
            this.Controls.Add(this.gcDieuKhien);
            this.Controls.Add(this.groupControlThongtin);
            this.Name = "FrmDiem";
            this.Text = "FrmDiem";
            this.Load += new System.EventHandler(this.FrmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongtin)).EndInit();
            this.groupControlThongtin.ResumeLayout(false);
            this.groupControlThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDieuKhien)).EndInit();
            this.gcDieuKhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlThongtin;
        private DevExpress.XtraEditors.SpinEdit spinHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private DevExpress.XtraEditors.SpinEdit spinNhom;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl gcDieuKhien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhap;
        private DevExpress.XtraGrid.GridControl gcDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiem;
        private DevExpress.XtraGrid.Columns.GridColumn MASV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CK;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMTK;
        private System.Windows.Forms.ComboBox cmbMonHoc;
    }
}