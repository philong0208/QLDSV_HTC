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
    public partial class Frm_RP_BDTK : DevExpress.XtraEditors.XtraForm
    {
        public Frm_RP_BDTK()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            try
            {
                XtraReport_BDTK report = new XtraReport_BDTK(this.txtMalop.Text.Trim().ToString());
                report.lblMaLop.Text = this.txtMalop.Text.Trim().ToString();
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
    }
}