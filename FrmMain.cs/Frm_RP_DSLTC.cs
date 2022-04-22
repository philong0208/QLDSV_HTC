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

namespace FrmMain.cs.Report
{
    public partial class Frm_RP_DSLTC : DevExpress.XtraEditors.XtraForm
    {
        public Frm_RP_DSLTC()
        {
            InitializeComponent();
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                XtraReport_DSLTC report = new XtraReport_DSLTC(this.txtNienKhoa.Text.Trim().ToString(), Int32.Parse(this.txtHocKi.Text.Trim().ToString()));
               
                report.lblHK.Text = this.txtHocKi.Text.Trim().ToString();
                report.lblNK.Text = this.txtNienKhoa.Text.Trim().ToString();
               report.lblKhoa.Text = ((DataRowView)Program.bds_dspm[Program.mChiNhanh])["TENCN"].ToString();
                ReportPrintTool print = new ReportPrintTool(report);
                print.ShowPreviewDialog();

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Dữ liệu bạn điền chưa hợp lệ !", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void button_THOAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_RP_DSLTC_Load(object sender, EventArgs e)
        {

        }
    }
}