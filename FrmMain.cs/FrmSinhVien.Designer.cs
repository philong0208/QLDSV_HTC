
namespace FrmMain.cs
{
    partial class FrmSinhVien
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
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label dANGHIHOCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinhVien));
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new FrmMain.cs.DS();
            this.gridViewLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManagerLop = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.Reload = new DevExpress.XtraBars.BarButtonItem();
            this.panelBox = new System.Windows.Forms.Panel();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.LOPTableAdapter = new FrmMain.cs.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new FrmMain.cs.DSTableAdapters.TableAdapterManager();
            this.SINHVIENTableAdapter = new FrmMain.cs.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new FrmMain.cs.DSTableAdapters.DANGKYTableAdapter();
            this.pcSinhVien = new DevExpress.XtraEditors.PanelControl();
            this.groupBoxSV = new System.Windows.Forms.GroupBox();
            this.cbNGHIHOC = new DevExpress.XtraEditors.CheckEdit();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.dateNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.cbPHAI = new DevExpress.XtraEditors.CheckEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.pcSV = new DevExpress.XtraEditors.PanelControl();
            this.SINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewSV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            dANGHIHOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).BeginInit();
            this.panelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSinhVien)).BeginInit();
            this.pcSinhVien.SuspendLayout();
            this.groupBoxSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNGHIHOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPHAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSV)).BeginInit();
            this.pcSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(30, 37);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(38, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(42, 73);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(180, 73);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(400, 38);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(35, 13);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "PHAI:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(21, 109);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(47, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(6, 146);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(23, 185);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(45, 13);
            mALOPLabel.TabIndex = 12;
            mALOPLabel.Text = "MALOP:";
            // 
            // dANGHIHOCLabel
            // 
            dANGHIHOCLabel.AutoSize = true;
            dANGHIHOCLabel.Location = new System.Drawing.Point(363, 73);
            dANGHIHOCLabel.Name = "dANGHIHOCLabel";
            dANGHIHOCLabel.Size = new System.Drawing.Size(72, 13);
            dANGHIHOCLabel.TabIndex = 14;
            dANGHIHOCLabel.Text = "DANGHIHOC:";
            // 
            // gcLop
            // 
            this.gcLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.gcLop.DataMember = null;
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.Location = new System.Drawing.Point(2, 2);
            this.gcLop.MainView = this.gridViewLop;
            this.gcLop.MenuManager = this.barManagerLop;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1043, 197);
            this.gcLop.TabIndex = 0;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLop});
            this.gcLop.Click += new System.EventHandler(this.gcLop_Click);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewLop
            // 
            this.gridViewLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ma,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridViewLop.GridControl = this.gcLop;
            this.gridViewLop.Name = "gridViewLop";
            this.gridViewLop.OptionsBehavior.ReadOnly = true;
            this.gridViewLop.OptionsView.ShowGroupPanel = false;
            this.gridViewLop.OptionsView.ShowViewCaption = true;
            this.gridViewLop.ViewCaption = "DANH SÁCH LỚP";
            this.gridViewLop.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridViewLop_MasterRowGetRelationDisplayCaption);
            this.gridViewLop.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewLop_FocusedRowChanged);
            // 
            // Ma
            // 
            this.Ma.Caption = "MÃ LỚP";
            this.Ma.FieldName = "MALOP";
            this.Ma.Name = "Ma";
            this.Ma.OptionsColumn.AllowEdit = false;
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.Caption = "TÊN LỚP";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.Caption = "NIÊN KHÓA";
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.OptionsColumn.AllowEdit = false;
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.Caption = "KHOA";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.AllowEdit = false;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            // 
            // barManagerLop
            // 
            this.barManagerLop.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.btnUndo,
            this.btnExit,
            this.btnThoat,
            this.btnReload,
            this.Reload});
            this.barManagerLop.MainMenu = this.bar2;
            this.barManagerLop.MaxItemId = 10;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManagerLop;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1047, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 602);
            this.barDockControlBottom.Manager = this.barManagerLop;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1047, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManagerLop;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 578);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1047, 24);
            this.barDockControlRight.Manager = this.barManagerLop;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 578);
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
            // panelBox
            // 
            this.panelBox.Controls.Add(this.cmbKhoa);
            this.panelBox.Controls.Add(this.lblKhoa);
            this.panelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBox.Location = new System.Drawing.Point(0, 24);
            this.panelBox.Name = "panelBox";
            this.panelBox.Size = new System.Drawing.Size(1047, 53);
            this.panelBox.TabIndex = 4;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(271, 18);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(283, 21);
            this.cmbKhoa.TabIndex = 1;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(225, 21);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(40, 13);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "KHOA:";
            this.lblKhoa.Click += new System.EventHandler(this.lblKhoa_Click);
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.LOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrmMain.cs.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // pcSinhVien
            // 
            this.pcSinhVien.Controls.Add(this.groupBoxSV);
            this.pcSinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcSinhVien.Location = new System.Drawing.Point(2, 199);
            this.pcSinhVien.Name = "pcSinhVien";
            this.pcSinhVien.Size = new System.Drawing.Size(610, 324);
            this.pcSinhVien.TabIndex = 1;
            this.pcSinhVien.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // groupBoxSV
            // 
            this.groupBoxSV.Controls.Add(dANGHIHOCLabel);
            this.groupBoxSV.Controls.Add(this.cbNGHIHOC);
            this.groupBoxSV.Controls.Add(mALOPLabel);
            this.groupBoxSV.Controls.Add(this.txtMALOP);
            this.groupBoxSV.Controls.Add(nGAYSINHLabel);
            this.groupBoxSV.Controls.Add(this.dateNGAYSINH);
            this.groupBoxSV.Controls.Add(dIACHILabel);
            this.groupBoxSV.Controls.Add(this.txtDIACHI);
            this.groupBoxSV.Controls.Add(pHAILabel);
            this.groupBoxSV.Controls.Add(this.cbPHAI);
            this.groupBoxSV.Controls.Add(tENLabel);
            this.groupBoxSV.Controls.Add(this.txtTEN);
            this.groupBoxSV.Controls.Add(hOLabel);
            this.groupBoxSV.Controls.Add(this.txtHO);
            this.groupBoxSV.Controls.Add(mASVLabel);
            this.groupBoxSV.Controls.Add(this.txtMASV);
            this.groupBoxSV.Location = new System.Drawing.Point(10, 6);
            this.groupBoxSV.Name = "groupBoxSV";
            this.groupBoxSV.Size = new System.Drawing.Size(594, 306);
            this.groupBoxSV.TabIndex = 0;
            this.groupBoxSV.TabStop = false;
            this.groupBoxSV.Text = "Thông tin sinh viên";
            // 
            // cbNGHIHOC
            // 
            this.cbNGHIHOC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DANGHIHOC", true));
            this.cbNGHIHOC.Location = new System.Drawing.Point(441, 70);
            this.cbNGHIHOC.MenuManager = this.barManagerLop;
            this.cbNGHIHOC.Name = "cbNGHIHOC";
            this.cbNGHIHOC.Properties.Caption = "";
            this.cbNGHIHOC.Size = new System.Drawing.Size(75, 20);
            this.cbNGHIHOC.TabIndex = 15;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(74, 182);
            this.txtMALOP.MenuManager = this.barManagerLop;
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(100, 20);
            this.txtMALOP.TabIndex = 13;
            // 
            // dateNGAYSINH
            // 
            this.dateNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dateNGAYSINH.EditValue = null;
            this.dateNGAYSINH.Location = new System.Drawing.Point(74, 143);
            this.dateNGAYSINH.MenuManager = this.barManagerLop;
            this.dateNGAYSINH.Name = "dateNGAYSINH";
            this.dateNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNGAYSINH.Size = new System.Drawing.Size(100, 20);
            this.dateNGAYSINH.TabIndex = 11;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(74, 106);
            this.txtDIACHI.MenuManager = this.barManagerLop;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(100, 20);
            this.txtDIACHI.TabIndex = 9;
            // 
            // cbPHAI
            // 
            this.cbPHAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "PHAI", true));
            this.cbPHAI.Location = new System.Drawing.Point(441, 35);
            this.cbPHAI.MenuManager = this.barManagerLop;
            this.cbPHAI.Name = "cbPHAI";
            this.cbPHAI.Properties.Caption = "";
            this.cbPHAI.Size = new System.Drawing.Size(75, 20);
            this.cbPHAI.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(216, 70);
            this.txtTEN.MenuManager = this.barManagerLop;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 20);
            this.txtTEN.TabIndex = 5;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(74, 70);
            this.txtHO.MenuManager = this.barManagerLop;
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(100, 20);
            this.txtHO.TabIndex = 3;
            // 
            // txtMASV
            // 
            this.txtMASV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "MASV", true));
            this.txtMASV.Location = new System.Drawing.Point(74, 34);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(100, 21);
            this.txtMASV.TabIndex = 1;
            // 
            // pcSV
            // 
            this.pcSV.Controls.Add(this.SINHVIENGridControl);
            this.pcSV.Controls.Add(this.pcSinhVien);
            this.pcSV.Controls.Add(this.gcLop);
            this.pcSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcSV.Location = new System.Drawing.Point(0, 77);
            this.pcSV.Name = "pcSV";
            this.pcSV.Size = new System.Drawing.Size(1047, 525);
            this.pcSV.TabIndex = 20;
            // 
            // SINHVIENGridControl
            // 
            this.SINHVIENGridControl.DataSource = this.bdsSV;
            this.SINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SINHVIENGridControl.Location = new System.Drawing.Point(612, 199);
            this.SINHVIENGridControl.MainView = this.gridViewSV;
            this.SINHVIENGridControl.MenuManager = this.barManagerLop;
            this.SINHVIENGridControl.Name = "SINHVIENGridControl";
            this.SINHVIENGridControl.Size = new System.Drawing.Size(433, 324);
            this.SINHVIENGridControl.TabIndex = 2;
            this.SINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSV});
            // 
            // gridViewSV
            // 
            this.gridViewSV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP,
            this.colDANGHIHOC});
            this.gridViewSV.GridControl = this.SINHVIENGridControl;
            this.gridViewSV.Name = "gridViewSV";
            this.gridViewSV.OptionsView.ShowGroupPanel = false;
            this.gridViewSV.OptionsView.ShowViewCaption = true;
            this.gridViewSV.ViewCaption = "DANH SÁCH SINH VIÊN";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "MÃ SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 89;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 68;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 44;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "PHÁI";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 30;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 47;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "NGÀY SINH";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 54;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "MÃ LỚP";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 6;
            this.colMALOP.Width = 54;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 22;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 602);
            this.Controls.Add(this.pcSV);
            this.Controls.Add(this.panelBox);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmSinhVien";
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerLop)).EndInit();
            this.panelBox.ResumeLayout(false);
            this.panelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSinhVien)).EndInit();
            this.pcSinhVien.ResumeLayout(false);
            this.groupBoxSV.ResumeLayout(false);
            this.groupBoxSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbNGHIHOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPHAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSV)).EndInit();
            this.pcSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerLop;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem Reload;
        private System.Windows.Forms.Panel panelBox;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS DS;
        private DSTableAdapters.LOPTableAdapter LOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private DSTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private DevExpress.XtraEditors.PanelControl pcSV;
        private DevExpress.XtraEditors.PanelControl pcSinhVien;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLop;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.GridControl SINHVIENGridControl;
        private System.Windows.Forms.BindingSource bdsSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private System.Windows.Forms.GroupBox groupBoxSV;
        private DevExpress.XtraEditors.DateEdit dateNGAYSINH;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.CheckEdit cbPHAI;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private System.Windows.Forms.TextBox txtMASV;
        private DevExpress.XtraEditors.CheckEdit cbNGHIHOC;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
    }
}