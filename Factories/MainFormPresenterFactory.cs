namespace BankStatementReader
{
    public interface IMainFormPresenterFactory
    {
        IMainFormPresenter Create(IMainForm mainForm, IStatementFormFactory statementFormFactory,
            IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService,
            IExtrasParserFactory extrasParserFactory);
    }
    public class MainFormPresenterFactory : IMainFormPresenterFactory
    {
        public IMainFormPresenter Create(IMainForm mainForm, IStatementFormFactory statementFormFactory, IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService, IExtrasParserFactory extrasParserFactory)
        {
            return new MainFormPresenter(mainForm, statementFormFactory, statementFormPresenterFactory, dialogService, extrasParserFactory);
        }
    }
}
