
using DevExpress.XtraReports.UI;

namespace BankStatementReader.Parser
{
    class ReportBuilder : IReportBuilder
    {
        public StatementReport CreateReport(StatementFormPresenter statementFormPresenter)
        {
            return new StatementReport();
        }

        public void ShowReport(StatementReport statementReport)
        {
            ReportPrintTool printTool = new ReportPrintTool(statementReport);
            printTool.ShowRibbonPreview();
        }
    }

    public interface IReportBuilder
    {
        StatementReport CreateReport(StatementFormPresenter statementFormPresenter);
        void ShowReport(StatementReport statementReport);
    }
}
