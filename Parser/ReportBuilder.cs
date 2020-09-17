using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;

namespace BankStatementReader.Parser
{
    class ReportBuilder : IReportBuilder
    {
        private IDialogService _dialogService;
        private IStatementReport _statementReport;

        public ReportBuilder(IDialogService dialogService, IStatementReport statementReport)
        {
            _dialogService = dialogService;
            _statementReport = statementReport;
        }

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
