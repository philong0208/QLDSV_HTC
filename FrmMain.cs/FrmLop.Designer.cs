
namespace FrmMain.cs
{
    partial class FrmLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLop));
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
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new FrmMain.cs.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new FrmMain.cs.DSTableAdapters.TableAdapterManager();
            this.gcLOP = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcLop = new DevExpress.XtraEditors.PanelControl();
            this.txtMAKH = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new FrmMain.cs.DSTableAdapters.SINHVIENTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLop)).BeginInit();
            this.pcLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(637, 32);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 19);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(630, 87);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(74, 19);
            tENLOPLabel.TabIndex = 2;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Location = new System.Drawing.Point(613, 147);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(91, 19);
            kHOAHOCLabel.TabIndex = 4;
            kHOAHOCLabel.Text = "KHOAHOC:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(623, 200);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(81, 19);
            mAKHOALabel.TabIndex = 6;
            mAKHOALabel.Text = "MAKHOA:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1203, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 614);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1203, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 580);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1203, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 580);
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
            this.panelControl1.Size = new System.Drawing.Size(1203, 56);
            this.panelControl1.TabIndex = 4;
            // 
            // cmbTenPhongBan
            // 
            this.cmbTenPhongBan.FormattingEnabled = true;
            this.cmbTenPhongBan.Location = new System.Drawing.Point(442, 18);
            this.cmbTenPhongBan.Name = "cmbTenPhongBan";
            this.cmbTenPhongBan.Size = new System.Drawing.Size(255, 27);
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
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrmMain.cs.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcLOP
            // 
            this.gcLOP.DataSource = this.bdsLOP;
            this.gcLOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLOP.Location = new System.Drawing.Point(0, 90);
            this.gcLOP.MainView = this.gridView1;
            this.gcLOP.MenuManager = this.barManager1;
            this.gcLOP.Name = "gcLOP";
            this.gcLOP.Size = new System.Drawing.Size(1203, 274);
            this.gcLOP.TabIndex = 9;
            this.gcLOP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridView1.GridControl = this.gcLOP;
            this.gridView1.Name = "gridView1";
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 30;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 112;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 30;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 112;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 30;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 112;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 30;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 112;
            // 
            // pcLop
            // 
            this.pcLop.Controls.Add(mAKHOALabel);
            this.pcLop.Controls.Add(this.txtMAKH);
            this.pcLop.Controls.Add(kHOAHOCLabel);
            this.pcLop.Controls.Add(this.txtKhoaHoc);
            this.pcLop.Controls.Add(tENLOPLabel);
            this.pcLop.Controls.Add(this.txtTenLop);
            this.pcLop.Controls.Add(mALOPLabel);
            this.pcLop.Controls.Add(this.txtMALOP);
            this.pcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLop.Location = new System.Drawing.Point(0, 364);
            this.pcLop.Name = "pcLop";
            this.pcLop.Size = new System.Drawing.Size(1203, 250);
            this.pcLop.TabIndex = 14;
            this.pcLop.Paint += new System.Windows.Forms.PaintEventHandler(this.pcLop_Paint);
            // 
            // txtMAKH
            // 
            this.txtMAKH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MAKHOA", true));
            this.txtMAKH.Location = new System.Drawing.Point(710, 196);
            this.txtMAKH.MenuManager = this.barManager1;
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(241, 28);
            this.txtMAKH.TabIndex = 7;
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "KHOAHOC", true));
            this.txtKhoaHoc.Location = new System.Drawing.Point(710, 143);
            this.txtKhoaHoc.MenuManager = this.barManager1;
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(241, 28);
            this.txtKhoaHoc.TabIndex = 5;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(710, 84);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(241, 27);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(710, 29);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(241, 27);
            this.txtMALOP.TabIndex = 1;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLOP;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 614);
            this.Controls.Add(this.pcLop);
            this.Controls.Add(this.gcLOP);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FrmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLop)).EndInit();
            this.pcLop.ResumeLayout(false);
            this.pcLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbTenPhongBan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DS dS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLOP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraEditors.PanelControl pcLop;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraBars.BarButtonItem Reload;
        private DevExpress.XtraEditors.TextEdit txtMAKH;
        private DevExpress.XtraEditors.TextEdit txtKhoaHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMALOP;
    }
}