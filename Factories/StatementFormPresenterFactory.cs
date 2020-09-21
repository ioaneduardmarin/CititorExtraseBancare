using BankStatementReader.Parser;

namespace BankStatementReader
{
    public interface IStatementFormPresenterFactory
    {
        IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm, IDialogService dialogService, IReportBuilder reportBuilder);
    }
    public class StatementFormPresenterFactory : IStatementFormPresenterFactory
    {
        public IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm, IDialogService dialogService, IReportBuilder reportBuilder)
        {
            return new StatementFormPresenter(extrasParserFactory, statementForm, dialogService, reportBuilder);
        }
    }
}
