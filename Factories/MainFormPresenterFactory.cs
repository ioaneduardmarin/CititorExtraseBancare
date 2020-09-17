using BankStatementReader.Parser;

namespace BankStatementReader
{
    public interface IMainFormPresenterFactory
    {
        IMainFormPresenter Create(IMainForm mainForm, IStatementFormFactory statementFormFactory,
            IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService,
            IExtrasParserFactory extrasParserFactory, IReportBuilder reportBuilder);
    }
    public class MainFormPresenterFactory : IMainFormPresenterFactory
    {
        public IMainFormPresenter Create(IMainForm mainForm, IStatementFormFactory statementFormFactory, IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService, IExtrasParserFactory extrasParserFactory, IReportBuilder reportBuilder)
        {
            return new MainFormPresenter(mainForm, statementFormFactory, statementFormPresenterFactory, dialogService, extrasParserFactory, reportBuilder);
        }
    }
}
