using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementReader
{
    public interface IMainFormFactory
    {
        IMainForm Create();
    }
    public class MainFormFactory : IMainFormFactory
    {
        public IMainForm Create()
        {
            return new MainForm();
        }
    }
}
