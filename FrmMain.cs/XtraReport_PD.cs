using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FrmMain.cs.Report
{
    public partial class XtraReport_PD : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_PD(string masv)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = masv;
            this.sqlDataSource1.Fill();
        }

    }
}
