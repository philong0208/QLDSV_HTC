using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FrmMain.cs.Report
{
    public partial class XtraReport_DSDHP : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSDHP(string malop, string nienkhoa, int hocky)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocky;
            this.sqlDataSource1.Fill();

        }

    }
}
