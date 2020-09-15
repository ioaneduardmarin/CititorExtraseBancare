namespace BankStatementReader
{
    public interface IStatementFormPresenterFactory
    {
        IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm, IDialogService dialogService);
    }
    public class StatementFormPresenterFactory : IStatementFormPresenterFactory
    {
        public IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm, IDialogService dialogService)
        {
            return new StatementFormPresenter(extrasParserFactory, statementForm, dialogService);
        }
    }
}
