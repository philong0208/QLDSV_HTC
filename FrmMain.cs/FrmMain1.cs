using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrmMain.cs
{
    public partial class FrmMain1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            if (Program.mGroup == "SV")
            {
                statusStripMANV.Text = "Mã SV: " + Program.username;
                statusStripHOTEN.Text = "Họ Tên: " + Program.mHoten;
                statusStripNHOM.Text = "Nhóm: " + Program.mGroup;
            }
            else if (Program.mGroup == "PKT")
            {
                btnLop.Enabled = btnDK.Enabled = btnDiem.Enabled = btnMonHoc.Enabled =btnSinhVien.Enabled=btnTC.Enabled= false;
                statusStripMANV.Text = "Mã GV: " + Program.username;
                statusStripHOTEN.Text = "Họ Tên: " + Program.mHoten;
                statusStripNHOM.Text = "Nhóm: " + Program.mGroup;
            }
            else
            {
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
            string strLenh = "EXEC Xoa_Login '" + Program.mlogin+"'";

        }
    }
}
