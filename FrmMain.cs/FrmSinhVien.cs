using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmSinhVien : Form
    {
        int vitri = 0;
        private int positionSV = 0;
        private int positionLOP = 0;
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void lblKhoa_Click(object sender, EventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'ds1.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            // TODO: This line of code loads data into the 'ds1.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'ds1.DANGKY' table. You can move, or remove it, as needed.
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

            Program.mMAKHOA = ((DataRowView)bdsLop[0])["MAKHOA"].ToString();

            cmbKhoa.DataSource = Program.bds_dspm;
            Program.bds_dspm.Filter = "TENCN LIKE 'KHOA%'";
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            //cmbKhoa.SelectedIndex = Program.mChiNhanh;

            this.pcSinhVien.Enabled = false;
            gcLop.Enabled = true;
            

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            if(Program.mGroup == "SV")
            {
                btnAdd.Enabled 
                    = btnDel.Enabled 
                    = btnEdit.Enabled 
                    = btnReload.Enabled 
                    = btnSave.Enabled 
                    = btnUndo.Enabled = false;
                pcSV.Enabled = false;
                pcSinhVien.Enabled = false;
                groupBoxSV.Enabled = false;
            }
            else
            {
                btnAdd.Enabled
                    = btnEdit.Enabled
                    = btnDel.Enabled
                    = btnReload.Enabled = true;
                btnSave.Enabled 
                    = btnUndo.Enabled = false;
            }

            btnSave.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChiNhanh)
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
                try
                {
                    this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LOPTableAdapter.Fill(this.DS.LOP);

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Lỗi kết nối!!", "ERROR");
                    return;
                }
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled
                = btnEdit.Enabled
                = btnDel.Enabled = false;
            btnSave.Enabled = true;
            this.gcLop.Enabled = false;
            this.cmbKhoa.Enabled = false;

            this.cbPHAI.Checked = this.cbNGHIHOC.Checked = false;
            this.txtMALOP.Enabled = false;

            
            Program.Control = "add";
            vitri = bdsLop.Position;

            pcSinhVien.Enabled = true; // Enable panel nhap thong tin
            bdsSV.AddNew();
            
            dateNGAYSINH.EditValue = "";
            txtMASV.Focus();

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnEdit.Enabled
                = btnAdd.Enabled
                = btnDel.Enabled = false;
            btnSave.Enabled = true;
            this.gcLop.Enabled = false;
            this.cmbKhoa.Enabled = false;

            txtMALOP.Enabled = false;

            Program.Control = "edit";
            pcSinhVien.Enabled = true;

            txtMASV.Focus();
        }

        private bool KiemTraDongHocPhi(string maSV)
        {



            string query1 = " DECLARE @return_value int " +

                            " EXEC    @return_value = [dbo].[SP_CHECKIDHOCPHIBYMASV] " +

                            " @masv = N'" + maSV + "'" +

                            " SELECT  'Return Value' = @return_value ";
            //int resultMa = Utils.CheckDataHelper(query1);
            int flag;
            SqlDataReader dataReader = Program.ExecSqlDataReader(query1);
            if(dataReader == null)
            {
                flag = -1;
            }
            else
            {
                dataReader.Read();
                flag = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
            }


            if (flag == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (flag == 1)
            {
                // trùng
                return true;
            }

            // ko trùng
            return false;
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(bdsDangKy.Count > 0)
            {
                XtraMessageBox.Show("Sinh viên này đã có dữ liệu, không thể xóa!", "Warning", MessageBoxButtons.OK);
                return;
            }
            
            String masvCurrent = ((DataRowView)bdsSV[this.gridViewSV.FocusedRowHandle])["MASV"].ToString();

            if(KiemTraDongHocPhi(masvCurrent))
            {
                XtraMessageBox.Show("Sinh viên này đã có dữ liệu, không thể xóa!", "Warning", MessageBoxButtons.OK);
                return;
            }

            if(MessageBox.Show("Bạn có muốn xoá sinh viên này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    vitri = bdsSV.Position;

                    //bdsSV.RemoveCurrent(); // Ko thể xóa trên bds
                    
                    String lenh = "DELETE FROM SINHVIEN WHERE MASV = '" + masvCurrent + "'";
                    SqlCommand cmd = new SqlCommand(lenh, Program.conn);
                    cmd.ExecuteNonQuery(); // Xóa trực tiếp vào db

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    this.bdsSV.ResetCurrentItem();
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "Warning", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                    bdsSV.Position = vitri;
                    return;
                }
            }

            if(positionSV > 0)
            {
                bdsSV.Position = positionSV;
            }
        }



        private string oldMaLop = "";
        private string oldTenLop = "";
        private string oldMaSV;
        private bool ValidateInfoSinhVien(int position)
        {
            String maSV = this.txtMASV.ToString();

            if (maSV == oldMaSV)
            {
                return true;
            }
            if (string.IsNullOrEmpty(maSV))
            {
                XtraMessageBox.Show("Mã Sinh Viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //TODO: Check mã sinh viên có tồn tại chưa
            string query1 = " DECLARE @return_value INT " +

                            " EXEC @return_value = [dbo].[SP_CHECKID] " +

                            " @Code = N'" + maSV + "',  " +

                            " @Type = N'MASV' " +

                            " SELECT  'Return Value' = @return_value ";

            //int resultMa = Utils.CheckDataHelper(query1);
            int flag;
            SqlDataReader dataReader = Program.ExecSqlDataReader(query1);
            if (dataReader == null)
            {
                flag = -1;
            }
            else
            {
                dataReader.Read();
                flag = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
            }

            if (flag == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời bạn xem lại", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (flag == 1)
            {
                XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn chon mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (flag == 2)
            {
                XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        private Boolean flagEditSV = false;
        private Boolean flagUpdateSV = false;
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = true;
            int indexLastRow = bdsSV.Count - 1;
            if (!flagEditSV)
            {
                check = ValidateInfoSinhVien(indexLastRow);

            }
            if(check)
            {
                try
                {
                    this.bdsSV.EndEdit();
                    this.bdsSV.ResetCurrentItem();
                    this.SINHVIENTableAdapter.Update(this.DS.SINHVIEN);

                    flagEditSV = flagUpdateSV = false;

                    bdsSV.Position = bdsSV.Count - 1;
                    XtraMessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    this.bdsSV.RemoveCurrent();
                    XtraMessageBox.Show("Ghi dữ liệu thất bại, Vui lòng kiểm tra lại!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.gridViewLop.FocusedRowHandle = indexLastRow;
                this.gridViewLop.FocusedColumn = this.colMASV;
            }
            // Thoát edit mode
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }

            this.pcSinhVien.Enabled = false;
            gcLop.Enabled = true;

            btnAdd.Enabled
                    = btnEdit.Enabled
                    = btnDel.Enabled
                    = btnReload.Enabled = true;
                btnSave.Enabled
                    = btnUndo.Enabled = false;

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gcLop_Click(object sender, EventArgs e)
        {

        }

        private void SINHVIENGridControl_Click(object sender, EventArgs e)
        {
            
        }

        private void gridViewSV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsSV.Position > 0)
            {
                //_positionSV = bdsSV.Count - 1;
                positionSV = this.bdsSV.Position;
            }
        }

        private void gridViewSV_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {

        }

        private void gridViewSV_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "DANH SÁCH SINH VIÊN";
        }

        private void gridViewSV_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (flagEditSV)
            {
                positionSV = this.gridViewSV.FocusedRowHandle;
                oldMaSV = ((DataRowView)bdsSV[this.gridViewSV.FocusedRowHandle])["MASV"].ToString();
                return;
            }


            if (!this.gridViewSV.IsNewItemRow(this.gridViewSV.FocusedRowHandle))
            {
                e.Cancel = true;

            }
            int indexLastRow = bdsSV.Count - 1;

            //if (_positionSV > 0  &&  indexLastRow == this.gridViewSinhVien.FocusedRowHandle   && _flagUpdateSV)
            //{
            //        e.Cancel = false;
            //}

            if (indexLastRow == this.gridViewSV.FocusedRowHandle && flagUpdateSV)
            {
                e.Cancel = false;
            }
        }

        private void gridViewLop_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "DANH SÁCH SINH VIÊN";
        }

        private void gridViewLop_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(bdsLop.Position > 0)
            {
                positionLOP = bdsLop.Position;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(pcSinhVien.Enabled || flagUpdateSV)
            {
                String canhBao = "Dữ liệu SINH VIÊN chưa lưu vào Database. \n Bạn có chắc muốn thoát ! ";
                DialogResult dialogResult
                    = XtraMessageBox.Show(canhBao, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
                return;
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.CancelEdit();
            if(btnAdd.Enabled == false) { bdsSV.Position = vitri; }
            gcLop.Enabled = true;
            this.pcSinhVien.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDel.Enabled = btnReload.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DS.LOP);
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
                XtraMessageBox.Show("Làm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Khoong thể làm mới dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
