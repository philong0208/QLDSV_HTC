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
    public partial class FrmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        String strLenh = "";


        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd,conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCN.DataSource = Program.bds_dspm;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
        }

        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private int KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();

            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc.\n xem lại Tên server của publisher...");
                return 0;
            }
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGoc() == 0) return;
            LayDSPM("SELECT * FROM dbo.Get_Subscribes ");
            cmbCN.SelectedIndex = 1;
            cmbCN.SelectedIndex = 0;

        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = cmbCN.SelectedValue.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "Lỗi đăng nhập", MessageBoxButtons.OK);

                // trỏ con trỏ chuột về ô user...
                txtUserName.Focus();
                return;
            }

            if (cbSV.Checked)
            {
                String username = txtUserName.Text;
                String password = txtPassword.Text;
                Program.mlogin = "SVKN";
                Program.mpassword = "123456";
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                strLenh = "EXEC [dbo].[SP_DANGNHAPSV]'" + Program.mlogin +"','"+ username + "','" + password+"'";

            
            }
            else
            {
                Program.mlogin = txtUserName.Text;
                Program.mpassword = txtPassword.Text;
                if (Program.KetNoi() == 0)
                {
                    return;
                }

                // 0: CNTT ,  1: VT, 2: HỌC PHÍ

                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.mpassword;
	
	//Program.MKhoa = cmbKhoa.SelectedIndex;

                strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
               
            }
            Program.mChiNhanh = cmbCN.SelectedIndex;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }

            Program.myReader.Read();

            
            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Login bạn nhập không có quyền truy cập vào chương trình", "", MessageBoxButtons.OK);
                return;
            }

            Program.myReader.Close();
            Program.conn.Close();

            // truy cập vào frm main 
            Program.frmMain = new FrmMain1();

            // hiện thông tin tài khoản
            

            Program.frmMain.Show();
            Program.frmDangNhap.Visible = false;
        }

        private void cbSV_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
