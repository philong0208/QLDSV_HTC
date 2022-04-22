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
    public partial class FrmDiem : Form
    {
        private BindingSource bdsBangDiem_Nhap = new BindingSource();
        public FrmDiem()
        {
            InitializeComponent();
        }

        private void FrmDiem_Load(object sender, EventArgs e)
        {
           
            cmbKhoa.DataSource = Program.bds_dspm;
            Program.bds_dspm.Filter = "TENCN LIKE 'KHOA%'";
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;

            }
            else
            {
                cmbKhoa.Enabled = false;
            }

            string cmd = "SELECT * FROM dbo.V_MONHOC";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cmbMonHoc.DataSource = dt;
            cmbMonHoc.DisplayMember = "TENMH";
            cmbMonHoc.ValueMember = "MAMH";

            btnLuu.Enabled = false;

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
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
                MessageBox.Show("Kết nối csdl thất bại!", "", MessageBoxButtons.OK);
                return;
            }
        }
        private void loadDSSV()
        {
            string cmd = "  EXEC[dbo].[SP_GETDSNHAPDIEM] " +
                   " @NIENKHOA = N'" + txtNienKhoa.Text.ToString() + "'," +
                   " @HOCKY = " + Decimal.ToInt32(spinHK.Value) + "," +
                   "@MONHOC = N'" + cmbMonHoc.SelectedValue.ToString() + "'," +
                   " @NHOM = " + Decimal.ToInt32(spinNhom.Value);
            DataTable dt = Program.ExecSqlDataTable(cmd);
            if (dt.Rows.Count < 0)
            {
                MessageBox.Show("Lỗi truy cập");
            }
            bdsBangDiem_Nhap.DataSource = dt;
            this.gcDiem.DataSource = bdsBangDiem_Nhap;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNienKhoa.Text.ToString()))
            {
                btnLuu.Enabled = false;
                MessageBox.Show("Niên khoá không được để trống", "", MessageBoxButtons.OK);
                txtNienKhoa.Focus();
                return;
            }
            else
            {
                btnLuu.Enabled = true;
                this.loadDSSV();
            }
        }
        private bool checkEmptyRow()
        {
            BindingSource bdsTemp = bdsBangDiem_Nhap;
            int slg = bdsTemp.Count;
            for (int i = 0; i < slg; i++)
            {
                if (((DataRowView)bdsTemp[i])["DIEM_CC"].ToString() == "" || ((DataRowView)bdsTemp[i])["DIEM_GK"].ToString() == "" || ((DataRowView)bdsTemp[i])["DIEM_CK"].ToString() == "")
                {
                    bdsTemp.Position = i;
                    return true;
                }
            }
            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connstr);
            SqlTransaction tran;
            con.Open();
            tran = con.BeginTransaction();
            try
            {

                for (int i = 0; i < bdsBangDiem_Nhap.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERT_DIEM", con);
                    cmd.Connection = con;
                    cmd.Transaction = tran;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@NIENKHOA", txtNienKhoa.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@HOCKY", Decimal.ToInt32(spinHK.Value)));
                    cmd.Parameters.Add(new SqlParameter("@NHOM", Decimal.ToInt32(spinNhom.Value)));
                    cmd.Parameters.Add(new SqlParameter("@MONHOC", cmbMonHoc.SelectedValue.ToString()));
                    String masv = ((DataRowView)bdsBangDiem_Nhap[i])["MASV"].ToString();
                    cmd.Parameters.Add(new SqlParameter("@MASV", masv));
                    int diemcc = Int32.Parse(((DataRowView)bdsBangDiem_Nhap[i])["DIEM_CC"].ToString());
                    cmd.Parameters.Add(new SqlParameter("@DIEM_CC", diemcc));
                    float diemgk = float.Parse(((DataRowView)bdsBangDiem_Nhap[i])["DIEM_GK"].ToString());
                    cmd.Parameters.Add(new SqlParameter("@DIEM_GK", diemgk));
                    float diemck = float.Parse(((DataRowView)bdsBangDiem_Nhap[i])["DIEM_CK"].ToString());
                    cmd.Parameters.Add(new SqlParameter("@DIEM_CK", diemck));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Lưu thành công...", "", MessageBoxButtons.OK);
                tran.Commit();
                this.loadDSSV();
            }
            catch (SqlException sqlex)
            {
                try
                {

                    tran.Rollback();
                    MessageBox.Show("Lỗi ghi toàn bộ điểm vào Database. Bạn hãy xem lại ! " + sqlex.Message, "", MessageBoxButtons.OK);

                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                con.Close();
                return;
            }
            finally
            {
                con.Close();
            }


        }

        private void gcDiem_Click(object sender, EventArgs e)
        {

        }

        private void gvDiem_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "DIEM_CC")
            {
                int diem = 0;
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                diem = Int32.Parse(e.Value as string);
                if (diem < 0 || diem > 10)
                {

                    e.Valid = false;
                    e.ErrorText = "Điểm phải lớn hơn 0 và nhỏ hơn 10";
                }
            }
            if (view.FocusedColumn.FieldName == "DIEM_GK" || view.FocusedColumn.FieldName == "DIEM_CK")
            {
                float diem = 0;
                if (string.IsNullOrEmpty(e.Value as string))
                    return;
                diem = float.Parse(e.Value as string);
                if (diem < 0 || diem > 10)
                {

                    e.Valid = false;
                    e.ErrorText = "Điểm phải lớn hơn 0 và nhỏ hơn 10";
                }
                else
                {
                    e.Value = Math.Round(diem * 2, MidpointRounding.AwayFromZero) / 2;
                }
            }

        }

        private void gvDiem_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Azure;
            }
        }

    }
}
