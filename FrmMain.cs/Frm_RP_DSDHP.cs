using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.Data.Common;

namespace FrmMain.cs.Report
{
    public partial class Frm_RP_DSDHP : DevExpress.XtraEditors.XtraForm
    {
        public Frm_RP_DSDHP()
        {
            InitializeComponent();
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            
             try
             {
                 XtraReport_DSDHP report = new XtraReport_DSDHP(this.txtMaLop.Text.Trim().ToString(), this.txtNienkhoa.Text.Trim().ToString(), Int32.Parse(this.txtHocKi.Text.Trim().ToString()));
                 report.lblML.Text = this.txtMaLop.Text.Trim().ToString();

                 report.lblKhoa.Text = getMK(this.txtMaLop.Text.Trim().ToString());
                 
                 ReportPrintTool print = new ReportPrintTool(report);
                 print.ShowPreviewDialog();
             }
             catch (Exception)
             {
                 XtraMessageBox.Show("Dữ liệu bạn điền chưa hợp lệ !", "", MessageBoxButtons.OK);
                 return;
             }
            
                    

        }

        public string getMK(string malop)
        {
            string makhoa = "?";
           
            using (var sqlCon = new SqlConnection(
                "Data Source = PHILONG\\SERVER3 ;Initial Catalog = QLDSV_HTC; Integrated Security = True; "))
            { 
                sqlCon.Open();
                makhoa = new SqlCommand("Exec dbo.SP_MAKHOA " + malop + ";",
                    sqlCon).ExecuteScalar().ToString();
                sqlCon.Close();
            }

            return makhoa;
        }


        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}