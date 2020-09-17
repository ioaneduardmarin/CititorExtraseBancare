using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BankStatementReader.Parser
{
    public partial class StatementReport : DevExpress.XtraReports.UI.XtraReport, IStatementReport
    {
        public StatementReport()
        {
            InitializeComponent();
        }

        public void BindReportData(BindingList<ReportDataSource> listReportDataSource)
        {
            this.DataSource = listReportDataSource;
        }
    }

    public interface IStatementReport
    {
        void BindReportData(BindingList<ReportDataSource> listReportDataSource);
    }
}
