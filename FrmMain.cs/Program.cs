using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FrmMain.cs
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        //**///
       //* public static String connstr_publisher = "Data Source=ADMIN;Initial Catalog=QLDSV_HTC;Integrated Security=True";*//
        //public static String connstr_publisher = "Data Source=ADMIN0528urk\\MSSQLSERVER0;Initial Catalog=QLDSV_TC;Integrated Security=True";
        public static String connstr_publisher = "Data Source=PHILONG;Initial Catalog=QLDSV_HTC;Integrated Security=True";
        //**//
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String mpassword = "";
        /***/
        public static String database = "QLDSV_HTC";
        public static string[] NhomQuyen = new string[4] { "PGV", "Khoa", "PKT","SV" };
        //**//
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static String Control = "";
        public static string mMAKHOA = "";
        public static int mChiNhanh = 0;
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static FrmMain1 frmMain;
        public static FrmDangNhap frmDangNhap;
      

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
             
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.mpassword;
             
                Program.conn.ConnectionString = Program.connstr;
             
                Program.conn.Open();
             
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
           // sqlcmd.CommandTimeout = 1600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (SqlException ex)
            {
                conn.Close();
                return ex.State;
            }
        }



        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

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


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap = new FrmDangNhap();
           
            Application.Run(frmDangNhap);
        }

    }
}
