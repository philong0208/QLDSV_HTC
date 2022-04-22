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
    public partial class Frm_RP_PD : DevExpress.XtraEditors.XtraForm
    {
        public Frm_RP_PD()
        {
            InitializeComponent();
        }

        private void button_IN_Click(object sender, EventArgs e)
        {
            try
            {
                XtraReport_PD report = new XtraReport_PD(this.txtMaSV.Text.Trim().ToString());
                report.lblSV.Text = this.txtMaSV.Text.Trim().ToString();

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