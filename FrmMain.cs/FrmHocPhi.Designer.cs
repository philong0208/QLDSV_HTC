
namespace FrmMain.cs
{
    partial class FrmHocPhi
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHocPhi));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManagerLop = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.Reload = new DevExpress.XtraBars.BarButtonItem();
            this.gcSINHVIEN = new DevExpress.XtraEditors.GroupControl();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtHOTEN = new DevExpress.XtraEditors.TextEdit();
            this.cmbMASV = new DevExpress.XtraEditors.LookUpEdit();
            this.lblHOTEN = new System.Windows.Forms.Label();
            this.lblMASV = new System.Windows.Forms.Label();
            this.DS = new FrmMain.cs.DS();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.SINHVIENTableAdapter = new FrmMain.cs.DSTableAdapters.SINHVIENTableAdapter();
            this.groupTTHocPhi = new DevExpress.XtraEditors.GroupControl();
            this.txtSoTienDaDong = new DevExpress.XtraEditors.TextEdit();
            this.txtHocPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.txtNienKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.HOCPHITableAdapter = new FrmMain.cs.DSTableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new FrmMain.cs.DSTableAdapters.TableAdapterManager();
            this.gcTTHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gridViewHocPhi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsTTHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.gET_THONGTIN_HOCPHI_SVTableAdapter = new FrmMain.cs.DSTableAdapters.GET_THONGTIN_HOCPHI_SVTableAdapter();
            this.hOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            nIENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSINHVIEN)).BeginInit();
            this.gcSINHVIEN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTTHocPhi)).BeginInit();
            this.groupTTHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTTHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(272, 57);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(0, 13);
            nIENKHOALabel.TabIndex = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManagerLop
            // 
            this.barManagerLop.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManagerLop.DockControls.Add(this.barDockControlTop);
            this.barManagerLop.DockControls.Add(this.barDockControlBottom);
            this.barManagerLop.DockControls.Add(this.barDockControlLeft);
            this.barManagerLop.DockControls.Add(this.barDockControlRight);
            this.barManagerLop.Form = this;
            this.barManagerLop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDel,
            this.btnEdit,
            this.barButtonItem4,
            this.btnSave,
            this.btnReload,
            this.Reload,
            this.btnExit,
            this.btnSua});
            this.barManagerLop.MainMenu = this.bar3;
            this.barManagerLop.MaxItemId = 12;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Ghi";
            this.btnSave.Id = 4;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 10;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerLop;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(840, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 569);
            this.barDockControlBottom.Manager = this.barManagerLop;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(840, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerLop;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 545);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(840, 24);
            this.barDockControlRight.Manager = this.barManagerLop;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 545);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xoá";
            this.btnDel.Id = 1;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.LargeImage")));
            this.btnDel.Name = "btnDel";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Hiệu Chỉnh";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ghi";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Làm mới";
            this.btnReload.Id = 8;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            // 
            // Reload
            // 
            this.Reload.Caption = "Reload";
            this.Reload.Id = 9;
            this.Reload.Name = "Reload";
            // 
            // gcSINHVIEN
            // 
            this.gcSINHVIEN.Controls.Add(this.txtMALOP);
            this.gcSINHVIEN.Controls.Add(this.lblMaLop);
            this.gcSINHVIEN.Controls.Add(this.txtHOTEN);
            this.gcSINHVIEN.Controls.Add(this.cmbMASV);
            this.gcSINHVIEN.Controls.Add(this.lblHOTEN);
            this.gcSINHVIEN.Controls.Add(this.lblMASV);
            this.gcSINHVIEN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSINHVIEN.Location = new System.Drawing.Point(0, 24);
            this.gcSINHVIEN.Name = "gcSINHVIEN";
            this.gcSINHVIEN.Size = new System.Drawing.Size(840, 66);
            this.gcSINHVIEN.TabIndex = 4;
            this.gcSINHVIEN.Text = "THÔNG TIN SINH VIÊN";
            // 
            // txtMALOP
            // 
            this.txtMALOP.Location = new System.Drawing.Point(632, 33);
            this.txtMALOP.MenuManager = this.barManagerLop;
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.ReadOnly = true;
            this.txtMALOP.Size = new System.Drawing.Size(100, 20);
            this.txtMALOP.TabIndex = 6;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(581, 36);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(45, 13);
            this.lblMaLop.TabIndex = 5;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(363, 33);
            this.txtHOTEN.MenuManager = this.barManagerLop;
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Properties.ReadOnly = true;
            this.txtHOTEN.Size = new System.Drawing.Size(156, 20);
            this.txtHOTEN.TabIndex = 3;
            // 
            // cmbMASV
            // 
            this.cmbMASV.Location = new System.Drawing.Point(121, 33);
            this.cmbMASV.MenuManager = this.barManagerLop;
            this.cmbMASV.Name = "cmbMASV";
            this.cmbMASV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMASV.Properties.NullText = "";
            this.cmbMASV.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.cmbMASV.Properties.EditValueChanged += new System.EventHandler(this.lookUpEdit1_Properties_EditValueChanged);
            this.cmbMASV.Size = new System.Drawing.Size(130, 20);
            this.cmbMASV.TabIndex = 2;
            // 
            // lblHOTEN
            // 
            this.lblHOTEN.AutoSize = true;
            this.lblHOTEN.Location = new System.Drawing.Point(282, 36);
            this.lblHOTEN.Name = "lblHOTEN";
            this.lblHOTEN.Size = new System.Drawing.Size(75, 13);
            this.lblHOTEN.TabIndex = 1;
            this.lblHOTEN.Text = "Tên Sinh Viên:";
            // 
            // lblMASV
            // 
            this.lblMASV.AutoSize = true;
            this.lblMASV.Location = new System.Drawing.Point(44, 36);
            this.lblMASV.Name = "lblMASV";
            this.lblMASV.Size = new System.Drawing.Size(71, 13);
            this.lblMASV.TabIndex = 0;
            this.lblMASV.Text = "Mã Sinh Viên:";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.DS;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // groupTTHocPhi
            // 
            this.groupTTHocPhi.Controls.Add(this.txtSoTienDaDong);
            this.groupTTHocPhi.Controls.Add(this.txtHocPhi);
            this.groupTTHocPhi.Controls.Add(this.txtHocKy);
            this.groupTTHocPhi.Controls.Add(this.txtNienKhoa);
            this.groupTTHocPhi.Controls.Add(nIENKHOALabel);
            this.groupTTHocPhi.Controls.Add(this.label4);
            this.groupTTHocPhi.Controls.Add(this.label3);
            this.groupTTHocPhi.Controls.Add(this.lblHocKy);
            this.groupTTHocPhi.Controls.Add(this.lblNienKhoa);
            this.groupTTHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTTHocPhi.Enabled = false;
            this.groupTTHocPhi.Location = new System.Drawing.Point(0, 90);
            this.groupTTHocPhi.Name = "groupTTHocPhi";
            this.groupTTHocPhi.Size = new System.Drawing.Size(840, 145);
            this.groupTTHocPhi.TabIndex = 9;
            this.groupTTHocPhi.Text = "THÔNG TIN HỌC PHÍ";
            // 
            // txtSoTienDaDong
            // 
            this.txtSoTienDaDong.Location = new System.Drawing.Point(396, 95);
            this.txtSoTienDaDong.MenuManager = this.barManagerLop;
            this.txtSoTienDaDong.Name = "txtSoTienDaDong";
            this.txtSoTienDaDong.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoTienDaDong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienDaDong.Size = new System.Drawing.Size(123, 20);
            this.txtSoTienDaDong.TabIndex = 19;
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Location = new System.Drawing.Point(121, 95);
            this.txtHocPhi.MenuManager = this.barManagerLop;
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Properties.DisplayFormat.FormatString = "n0";
            this.txtHocPhi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHocPhi.Size = new System.Drawing.Size(130, 20);
            this.txtHocPhi.TabIndex = 18;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(396, 45);
            this.txtHocKy.MenuManager = this.barManagerLop;
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.DisplayFormat.FormatString = "n0";
            this.txtHocKy.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtHocKy.Size = new System.Drawing.Size(123, 20);
            this.txtHocKy.TabIndex = 17;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(121, 44);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(130, 21);
            this.txtNienKhoa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Tiền Đóng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học Phí:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(346, 48);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(44, 13);
            this.lblHocKy.TabIndex = 1;
            this.lblHocKy.Text = "Học Kỳ:";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(56, 48);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(59, 13);
            this.lblNienKhoa.TabIndex = 0;
            this.lblNienKhoa.Text = "Niên Khóa:";
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.AllowNew = true;
            this.bdsHocPhi.DataSource = this.bdsSinhVien;
            // 
            // HOCPHITableAdapter
            // 
            this.HOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.HOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.SINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = FrmMain.cs.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTTHocPhi
            // 
            this.gcTTHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTTHocPhi.Location = new System.Drawing.Point(0, 235);
            this.gcTTHocPhi.MainView = this.gridViewHocPhi;
            this.gcTTHocPhi.MenuManager = this.barManagerLop;
            this.gcTTHocPhi.Name = "gcTTHocPhi";
            this.gcTTHocPhi.Size = new System.Drawing.Size(840, 334);
            this.gcTTHocPhi.TabIndex = 13;
            this.gcTTHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHocPhi});
            // 
            // gridViewHocPhi
            // 
            this.gridViewHocPhi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDONG});
            this.gridViewHocPhi.GridControl = this.gcTTHocPhi;
            this.gridViewHocPhi.Name = "gridViewHocPhi";
            this.gridViewHocPhi.OptionsBehavior.ReadOnly = true;
            this.gridViewHocPhi.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewHocPhi_RowCellClick);
            this.gridViewHocPhi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewHocPhi_FocusedRowChanged);
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "NIÊN KHÓA";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "HỌC KỲ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "HỌC PHÍ";
            this.colHOCPHI.DisplayFormat.FormatString = "n0";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.Caption = "SỐ TIỀN ĐÃ ĐÓNG";
            this.colSOTIENDONG.DisplayFormat.FormatString = "n0";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 3;
            // 
            // bdsTTHocPhi
            // 
            this.bdsTTHocPhi.DataMember = "GET_THONGTIN_HOCPHI_SV";
            this.bdsTTHocPhi.DataSource = this.DS;
            // 
            // gET_THONGTIN_HOCPHI_SVTableAdapter
            // 
            this.gET_THONGTIN_HOCPHI_SVTableAdapter.ClearBeforeFill = true;
            // 
            // hOCPHIBindingSource
            // 
            this.hOCPHIBindingSource.DataMember = "FK_HOCPHI_SINHVIEN";
            this.hOCPHIBindingSource.DataSource = this.bdsHocPhi;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 11;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // FrmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 569);
            this.Controls.Add(this.gcTTHocPhi);
            this.Controls.Add(this.groupTTHocPhi);
            this.Controls.Add(this.gcSINHVIEN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmHocPhi";
            this.Text = "FrmHocPhi";
            this.Load += new System.EventHandler(this.FrmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSINHVIEN)).EndInit();
            this.gcSINHVIEN.ResumeLayout(false);
            this.gcSINHVIEN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTTHocPhi)).EndInit();
            this.groupTTHocPhi.ResumeLayout(false);
            this.groupTTHocPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTTHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCPHIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManagerLop;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem Reload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraEditors.GroupControl gcSINHVIEN;
        private System.Windows.Forms.Label lblHOTEN;
        private System.Windows.Forms.Label lblMASV;
        private DevExpress.XtraEditors.LookUpEdit cmbMASV;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private System.Windows.Forms.Label lblMaLop;
        private DevExpress.XtraEditors.TextEdit txtHOTEN;
        private DevExpress.XtraEditors.GroupControl groupTTHocPhi;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private DSTableAdapters.HOCPHITableAdapter HOCPHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNienKhoa;
        private DevExpress.XtraGrid.GridControl gcTTHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHocPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private System.Windows.Forms.BindingSource bdsTTHocPhi;
        private DSTableAdapters.GET_THONGTIN_HOCPHI_SVTableAdapter gET_THONGTIN_HOCPHI_SVTableAdapter;
        private System.Windows.Forms.BindingSource hOCPHIBindingSource;
        private System.Windows.Forms.TextBox txtNienKhoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.TextEdit txtSoTienDaDong;
        private DevExpress.XtraEditors.TextEdit txtHocPhi;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private DevExpress.XtraBars.BarButtonItem btnSua;
    }
}