using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain.cs
{
    public partial class FrmHocPhi : Form
    {
        private int position;
        private Boolean flagEdit = false;
        private Boolean flagAdd = false;
        private BindingSource bdsSV = new BindingSource();
        //private BindingSource bdsTTHocPhi = new BindingSource();
        public FrmHocPhi()
        {
            InitializeComponent();
        }

        private void enableEdit()
        {
            btnAdd.Enabled = btnSua.Enabled = false;
            btnSave.Enabled = groupTTHocPhi.Enabled = true;
            cmbMASV.ReadOnly = true;
        }

        private void disableEdit()
        {
            btnAdd.Enabled = btnSua.Enabled = true;
            btnSave.Enabled = groupTTHocPhi.Enabled = false;
            cmbMASV.ReadOnly = false;
        }

        private void loadInitDataSV()
        {
            String lenh = "SELECT MASV, HO, TEN, MALOP, DANGHIHOC " +
                "FROM SINHVIEN";
            DataTable SINHVIENDataTable = Program.ExecSqlDataTable(lenh);
            if(SINHVIENDataTable.Rows.Count < 0)
            {
                XtraMessageBox.Show("Lỗi truy cập!", "ERROR");
            }
            bdsSV.DataSource = SINHVIENDataTable;

            this.cmbMASV.Properties.DataSource = bdsSV;
            this.cmbMASV.Properties.DisplayMember = "MASV";
            this.cmbMASV.Properties.ValueMember = "MASV";
            this.cmbMASV.DataBindings.Add("EditValue", bdsSV, "MASV", true);

            //this.txtHO.DataBindings.Add("EditValue", bdsSV, "HO", );
        }

        private void loadInitDataHocPhi(String selectedMaSV)
        {
            // var selectedSV = cmbMASV.GetSelectedDataRow() as DataRowView;
            String lenh = "exec [dbo].[GET_THONGTIN_HOCPHI]" +
                "@MASV = N'" + selectedMaSV + "'";
            // DataAdapter da = new SqlDataAdapter(lenh, Program.conn);

            DataTable HOCPHIDataTable = Program.ExecSqlDataTable(lenh);
            if (HOCPHIDataTable.Rows.Count < 0)
            {
                XtraMessageBox.Show("Lỗi truy cập", "ERROR");
            }
            bdsTTHocPhi.DataSource = HOCPHIDataTable;

            gcTTHocPhi.DataSource = bdsTTHocPhi;
        }

        private void FrmHocPhi_Load(object sender, EventArgs e)
        {
            
            loadInitDataSV();
            // TODO: This line of code loads data into the 'dS.HOCPHI' table. You can move, or remove it, as needed.
            this.HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOCPHITableAdapter.Fill(this.DS.HOCPHI);
            disableEdit();
        }

        private bool KiemTraMaTrung(string maSV, string nienKhoa, string hocKy)
        {



            string query1 = " DECLARE @return_value int " +

                            " EXEC    @return_value = [dbo].[SP_CHECKIDHOCPHI] " +

                            " @masv = N'" + maSV + "', " +

                            " @nienkhoa = N'" + nienKhoa + "', " +

                            " @hoky =" + hocKy +

                            " SELECT  'Return Value' = @return_value ";
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
                // trùng
                return true;
            }

            // ko trùng
            return false;
        }

        private bool CanSave()
        {
            if (KiemTraMaTrung(cmbMASV.Text, txtNienKhoa.Text, txtHocKy.EditValue.ToString()) == true)
            {
                String notifi = "Sinh viên này đã đóng học phí trong học kỳ. Bạn có muốn chỉnh sửa !";

                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            }

            return true;
        }

        private bool Save()
        {
            bool isSuccess = true;
            String statementType = "";

            String masv = cmbMASV.GetColumnValue("MASV").ToString();
            String nienKhoa = txtNienKhoa.Text;
            int hocKy = int.Parse(txtHocKy.Text);
            int hocPhi = int.Parse(txtHocPhi.Text);

            String ngayDong = DateTime.Now.ToString();
            int soTienDong = int.Parse(txtSoTienDaDong.Text);

            

            try
            {
                // phục vụ cho việc ghi mới dữ liệu nếu flagEdit = false, flagAdd = true;
                if (flagAdd)
                {
                    /*((DataRowView)bdsTTHocPhi.Current)["MASV"] = (String)cmbMASV.EditValue;*/

                    try
                    {
                        statementType = "insert";

                        String lenh = " exec [dbo].[ADD_HOCPHI] " +
                        " @masv = '" + masv + "'" +
                        ", @nienKhoa = '" + nienKhoa + "'" +
                        ", @hocKy = " + hocKy +
                        ", @hocPhi = " + hocPhi +
                        ", @ngayDong = '" + ngayDong + "'" +
                        ", @soTienDong = " + soTienDong +
                        ", @StatementType ='" + statementType + "'";

                        SqlCommand cmd = new SqlCommand(lenh, Program.conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi: " + ex.Message);
                        isSuccess = false;
                    }
                }
                if(flagEdit)
                {
                    try
                    {
                        statementType = "update";

                        String lenh = " exec [dbo].[ADD_HOCPHI] " +
                            " @masv = '" + masv + "'" +
                            ", @nienKhoa = '" + nienKhoa + "'" +
                            ", @hocKy = " + hocKy +
                            ", @hocPhi = " + hocPhi +
                            ", @ngayDong = '" + ngayDong + "'" +
                            ", @soTienDong = " + soTienDong +
                            ", @StatementType ='" + statementType + "'";

                        SqlCommand cmd = new SqlCommand(lenh, Program.conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi: " + ex.Message);
                    }

                }

                // cập nhật dữ liệu.
                /*bdsHocPhi.EndEdit();
                this.bdsHocPhi.ResetCurrentItem();
                this.HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOCPHITableAdapter.Update(this.DS.HOCPHI);*/

                disableEdit();
                loadInitDataHocPhi(masv);

                //this.bdsHocPhi.Position = _position;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: "+ ex.Message);
                isSuccess = false;
            }
            return isSuccess;
        }



        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            var selectedSV = cmbMASV.GetSelectedDataRow() as DataRowView;

            String masv = cmbMASV.GetColumnValue("MASV").ToString();

            txtHOTEN.Text = selectedSV.Row["HO"].ToString() + " " + selectedSV.Row["TEN"].ToString();
            txtMALOP.Text = selectedSV.Row["MALOP"].ToString();

            //position = this.bdsSV.Find("MASV", selectedSV.Row["MASV"].ToString());

            loadInitDataHocPhi(masv);

            this.btnAdd.Enabled = true;

            this.bdsSV.Position = position;

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                // check sinh viên đã nghĩ học
                if (((DataRowView)bdsSV[position])["DANGHIHOC"].ToString() == "True")
                {
                    XtraMessageBox.Show("Sinh Viên này đã nghĩ học !", "", MessageBoxButtons.OK);
                    return;
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Không thể thêm!", "ERROR");
            }

            //Empty textboxes
            txtNienKhoa.Text = "";
            txtHocKy.Text = "";
            txtHocPhi.Text = "";
            txtSoTienDaDong.Text = "";

            position = bdsSV.Position;
            //bdsHocPhi.AddNew();
            flagAdd = true;
            flagEdit = false;
            enableEdit();
            txtNienKhoa.Focus();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                // check giá trị trước khi add
                float soTienDong = float.Parse(this.txtSoTienDaDong.Text);
                float soHocPhi = float.Parse(this.txtHocPhi.Text);

                if (soTienDong > soHocPhi)
                {
                    XtraMessageBox.Show("Số tiền đóng không được lớn hơn học phí !", "", MessageBoxButtons.OK);
                    return;
                }
                if (txtSoTienDaDong.Text == "" || txtHocPhi.Text == "")
                {
                    XtraMessageBox.Show("Dữ liệu không được để trống !", "", MessageBoxButtons.OK);
                    return;
                }
                if(int.Parse(txtHocKy.Text) <= 0 || int.Parse(txtHocKy.Text) > 3)
                {
                    XtraMessageBox.Show("Học kỳ phải là số nguyên dương và nhỏ hơn 3");
                    return;
                }    

                if (CanSave())
                {
                    if (Save())
                    {
                        XtraMessageBox.Show("Ghi thông tin đóng học phí thành công !", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Lỗi  !", "", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex.Message);
            }

            flagEdit = false;
            flagAdd = true;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // trường hợp đang thêm dữ liệu
            if (btnSave.Enabled)
            {
                String notifi = " Dữ liệu Học phí chưa lưu vào Database.  Bạn có chắc muốn thoát !";

                DialogResult dr = XtraMessageBox.Show(notifi, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            this.Close();
        }

        private void gridViewHocPhi_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            GridColumn colHocPhi = view.Columns["HOCPHI"];
            GridColumn colTienDaDong = view.Columns["SOTIENDADONG"];

            double soHocPhi = double.Parse(view.GetRowCellValue(e.RowHandle, colHocPhi).ToString());
            double soDaDong = double.Parse(view.GetRowCellValue(e.RowHandle, colTienDaDong).ToString());

            //Validity criterion 
            if (soHocPhi < soDaDong)
            {
                e.Valid = false;
                view.SetColumnError(colHocPhi, "Số tiền học phí phải lớn hơn hoặc bằng số tiền đã đóng");
                view.SetColumnError(colTienDaDong, "Số tiền đã đóng phải nhỏ hơn hoặc bằng số tiền học phí");
            }
        }

        private void gridViewHocPhi_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void gridViewHocPhi_RowCellClick(object sender, RowCellClickEventArgs e)
        {
/*            txtnienkhoa.text = gridviewhocphi.getrowcellvalue(gridviewhocphi.focusedrowhandle, "nienkhoa").tostring();
            txthocky.text = gridviewhocphi.getrowcellvalue(gridviewhocphi.focusedrowhandle, "hocky").tostring();
            txthocphi.text = gridviewhocphi.getrowcellvalue(gridviewhocphi.focusedrowhandle, "hocphi").tostring();
            txtsotiendadong.text = gridviewhocphi.getrowcellvalue(gridviewhocphi.focusedrowhandle, "sotiendong").tostring();*/
        }

        private void gridViewHocPhi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNienKhoa.Text = (gridViewHocPhi.GetFocusedRow() as DataRowView).Row["NIENKHOA"].ToString();
            txtHocKy.Text = (gridViewHocPhi.GetFocusedRow() as DataRowView).Row["HOCKY"].ToString();
            txtHocPhi.Text = (gridViewHocPhi.GetFocusedRow() as DataRowView).Row["HOCPHI"].ToString();
            txtSoTienDaDong.Text = (gridViewHocPhi.GetFocusedRow() as DataRowView).Row["SOTIENDONG"].ToString();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                // check sinh viên đã nghĩ học
                if (((DataRowView)bdsSV[position])["DANGHIHOC"].ToString() == "True")
                {
                    XtraMessageBox.Show("Sinh Viên này đã nghĩ học !", "", MessageBoxButtons.OK);
                    return;
                }

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Không thể sửa!", "ERROR");
            }

            position = bdsSV.Position;

            flagAdd = false;
            flagEdit = true;

            enableEdit();
            txtNienKhoa.Focus();
        }
    }
}
