using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementReader
{
    public interface IStatementFormPresenterFactory
    {
        IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm);
    }
    public class StatementFormPresenterFactory : IStatementFormPresenterFactory
    {
        private readonly IExtrasParserFactory _extrasParserFactory;

        public IStatementFormPresenter Create(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm)
        {
            return new StatementFormPresenter(extrasParserFactory, statementForm);
        }
    }
}
