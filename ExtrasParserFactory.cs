using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementReader
{
    public interface IExtrasParserFactory
    {
        IExtrasParser Create();
    }
    public class ExtrasParserFactory : IExtrasParserFactory
    {
        public IExtrasParser Create()
        {
            return new ExtrasParser();
        }
    }
}
