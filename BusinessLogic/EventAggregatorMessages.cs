using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Mask;

namespace BankStatementReader
{
    class OpenStatementFormMessage : IApplicationEvent
    {
        public OpenStatementFormMessage(StatementFormPresenter statementFormPresenter)
        {
            StatementFormPresenter = statementFormPresenter;
        }
        public StatementFormPresenter StatementFormPresenter { get; private set; }
    }

    class CloseStatementFormMessage : IApplicationEvent
    {
        public CloseStatementFormMessage(StatementFormPresenter statementFormPresenter)
        {
            StatementFormPresenter = statementFormPresenter;
        }
        public StatementFormPresenter StatementFormPresenter { get; private set; }
    }

    class ActiveStatementMessage : IApplicationEvent
    {
        public ActiveStatementMessage(StatementFormPresenter statementFormPresenter)
        {
            StatementFormPresenter = statementFormPresenter;
        }
        public StatementFormPresenter StatementFormPresenter { get; private set; }
    }
}


