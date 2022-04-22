
namespace FrmMain.cs
{
    partial class FrmDangKy
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMessage = new System.Windows.Forms.Label();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new FrmMain.cs.DS();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.spinHK = new DevExpress.XtraEditors.SpinEdit();
            this.txtSV = new System.Windows.Forms.TextBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new FrmMain.cs.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new FrmMain.cs.DSTableAdapters.TableAdapterManager();
            this.lOPTINCHITableAdapter = new FrmMain.cs.DSTableAdapters.LOPTINCHITableAdapter();
            this.gcDSLTC = new DevExpress.XtraGrid.GridControl();
            this.gvDSLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gcDieuKhien = new DevExpress.XtraEditors.GroupControl();
            this.btnDel = new System.Windows.Forms.Button();
            this.gcDSDKMH = new DevExpress.XtraGrid.GridControl();
            this.DSDKMH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHOMDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDKMH = new System.Windows.Forms.Button();
            this.txtMALTC = new System.Windows.Forms.TextBox();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LTC = new DevExpress.XtraGrid.Columns.GridColumn();
            mASVLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDieuKhien)).BeginInit();
            this.gcDieuKhien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDKMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDKMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(92, 23);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(121, 19);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MÃ SINH VIÊN:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(484, 85);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(66, 19);
            hOCKYLabel.TabIndex = 1;
            hOCKYLabel.Text = "HỌC KỲ";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(92, 86);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(94, 19);
            nIENKHOALabel.TabIndex = 5;
            nIENKHOALabel.Text = "NIÊN KHOÁ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtMessage);
            this.panelControl1.Controls.Add(nIENKHOALabel);
            this.panelControl1.Controls.Add(this.txtNienKhoa);
            this.panelControl1.Controls.Add(hOCKYLabel);
            this.panelControl1.Controls.Add(this.btnXacNhan);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.spinHK);
            this.panelControl1.Controls.Add(mASVLabel);
            this.panelControl1.Controls.Add(this.txtSV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1880, 129);
            this.panelControl1.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(648, 29);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(102, 19);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.Text = "THÔNG TIN:";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(238, 83);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(207, 27);
            this.txtNienKhoa.TabIndex = 6;
            this.txtNienKhoa.TextChanged += new System.EventHandler(this.nIENKHOATextBox_TextChanged);
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.lOPTINCHIBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(665, 79);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 32);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Tìm";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spinHK
            // 
            this.spinHK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPTINCHIBindingSource, "HOCKY", true));
            this.spinHK.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinHK.Location = new System.Drawing.Point(559, 82);
            this.spinHK.Name = "spinHK";
            this.spinHK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinHK.Size = new System.Drawing.Size(80, 28);
            this.spinHK.TabIndex = 2;
            // 
            // txtSV
            // 
            this.txtSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "MASV", true));
            this.txtSV.Location = new System.Drawing.Point(238, 23);
            this.txtSV.Name = "txtSV";
            this.txtSV.Size = new System.Drawing.Size(207, 27);
            this.txtSV.TabIndex = 1;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = FrmMain.cs.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // gcDSLTC
            // 
            this.gcDSLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSLTC.Location = new System.Drawing.Point(0, 129);
            this.gcDSLTC.MainView = this.gvDSLTC;
            this.gcDSLTC.Name = "gcDSLTC";
            this.gcDSLTC.Size = new System.Drawing.Size(1880, 305);
            this.gcDSLTC.TabIndex = 1;
            this.gcDSLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSLTC});
            this.gcDSLTC.Click += new System.EventHandler(this.gcDSLTC_Click);
            this.gcDSLTC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gcDSLTC_MouseClick);
            // 
            // gvDSLTC
            // 
            this.gvDSLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH,
            this.TENMH,
            this.NHOM,
            this.HOTEN,
            this.SL,
            this.MALTC});
            this.gvDSLTC.GridControl = this.gcDSLTC;
            this.gvDSLTC.Name = "gvDSLTC";
            this.gvDSLTC.ViewCaption = "DANH SÁCH LỚP TÍN CHỈ";
            // 
            // MAMH
            // 
            this.MAMH.Caption = "MÃ MÔN HỌC";
            this.MAMH.FieldName = "MAMH";
            this.MAMH.MinWidth = 30;
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 0;
            this.MAMH.Width = 112;
            // 
            // TENMH
            // 
            this.TENMH.Caption = "TÊN MÔN HỌC";
            this.TENMH.FieldName = "TENMH";
            this.TENMH.MinWidth = 30;
            this.TENMH.Name = "TENMH";
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 1;
            this.TENMH.Width = 112;
            // 
            // NHOM
            // 
            this.NHOM.Caption = "NHÓM";
            this.NHOM.FieldName = "NHOM";
            this.NHOM.MinWidth = 30;
            this.NHOM.Name = "NHOM";
            this.NHOM.Visible = true;
            this.NHOM.VisibleIndex = 2;
            this.NHOM.Width = 112;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN GV";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MinWidth = 30;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 3;
            this.HOTEN.Width = 112;
            // 
            // SL
            // 
            this.SL.Caption = "SỐ LƯỢNG";
            this.SL.FieldName = "SL";
            this.SL.MinWidth = 30;
            this.SL.Name = "SL";
            this.SL.Visible = true;
            this.SL.VisibleIndex = 4;
            this.SL.Width = 112;
            // 
            // MALTC
            // 
            this.MALTC.Caption = "MALTC";
            this.MALTC.FieldName = "MALTC";
            this.MALTC.MinWidth = 30;
            this.MALTC.Name = "MALTC";
            this.MALTC.Visible = true;
            this.MALTC.VisibleIndex = 5;
            this.MALTC.Width = 112;
            // 
            // gcDieuKhien
            // 
            this.gcDieuKhien.Controls.Add(this.btnDel);
            this.gcDieuKhien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDieuKhien.Location = new System.Drawing.Point(0, 434);
            this.gcDieuKhien.Name = "gcDieuKhien";
            this.gcDieuKhien.Size = new System.Drawing.Size(1880, 93);
            this.gcDieuKhien.TabIndex = 3;
            this.gcDieuKhien.Text = "Điều Khiển";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1681, 37);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 51);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "HUỶ ĐĂNG KÝ";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // gcDSDKMH
            // 
            this.gcDSDKMH.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcDSDKMH.Location = new System.Drawing.Point(408, 527);
            this.gcDSDKMH.MainView = this.DSDKMH;
            this.gcDSDKMH.Name = "gcDSDKMH";
            this.gcDSDKMH.Size = new System.Drawing.Size(1472, 295);
            this.gcDSDKMH.TabIndex = 5;
            this.gcDSDKMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DSDKMH});
            // 
            // DSDKMH
            // 
            this.DSDKMH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MH,
            this.TENM,
            this.NHOMDK,
            this.LTC});
            this.DSDKMH.GridControl = this.gcDSDKMH;
            this.DSDKMH.Name = "DSDKMH";
            this.DSDKMH.OptionsView.ShowViewCaption = true;
            this.DSDKMH.ViewCaption = "DANH SÁCH LỚP TÍN CHỈ ĐÃ ĐĂNG KÝ";
            // 
            // MH
            // 
            this.MH.Caption = "MÃ MÔN HỌC";
            this.MH.FieldName = "MAMH";
            this.MH.MinWidth = 30;
            this.MH.Name = "MH";
            this.MH.Visible = true;
            this.MH.VisibleIndex = 0;
            this.MH.Width = 112;
            // 
            // TENM
            // 
            this.TENM.Caption = "TÊN MÔN HỌC";
            this.TENM.FieldName = "TENMH";
            this.TENM.MinWidth = 30;
            this.TENM.Name = "TENM";
            this.TENM.Visible = true;
            this.TENM.VisibleIndex = 1;
            this.TENM.Width = 112;
            // 
            // NHOMDK
            // 
            this.NHOMDK.Caption = "NHÓM";
            this.NHOMDK.FieldName = "NHOM";
            this.NHOMDK.MinWidth = 30;
            this.NHOMDK.Name = "NHOMDK";
            this.NHOMDK.Visible = true;
            this.NHOMDK.VisibleIndex = 2;
            this.NHOMDK.Width = 112;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnDKMH);
            this.panelControl2.Controls.Add(this.txtMALTC);
            this.panelControl2.Controls.Add(this.txtMASV);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 527);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(402, 295);
            this.panelControl2.TabIndex = 6;
            // 
            // btnDKMH
            // 
            this.btnDKMH.Location = new System.Drawing.Point(113, 178);
            this.btnDKMH.Name = "btnDKMH";
            this.btnDKMH.Size = new System.Drawing.Size(90, 49);
            this.btnDKMH.TabIndex = 5;
            this.btnDKMH.Text = "ĐĂNG KÝ";
            this.btnDKMH.UseVisualStyleBackColor = true;
            this.btnDKMH.Click += new System.EventHandler(this.btnDKMH_Click);
            // 
            // txtMALTC
            // 
            this.txtMALTC.Enabled = false;
            this.txtMALTC.Location = new System.Drawing.Point(113, 125);
            this.txtMALTC.Name = "txtMALTC";
            this.txtMALTC.Size = new System.Drawing.Size(207, 27);
            this.txtMALTC.TabIndex = 4;
            // 
            // txtMASV
            // 
            this.txtMASV.Enabled = false;
            this.txtMASV.Location = new System.Drawing.Point(113, 76);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(207, 27);
            this.txtMASV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "MÃ LTC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ SV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ MÔN HỌC";
            // 
            // LTC
            // 
            this.LTC.Caption = "MALTC";
            this.LTC.FieldName = "MALTC";
            this.LTC.MinWidth = 30;
            this.LTC.Name = "LTC";
            this.LTC.Visible = true;
            this.LTC.VisibleIndex = 3;
            this.LTC.Width = 112;
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1880, 822);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcDSDKMH);
            this.Controls.Add(this.gcDieuKhien);
            this.Controls.Add(this.gcDSLTC);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmDangKy";
            this.Text = "FrmDangKy";
            this.Load += new System.EventHandler(this.FrmDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDieuKhien)).EndInit();
            this.gcDieuKhien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDKMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSDKMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSV;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private DevExpress.XtraEditors.SpinEdit spinHK;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label txtMessage;
        private DevExpress.XtraGrid.GridControl gcDSLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSLTC;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraGrid.Columns.GridColumn NHOM;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn SL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.GroupControl gcDieuKhien;
        private System.Windows.Forms.Button btnDel;
        private DevExpress.XtraGrid.Columns.GridColumn MALTC;
        private DevExpress.XtraGrid.GridControl gcDSDKMH;
        private DevExpress.XtraGrid.Views.Grid.GridView DSDKMH;
        private DevExpress.XtraGrid.Columns.GridColumn MH;
        private DevExpress.XtraGrid.Columns.GridColumn TENM;
        private DevExpress.XtraGrid.Columns.GridColumn NHOMDK;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDKMH;
        private System.Windows.Forms.TextBox txtMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn LTC;
    }
}