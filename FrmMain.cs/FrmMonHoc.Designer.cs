
namespace FrmMain.cs
{
    partial class FrmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonHoc));
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.sOTIET_LTLabel = new System.Windows.Forms.Label();
            this.sOTIET_THLabel = new System.Windows.Forms.Label();
            this.tENMHLabel1 = new System.Windows.Forms.Label();
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
            this.dS = new FrmMain.cs.DS();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new FrmMain.cs.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new FrmMain.cs.DSTableAdapters.TableAdapterManager();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsLopTC = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new FrmMain.cs.DSTableAdapters.LOPTINCHITableAdapter();
            this.pcMonHoc = new DevExpress.XtraEditors.PanelControl();
            this.txtTENMH = new System.Windows.Forms.TextBox();
            this.txtTH = new System.Windows.Forms.TextBox();
            this.txtLT = new System.Windows.Forms.TextBox();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMonHoc)).BeginInit();
            this.pcMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Location = new System.Drawing.Point(423, 39);
            this.mAMHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(77, 13);
            this.mAMHLabel.TabIndex = 0;
            this.mAMHLabel.Text = "MÃ MÔN HỌC:";
            // 
            // sOTIET_LTLabel
            // 
            this.sOTIET_LTLabel.AutoSize = true;
            this.sOTIET_LTLabel.Location = new System.Drawing.Point(422, 123);
            this.sOTIET_LTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            this.sOTIET_LTLabel.Size = new System.Drawing.Size(64, 13);
            this.sOTIET_LTLabel.TabIndex = 4;
            this.sOTIET_LTLabel.Text = "SỐ TIẾT LT:";
            // 
            // sOTIET_THLabel
            // 
            this.sOTIET_THLabel.AutoSize = true;
            this.sOTIET_THLabel.Location = new System.Drawing.Point(423, 164);
            this.sOTIET_THLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sOTIET_THLabel.Name = "sOTIET_THLabel";
            this.sOTIET_THLabel.Size = new System.Drawing.Size(66, 13);
            this.sOTIET_THLabel.TabIndex = 6;
            this.sOTIET_THLabel.Text = "SỐ TIẾT TH:";
            // 
            // tENMHLabel1
            // 
            this.tENMHLabel1.AutoSize = true;
            this.tENMHLabel1.Location = new System.Drawing.Point(422, 81);
            this.tENMHLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tENMHLabel1.Name = "tENMHLabel1";
            this.tENMHLabel1.Size = new System.Drawing.Size(81, 13);
            this.tENMHLabel1.TabIndex = 7;
            this.tENMHLabel1.Text = "TÊN MÔN HỌC:";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(809, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 419);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(809, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 395);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(809, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 395);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ghi";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 6;
            this.btnExit.Name = "btnExit";
            // 
            // Reload
            // 
            this.Reload.Caption = "Reload";
            this.Reload.Id = 9;
            this.Reload.Name = "Reload";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrmMain.cs.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.bdsMonHoc;
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcMonHoc.Location = new System.Drawing.Point(0, 24);
            this.gcMonHoc.MainView = this.gridView1;
            this.gcMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(809, 200);
            this.gcMonHoc.TabIndex = 4;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridView1.DetailHeight = 227;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gcMonHoc;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            // 
            // bdsLopTC
            // 
            this.bdsLopTC.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLopTC.DataSource = this.bdsMonHoc;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // pcMonHoc
            // 
            this.pcMonHoc.Controls.Add(this.tENMHLabel1);
            this.pcMonHoc.Controls.Add(this.txtTENMH);
            this.pcMonHoc.Controls.Add(this.sOTIET_THLabel);
            this.pcMonHoc.Controls.Add(this.txtTH);
            this.pcMonHoc.Controls.Add(this.sOTIET_LTLabel);
            this.pcMonHoc.Controls.Add(this.txtLT);
            this.pcMonHoc.Controls.Add(this.mAMHLabel);
            this.pcMonHoc.Controls.Add(this.txtMAMH);
            this.pcMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcMonHoc.Location = new System.Drawing.Point(0, 224);
            this.pcMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.pcMonHoc.Name = "pcMonHoc";
            this.pcMonHoc.Size = new System.Drawing.Size(809, 195);
            this.pcMonHoc.TabIndex = 9;
            // 
            // txtTENMH
            // 
            this.txtTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "TENMH", true));
            this.txtTENMH.Location = new System.Drawing.Point(508, 79);
            this.txtTENMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(139, 21);
            this.txtTENMH.TabIndex = 8;
            this.txtTENMH.TextChanged += new System.EventHandler(this.tENMHTextBox_TextChanged);
            // 
            // txtTH
            // 
            this.txtTH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "SOTIET_TH", true));
            this.txtTH.Location = new System.Drawing.Point(508, 162);
            this.txtTH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(139, 21);
            this.txtTH.TabIndex = 7;
            // 
            // txtLT
            // 
            this.txtLT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "SOTIET_LT", true));
            this.txtLT.Location = new System.Drawing.Point(508, 118);
            this.txtLT.Margin = new System.Windows.Forms.Padding(2);
            this.txtLT.Name = "txtLT";
            this.txtLT.Size = new System.Drawing.Size(139, 21);
            this.txtLT.TabIndex = 5;
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMonHoc, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(508, 39);
            this.txtMAMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(139, 21);
            this.txtMAMH.TabIndex = 1;
            this.txtMAMH.TextChanged += new System.EventHandler(this.txtMAMH_TextChanged);
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 419);
            this.Controls.Add(this.pcMonHoc);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMonHoc";
            this.Text = "FrmMonHoc";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLopTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMonHoc)).EndInit();
            this.pcMonHoc.ResumeLayout(false);
            this.pcMonHoc.PerformLayout();
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
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DS dS;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private System.Windows.Forms.BindingSource bdsLopTC;
        private DSTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private DevExpress.XtraEditors.PanelControl pcMonHoc;
        private System.Windows.Forms.TextBox txtTENMH;
        private System.Windows.Forms.TextBox txtTH;
        private System.Windows.Forms.TextBox txtLT;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.Label mAMHLabel;
        private System.Windows.Forms.Label sOTIET_LTLabel;
        private System.Windows.Forms.Label sOTIET_THLabel;
        private System.Windows.Forms.Label tENMHLabel1;
    }
}