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
        }
        public void DisablePanelControl()
        {
            this.pcLopTC.Visible = false;
            this.pcLopTC.Enabled = false;
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
            Program.bds_dspm.Filter = "TENCN LIKE 'KHOA%'";
            cmbTenPhongBan.DisplayMember = "TENCN";
            cmbTenPhongBan.ValueMember = "TENSERVER";
            /*cmbTenPhongBan.SelectedIndex = Program.mChiNhanh;*/
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
             Program.mMAKHOA = ((DataRowView)bdsLopTC[0])["MAKHOA"].ToString();

            }
    }

    private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
         Program.Control = "add";
        gcLopTC.Dock = DockStyle.Right;
        vitri = bdsLopTC.Position;
        this.EnablePanelControl();
        bdsLopTC.AddNew();
        txtNienKhoa.Focus();
        
        String cmd = "SELECT MAMH FROM dbo.MONHOC";
        DataTable dt = new DataTable();
        dt = Program.ExecSqlDataTable(cmd);         
        cmbMaMH.DataSource = dt;
        cmbMaMH.DisplayMember = "MAMH" ;
        cmbMaMH.ValueMember = "MAMH";
        cmbMaMH.SelectedIndex = 0;
        
        String cmd1 = "SELECT * FROM dbo.GIANGVIEN";
        DataTable _dt1 = new DataTable();
            _dt1 = Program.ExecSqlDataTable(cmd1);
            cmbGV.DataSource = _dt1;
            cmbGV.DisplayMember ="MAGV";
            cmbGV.ValueMember = "MAGV";
            cmbGV.SelectedIndex = 0;
        
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
            Program.Control = "edit";
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
            gcLopTC.Dock = DockStyle.Fill;
            this.DisablePanelControl();
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = true;
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
            bool check = this.checkfield();
            if(check)
            {
                try
                {
                    this.bdsLopTC.EndEdit();
                    this.bdsLopTC.ResetCurrentItem();// tự động render để hiển thị dữ liệu mới
                    this.lOPTINCHITableAdapter.Update(this.dS.LOPTINCHI);
                    MessageBox.Show("Ghi thành công: ", "", MessageBoxButtons.OK);
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
        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
          
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
        private bool checkfield()
        {
            if(Program.Control == "add")
            {
                if (txtNienKhoa.Text.Trim().Equals(" "))
                {
                    MessageBox.Show("Niên khoá không được để trống", "", MessageBoxButtons.OK);
                    txtNienKhoa.Focus();
                    return false;
                }

                if (txtSL.Text.Trim().Equals(" "))
                {
                    MessageBox.Show("Số lượng không được để trống", "", MessageBoxButtons.OK);
                    txtSL.Focus();
                    return false;
                }

                string strLenh = "DECLARE  @return_value int \n"
                               + "EXEC	@return_value = [dbo].[CHECK_LOPTC] \n"
                               + "@NIENKHOA = N'" + txtNienKhoa.Text + "',@HOCKY = N'" + Decimal.ToInt32(spinHK.Value) + "',@MAMH = N'" + cmbMaMH.SelectedValue.ToString() + "',@NHOM = N'" + Decimal.ToInt32(spinNhom.Value) + "' \n"
                               + "SELECT  'Return Value' = @return_value ";
                int result = this.KiemTraTrung(strLenh);
                if (result == 1)
                {
                    MessageBox.Show("Lớp tín chỉ đã có trong cơ sơ dữ liệu", "", MessageBoxButtons.OK);
                    txtNienKhoa.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
