using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain.cs
{
    public partial class FrmLopTC : Form
    {
        int vitri = 0;
        public FrmLopTC()
        {
            InitializeComponent();
        }
        public void EnablePanelControl()
        {
            this.pcLopTC.Visible = true;
            this.pcLopTC.Enabled = true;
            this.cmbTenPhongBan.Enabled = false;
        }
        public void DisablePanelControl()
        {
            this.pcLopTC.Visible = false;
            this.pcLopTC.Enabled = false;
            this.cmbTenPhongBan.Enabled = false;
        }
        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLopTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmLopTC_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

            Program.mMAKHOA = ((DataRowView)bdsLopTC[0])["MAKHOA"].ToString();
            cmbTenPhongBan.DataSource = Program.bds_dspm;
            cmbTenPhongBan.DisplayMember = "TENCN";
            cmbTenPhongBan.ValueMember = "TENSERVER";
            cmbTenPhongBan.SelectedIndex = Program.mChiNhanh;
            pcLopTC.Visible = false;
            gcLopTC.Dock = DockStyle.Fill;
            if (Program.mGroup == "PGV")
            {
                cmbTenPhongBan.Enabled = true;
            }
            else
            {
                cmbTenPhongBan.Enabled = false;
            }
            if (Program.mGroup == "SV")
            {
               
            btnAdd.Enabled = btnEdit.Enabled = btnSave.Enabled =
            btnUndo.Enabled = btnReload.Enabled = btnDel.Enabled = false;
           
        }
        else
        {
            btnAdd.Enabled = btnEdit.Enabled = btnReload.Enabled = btnDel.Enabled = true;
                btnSave.Enabled = btnUndo.Enabled = false;
               
        }
    }

    private void cmbTenPhongBan_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbTenPhongBan.SelectedValue.ToString() == "System.Data.DataRowView")
            return;
        Program.servername = cmbTenPhongBan.SelectedValue.ToString();
        if (cmbTenPhongBan.SelectedIndex != Program.mChiNhanh)
        {
            Program.mlogin = Program.remotelogin;
            Program.mpassword = Program.remotepassword;
        }
        else
        {
            Program.mlogin = Program.mloginDN;
            Program.mpassword = Program.passwordDN;
        }
        if (Program.KetNoi() == 0)
        {
            MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
        }
        else
        {
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

                
        }
    }

    private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        gcLopTC.Dock = DockStyle.Right;
        vitri = bdsLopTC.Position;
        this.EnablePanelControl();
        bdsLopTC.AddNew();
        txtNienKhoa.Focus();
        String cmd = "SELECT MAMH FROM dbo.MONHOC";
        DataTable dt = new DataTable();
        dt = Program.ExecSqlDataTable(cmd);
         
        cmbMaMH.DataSource = dt;
        cmbMaMH.DisplayMember = "TENMH";
        cmbMaMH.ValueMember = "MAMH";
        cmbMaMH.SelectedIndex = 0;
        txtMaGV.Text = Program.username;
        txtMaKhoa.Text = Program.mMAKHOA;
        cbHuyLop.Enabled = false;
        cbHuyLop.CheckState = CheckState.Unchecked;
        btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = false;
        btnSave.Enabled = btnUndo.Enabled = true;

        gcLopTC.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xoá lớp vì đã có đăng ký: ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá lớp này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsLopTC.Position;
                    bdsLopTC.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi xoá lớp tín chỉ. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
                    bdsLopTC.Position = vitri;
                    return;
                }
            }
            if (bdsLopTC.Count == 0) btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcLopTC.Dock = DockStyle.Right;
            vitri = bdsLopTC.Position;
            gcLopTC.Enabled = true;
            this.EnablePanelControl();
            cbHuyLop.Enabled = true;
            bdsLopTC.MoveFirst();
            btnSave.Enabled = btnUndo.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLopTC.CancelEdit();
            if (btnAdd.Enabled == false) bdsLopTC.Position = vitri;
            gcLopTC.Enabled = true;
            this.DisablePanelControl();
            btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS.LOPTINCHI);
            gcLopTC.Enabled = true;
            gcLopTC.Dock = DockStyle.Fill;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            this.DisablePanelControl();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNienKhoa.Text.Trim().Equals(" "))
            {
                MessageBox.Show("Niên khoá không được để trống", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }

            if (txtSL.Text.Trim().Equals(" "))
            {
                MessageBox.Show("Số lượng không được để trống", "", MessageBoxButtons.OK);
                txtSL.Focus();
                return;
            }
           

            try
            {
                this.bdsLopTC.EndEdit();
                this.bdsLopTC.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);

            }
            catch (Exception ex)
            {
                bdsLopTC.RemoveCurrent();
                MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gcLopTC.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = barButtonItem1.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            this.DisablePanelControl();
        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
