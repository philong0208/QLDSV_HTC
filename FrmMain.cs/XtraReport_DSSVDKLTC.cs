using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace FrmMain.cs.Report
{
    public partial class XtraReport_DSSVDKLTC : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_DSSVDKLTC(string nienkhoa, int hocky, string monhoc, int nhom)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = monhoc;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
        }

    }
}
