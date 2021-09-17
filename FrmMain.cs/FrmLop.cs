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
    public partial class FrmLop : Form
    {
        String macn = "";
        int vitri = 0;
        public FrmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        public void EnablePanelControl()
        {
            this.pcLop.Visible = true;
            this.pcLop.Enabled = true;
        }
        public void DisablePanelControl()
        {
            this.pcLop.Visible = false;
            this.pcLop.Enabled = false;
        }
        private void FrmLop_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            cmbTenPhongBan.DataSource = Program.bds_dspm;
            cmbTenPhongBan.DisplayMember = "TENCN";
            cmbTenPhongBan.ValueMember = "TENSERVER";
            cmbTenPhongBan.SelectedIndex = Program.mChiNhanh;
            pcLop.Enabled = false;
            pcLop.Visible = false;
            if(Program.mGroup == "PGV")
            {
                cmbTenPhongBan.Enabled = true;
            }
            else
            {
                cmbTenPhongBan.Enabled = false;
            }
            if(Program.mGroup == "SV")
            {
                btnAdd.Enabled = btnEdit.Enabled = btnSave.Enabled = 
                btnUndo.Enabled = btnReload.Enabled = btnDel.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = btnEdit.Enabled = btnSave.Enabled =
              btnUndo.Enabled = btnReload.Enabled = btnDel.Enabled = true;
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
            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
               
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

                macn = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            this.EnablePanelControl();
            bdsLOP.AddNew();
            txtMALOP.Focus();
            txtMAKH.Text = macn;
            btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;

            gcLOP.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            if (btnAdd.Enabled == false) bdsLOP.Position = vitri;
            gcLOP.Enabled = true;
            this.DisablePanelControl();
            btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count>0)
            {
                MessageBox.Show("Không thể xoá lớp vì đã có sinh viên: ", "", MessageBoxButtons.OK);
                return;
            }
            if(MessageBox.Show("Bạn có muốn xoá lớp này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsLOP.Position;
                    bdsLOP.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("lỗi xoá lớp. Bạn hãy xoá lại\n" + ex.Message,"",MessageBoxButtons.OK);
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    bdsLOP.Position = vitri;
                    return;
                }
            }
            if (bdsLOP.Count == 0) btnDel.Enabled = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            gcLOP.Enabled = true;
            this.EnablePanelControl();
            bdsLOP.MoveFirst();
            btnSave.Enabled = btnUndo.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMALOP.Text.Trim().Equals(" "))
            {
                MessageBox.Show("Mã lớp không được để trống" , "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return;
            }
            if (txtTenLop.Text.Trim().Equals(" "))
            {
                MessageBox.Show("Tên lớp không được để trống", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtKhoaHoc.Text.Trim().Equals(" "))
            {
                MessageBox.Show("Khoá học không được để trống", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return;
            }

            // KT MALOP,KHOAHOC DUNG CAU TRUC
            // KT MALOP CO NAM TRONG CSDL CHUA

            try
            {
                this.bdsLOP.EndEdit();
                this.bdsLOP.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                this.lOPTableAdapter.Update(this.dS.LOP);

            }
            catch (Exception ex)
            {
                bdsLOP.RemoveCurrent();
                MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gcLOP.Enabled = true;
            btnAdd.Enabled =btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            this.DisablePanelControl();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void pcLop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
