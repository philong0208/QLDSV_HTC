using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FrmMain.cs
{
    public partial class FrmMain1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Boolean dangxuat = false;

        public FrmMain1()
        {
            InitializeComponent();

          
         
        }



        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

              
            if (Program.mGroup == Program.NhomQuyen[3])//sv
            {
                btnDangKy.Enabled = true;
                btnDK.Enabled = false;
                rbBAOCAO.Visible = btnLopHoc.Enabled = btnMonHoc.Enabled = btnSinhVien.Enabled = btnTC.Enabled = btnHocPhi.Enabled = btnDiem.Enabled = false;
                statusStripMANV.Text = "Mã SV: " + Program.username;
                statusStripHOTEN.Text = "Họ Tên: " + Program.mHoten;
                statusStripNHOM.Text = "Nhóm: " + Program.mGroup;
            }
            else if (Program.mGroup == Program.NhomQuyen[2])//pkton
            {
                btnHocPhi.Enabled = btnHP.Enabled = true;
                btnDangKy.Enabled = false;
                btnLopHoc.Enabled = false;
                btnDSL.Enabled = btnDSSV.Enabled=false;
                btnLop.Enabled = btnDiem.Enabled = btnMonHoc.Enabled =btnSinhVien.Enabled=btnTC.Enabled= false;
               btnBDM.Enabled= btnBDTK.Enabled = btnPD.Enabled = false;
                statusStripMANV.Text = "Mã GV: " + Program.username;
                statusStripHOTEN.Text = "Họ Tên: " + Program.mHoten;
                statusStripNHOM.Text = "Nhóm: " + Program.mGroup;
            }
            else // khoa,pgv
            {
                btnHP.Enabled = false;
                btnHocPhi.Enabled = false;
                statusStripMANV.Text = "Mã GV: " + Program.username;
                statusStripHOTEN.Text = "Họ Tên: " + Program.mHoten;
                statusStripNHOM.Text = "Nhóm: " + Program.mGroup;
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmLop));
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmMonHoc));
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmSinhVien));
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDiem));
        }

        private void btnTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmLopTC));
        }

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDangKy));
        }

        private void btnHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmHocPhi));
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  string strLenh = "EXEC Xoa_Login '" + Program.mlogin+"'";
            dangxuat = true;
            Program.frmMain.Close();
            Program.frmDangNhap.Visible = true;


        }

        private void btnBDM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.Frm_RP_BDMHLTC));
        }

        private void btnBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.Frm_RP_BDTK));
        }

        private void btnDSL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.Frm_RP_DSLTC));
        }

        private void btnDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.Frm_RP_DSSVDKLTC));
        }

        private void btnHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.Frm_RP_DSDHP));
        }

        private void btnPD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(Report.Frm_RP_PD));
        }

        private void btnDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(FrmDangKyTK));
        }

        private void FrmMain1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dangxuat)
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    this.Dispose();
                    Program.frmDangNhap.Close();
                }

            }
        }


       
    }
}
