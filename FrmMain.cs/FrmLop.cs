using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain.cs
{
    public partial class FrmLop : Form
    { 
        int vitri = 0;
        String oldMaLop = "";
        String oldTenLop = "";
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

            Program.mMAKHOA = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();
            cmbTenPhongBan.DataSource = Program.bds_dspm;
            Program.bds_dspm.Filter = "TENCN LIKE 'KHOA%'";
            cmbTenPhongBan.DisplayMember = "TENCN";
            cmbTenPhongBan.ValueMember = "TENSERVER";
/*            cmbTenPhongBan.SelectedIndex = Program.mChiNhanh;*/
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
                Program.mMAKHOA = ((DataRowView)bdsLOP[0])["MAKHOA"].ToString();

            }
        }
        private int KiemTraTrung(String strLenh)
        {
            
            SqlDataReader dataReader = Program.ExecSqlDataReader(strLenh);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
        private bool kiemTraField()
        {
            if(Program.Control == "add")
            {
                string strLenh = "DECLARE  @return_value int \n"
                           + "EXEC  @return_value = SP_CHECKID \n"
                           + "@Code = N'" + txtMALOP.Text + "',@Type = N'MALOP' \n"
                           + "SELECT  'Return Value' = @return_value ";
                int result = KiemTraTrung(strLenh);

                if (txtMALOP.Text.Trim() == "")
                {
                    MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                    txtMALOP.Focus();
                    return false;
                }
                if (result == 1 || result == 2)
                {
                    MessageBox.Show("Mã lớp đã tồn tại!", "", MessageBoxButtons.OK);
                    txtMALOP.Focus();
                    return false;
                }
                if (txtTenLop.Text.Trim() == "")
                {
                    MessageBox.Show("Tên lớp không được để trống!", "", MessageBoxButtons.OK);
                    txtTenLop.Focus();
                    return false;
                }
                string strLenh1 = "DECLARE @return_value int \n"
                                   + "EXEC @return_value = SP_CHECKNAME \n"
                                   + "@Name = N'" + txtTenLop.Text + "', @Type = N'TENLOP' \n"
                                   + "SELECT 'Return Value' = @return_value ";
                int result1 = KiemTraTrung(strLenh1);
                if (result1 == 1 || result1 == 2)
                {
                    MessageBox.Show("Tên lớp đã tồn tại!", "", MessageBoxButtons.OK);
                    txtTenLop.Focus();
                    return false;
                }
                if (txtKhoaHoc.Text.Trim() == "")
                {
                    MessageBox.Show("Khoá học đã tồn tại!", "", MessageBoxButtons.OK);
                    txtKhoaHoc.Focus();
                    return false;
                }
            }
            if(Program.Control == "edit")
            {
                if (!this.txtMALOP.Text.Trim().ToString().Equals(oldMaLop))
                {
                    string strLenh = "DECLARE  @return_value int \n"
                           + "EXEC  @return_value = SP_CHECKID \n"
                           + "@Code = N'" + txtMALOP.Text + "',@Type = N'MALOP' \n"
                           + "SELECT  'Return Value' = @return_value ";
                    int result = KiemTraTrung(strLenh);
                    if (result == 1 || result == 2)
                    {
                        MessageBox.Show("Mã lớp đã tồn tại!", "", MessageBoxButtons.OK);
                        txtMALOP.Focus();
                        return false;
                    }
                }
                if (!this.txtTenLop.Text.Trim().ToString().Equals(oldTenLop))
                {
                    string strLenh1 = "DECLARE @return_value int \n"
                                   + "EXEC @return_value = SP_CHECKNAME \n"
                                   + "@Name = N'" + txtTenLop.Text + "', @Type = N'TENLOP' \n"
                                   + "SELECT 'Return Value' = @return_value ";
                    int result1 = KiemTraTrung(strLenh1);
                    if (result1 == 1 || result1 == 2)
                    {
                        MessageBox.Show("Tên lớp đã tồn tại!", "", MessageBoxButtons.OK);
                        txtTenLop.Focus();
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.Control = "add";
            vitri = bdsLOP.Position;
            this.EnablePanelControl();
            bdsLOP.AddNew();
            txtMALOP.Focus();
            txtMAKH.Text = Program.mMAKHOA;
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
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = true;
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
            Program.Control = "edit";
            this.oldMaLop = this.txtMALOP.Text.Trim().ToString();
            this.oldTenLop = this.txtTenLop.Text.Trim().ToString();
            vitri = bdsLOP.Position;
            gcLOP.Enabled = true;
            this.EnablePanelControl();
            btnSave.Enabled = btnUndo.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (kiemTraField())
            {
                try
                {
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    if(Program.Control == "add")
                    {
                        bdsLOP.MoveLast();
                    }
                    else if(Program.Control == "edit")
                    {
                        bdsLOP.Position = vitri;
                    }
                    gcLOP.Enabled = true;
                    btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnSave.Enabled = btnUndo.Enabled = false;
                    this.DisablePanelControl();
                    MessageBox.Show("Ghi thành công", "", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    bdsLOP.RemoveCurrent();
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Program.Control = "";
            
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

        private void txtMALOP_TextChanged(object sender, EventArgs e)
        {
            txtMALOP.CharacterCasing = CharacterCasing.Upper;
        }

        private void gcLOP_Click(object sender, EventArgs e)
        {

        }
    }
}
