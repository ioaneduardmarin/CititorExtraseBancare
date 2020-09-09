using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementReader
{
    public interface IMainFormPresenterFactory
    {
        IMainFormPresenter Create(IMainForm mainForm, IStatementFormFactory statementFormFactory,
            IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService);
    }
    public class MainFormPresenterFactory : IMainFormPresenterFactory
    {
        public IMainFormPresenter Create(IMainForm mainForm, IStatementFormFactory statementFormFactory, IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService)
        {
            return new MainFormPresenter(mainForm, statementFormFactory, statementFormPresenterFactory, dialogService);
        }
    }
}
