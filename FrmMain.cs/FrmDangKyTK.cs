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
    public partial class FrmDangKyTK : Form
    {
        public FrmDangKyTK()
        {
            InitializeComponent();
            String cmd1 = "SELECT * FROM dbo.V_GV";
            DataTable _dt1 = new DataTable();
            _dt1 = Program.ExecSqlDataTable(cmd1);
            cmbGV.DataSource = _dt1;
            cmbGV.DisplayMember = "MAGV";
            cmbGV.ValueMember = "MAGV";
            cmbGV.SelectedIndex = 0;
            if(Program.mGroup == "KHOA")
            {
                rdoKhoa.Enabled = true;
                rdoPGV.Enabled = rdoPKeToan.Enabled = false;
            }else if(Program.mGroup == "PKT")
            {
                rdoPKeToan.Enabled = true;
                rdoPGV.Enabled = rdoKhoa.Enabled = false;
            }
            else
            {
                rdoPKeToan.Enabled = false;
                rdoPGV.Enabled = rdoKhoa.Enabled = true;
            }
        }
        private int checkdata(String strLenh)
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
        private void createAccount()
        {
            String login = txtLogin.Text;
            String pass = txtPass.Text;
            String role = rdoKhoa.Checked ? "KHOA" : (rdoPGV.Checked ? "PGV" : "PKT");
            String user = this.cmbGV.SelectedValue.ToString();
            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                             " @LGNAME = N'" + login + "', " +
                             " @PASS = N'" + pass + "', " +
                             " @USERNAME = N'" + user + "', " +
                             " @ROLE = N'" + role + "' ";
            String strLenh = " DECLARE @return_value int " + subLenh +
                        " SELECT  'Return Value' = @return_value ";
            int resultCheckLogin = checkdata(strLenh);

            if (resultCheckLogin == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                MessageBox.Show("Login bị trùng . Mời bạn nhập login khác !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("Giảng viên " + user + "đã có tài khoản rồi !", "", MessageBoxButtons.OK);

            }
            else if (resultCheckLogin == 3)
            {
                MessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }
            return;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            createAccount();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
