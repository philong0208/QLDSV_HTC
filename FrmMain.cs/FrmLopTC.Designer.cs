
namespace FrmMain.cs
{
    partial class FrmLopTC
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
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label hUYLOPLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLopTC));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.Reload = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbTenPhongBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new FrmMain.cs.DS();
            this.bdsLopTC = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new FrmMain.cs.DSTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new FrmMain.cs.DSTableAdapters.TableAdapterManager();
            this.gcLopTC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcLopTC = new DevExpress.XtraEditors.PanelControl();
            this.cmbGV = new System.Windows.Forms.ComboBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.cbHuyLop = new DevExpress.XtraEditors.CheckEdit();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.spinNhom = new DevExpress.XtraEditors.SpinEdit();
            this.spinHK = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new FrmMain.cs.DSTableAdapters.DANGKYTableAdapter();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLopTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLopTC)).BeginInit();
            this.pcLopTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHuyLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(28, 66);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(94, 19);
            nIENKHOALabel.TabIndex = 0;
            nIENKHOALabel.Text = "NIÊN KHOÁ";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(29, 148);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(66, 19);
            hOCKYLabel.TabIndex = 2;
            hOCKYLabel.Text = "HỌC KỲ";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(28, 314);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(55, 19);
            nHOMLabel.TabIndex = 6;
            nHOMLabel.Text = "NHÓM";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(343, 405);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(80, 19);
            mAKHOALabel.TabIndex = 10;
            mAKHOALabel.Text = "MÃ KHOA";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(29, 490);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(174, 19);
            sOSVTOITHIEULabel.TabIndex = 12;
            sOSVTOITHIEULabel.Text = "SỐ LƯỢNG TỐI THIỂU";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(29, 565);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(75, 19);
            hUYLOPLabel.TabIndex = 14;
            hUYLOPLabel.Text = "HUỶ LỚP";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(34, 231);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(110, 19);
            mAMHLabel.TabIndex = 15;
            mAMHLabel.Text = "MÃ MÔN HỌC";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(33, 405);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(100, 19);
            mAGVLabel.TabIndex = 16;
            mAGVLabel.Text = "GIẢNG VIÊN";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDel,
            this.btnEdit,
            this.barButtonItem4,
            this.btnSave,
            this.btnUndo,
            this.btnExit,
            this.barButtonItem1,
            this.btnReload,
            this.Reload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // btnDel
            // 
            this.btnDel.Caption = "Xoá";
            this.btnDel.Id = 1;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.LargeImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Hiệu Chỉnh";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
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
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Làm mới";
            this.btnReload.Id = 8;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1849, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 712);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1849, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 678);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1849, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 678);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ghi";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 6;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            // 
            // Reload
            // 
            this.Reload.Caption = "Reload";
            this.Reload.Id = 9;
            this.Reload.Name = "Reload";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbTenPhongBan);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1849, 65);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbTenPhongBan
            // 
            this.cmbTenPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenPhongBan.FormattingEnabled = true;
            this.cmbTenPhongBan.Location = new System.Drawing.Point(442, 18);
            this.cmbTenPhongBan.Name = "cmbTenPhongBan";
            this.cmbTenPhongBan.Size = new System.Drawing.Size(319, 27);
            this.cmbTenPhongBan.TabIndex = 1;
            this.cmbTenPhongBan.SelectedIndexChanged += new System.EventHandler(this.cmbTenPhongBan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLopTC
            // 
            this.bdsLopTC.DataMember = "LOPTINCHI";
            this.bdsLopTC.DataSource = this.dS;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrmMain.cs.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcLopTC
            // 
            this.gcLopTC.DataSource = this.bdsLopTC;
            this.gcLopTC.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcLopTC.Location = new System.Drawing.Point(693, 99);
            this.gcLopTC.MainView = this.gridView1;
            this.gcLopTC.MenuManager = this.barManager1;
            this.gcLopTC.Name = "gcLopTC";
            this.gcLopTC.Size = new System.Drawing.Size(1156, 613);
            this.gcLopTC.TabIndex = 6;
            this.gcLopTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.GridControl = this.gcLopTC;
            this.gridView1.Name = "gridView1";
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 30;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 112;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 30;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 112;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 30;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 112;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 112;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 30;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 112;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 30;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 112;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 30;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 112;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 30;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 112;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 30;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 112;
            // 
            // pcLopTC
            // 
            this.pcLopTC.Controls.Add(mAGVLabel);
            this.pcLopTC.Controls.Add(this.cmbGV);
            this.pcLopTC.Controls.Add(mAMHLabel);
            this.pcLopTC.Controls.Add(this.cmbMaMH);
            this.pcLopTC.Controls.Add(hUYLOPLabel);
            this.pcLopTC.Controls.Add(this.cbHuyLop);
            this.pcLopTC.Controls.Add(sOSVTOITHIEULabel);
            this.pcLopTC.Controls.Add(this.txtSL);
            this.pcLopTC.Controls.Add(mAKHOALabel);
            this.pcLopTC.Controls.Add(this.txtMaKhoa);
            this.pcLopTC.Controls.Add(nHOMLabel);
            this.pcLopTC.Controls.Add(this.spinNhom);
            this.pcLopTC.Controls.Add(hOCKYLabel);
            this.pcLopTC.Controls.Add(this.spinHK);
            this.pcLopTC.Controls.Add(nIENKHOALabel);
            this.pcLopTC.Controls.Add(this.txtNienKhoa);
            this.pcLopTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLopTC.Location = new System.Drawing.Point(0, 99);
            this.pcLopTC.Name = "pcLopTC";
            this.pcLopTC.Size = new System.Drawing.Size(693, 613);
            this.pcLopTC.TabIndex = 11;
            // 
            // cmbGV
            // 
            this.cmbGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTC, "MAGV", true));
            this.cmbGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGV.FormattingEnabled = true;
            this.cmbGV.Location = new System.Drawing.Point(153, 402);
            this.cmbGV.Name = "cmbGV";
            this.cmbGV.Size = new System.Drawing.Size(162, 27);
            this.cmbGV.TabIndex = 17;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLopTC, "MAMH", true));
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(153, 228);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(150, 27);
            this.cmbMaMH.TabIndex = 16;
            this.cmbMaMH.SelectedIndexChanged += new System.EventHandler(this.cmbMaMH_SelectedIndexChanged);
            // 
            // cbHuyLop
            // 
            this.cbHuyLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTC, "HUYLOP", true));
            this.cbHuyLop.Location = new System.Drawing.Point(153, 564);
            this.cbHuyLop.MenuManager = this.barManager1;
            this.cbHuyLop.Name = "cbHuyLop";
            this.cbHuyLop.Properties.Caption = "";
            this.cbHuyLop.Size = new System.Drawing.Size(112, 29);
            this.cbHuyLop.TabIndex = 15;
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTC, "SOSVTOITHIEU", true));
            this.txtSL.Location = new System.Drawing.Point(277, 486);
            this.txtSL.MenuManager = this.barManager1;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(205, 28);
            this.txtSL.TabIndex = 13;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTC, "MAKHOA", true));
            this.txtMaKhoa.Enabled = false;
            this.txtMaKhoa.Location = new System.Drawing.Point(442, 401);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(167, 28);
            this.txtMaKhoa.TabIndex = 11;
            // 
            // spinNhom
            // 
            this.spinNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTC, "NHOM", true));
            this.spinNhom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNhom.Location = new System.Drawing.Point(153, 310);
            this.spinNhom.MenuManager = this.barManager1;
            this.spinNhom.Name = "spinNhom";
            this.spinNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNhom.Properties.IsFloatValue = false;
            this.spinNhom.Properties.Mask.EditMask = "N00";
            this.spinNhom.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinNhom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNhom.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.spinNhom.Size = new System.Drawing.Size(127, 28);
            this.spinNhom.TabIndex = 7;
            // 
            // spinHK
            // 
            this.spinHK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTC, "HOCKY", true));
            this.spinHK.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinHK.Location = new System.Drawing.Point(153, 144);
            this.spinHK.MenuManager = this.barManager1;
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
            this.spinHK.Size = new System.Drawing.Size(150, 28);
            this.spinHK.TabIndex = 3;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLopTC, "NIENKHOA", true));
            this.txtNienKhoa.Location = new System.Drawing.Point(153, 62);
            this.txtNienKhoa.MenuManager = this.barManager1;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(248, 28);
            this.txtNienKhoa.TabIndex = 1;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDK.DataSource = this.bdsLopTC;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLopTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 712);
            this.Controls.Add(this.pcLopTC);
            this.Controls.Add(this.gcLopTC);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmLopTC";
            this.Text = "FrmLopTC";
            this.Load += new System.EventHandler(this.FrmLopTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLopTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLopTC)).EndInit();
            this.pcLopTC.ResumeLayout(false);
            this.pcLopTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbHuyLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem Reload;
        private System.Windows.Forms.BindingSource bdsLopTC;
        private DS dS;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbTenPhongBan;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLopTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pcLopTC;
        private DevExpress.XtraEditors.CheckEdit cbHuyLop;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.SpinEdit spinNhom;
        private DevExpress.XtraEditors.SpinEdit spinHK;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private System.Windows.Forms.BindingSource bdsDK;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox cmbGV;
    }
}