using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementReader
{
    
        public interface IStatementFormFactory
        {
            IStatementForm Create();
        }
        public class StatementFormFactory : IStatementFormFactory
        {
            public IStatementForm Create()
            {
                return new StatementForm();
            }
        }
    
}
