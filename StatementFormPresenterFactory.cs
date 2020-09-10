namespace BankStatementReader
{
    public interface IStatementFormPresenterFactory
    {
        IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm);
    }
    public class StatementFormPresenterFactory : IStatementFormPresenterFactory
    {
        public IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm)
        {
            return new StatementFormPresenter(extrasParserFactory, statementForm);
        }
    }
}
