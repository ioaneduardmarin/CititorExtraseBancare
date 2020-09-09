using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraGrid.Views.Grid;

namespace BankStatementReader
{
    class StatementFormPresenter : IStatementFormPresenter
    {
        private readonly IExtrasParserFactory _extrasParserFactory;
        private readonly IStatementForm _statementForm;

        public StatementFormPresenter(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm)
        {
            _statementForm = statementForm;
            _extrasParserFactory = extrasParserFactory;
        }

        public List<Extras> CreateRuntimeExtrasList(string numeFisier)
        {
            List<Extras> listaExtrase = new List<Extras>();
            string[] statementLines = File.ReadAllLines(numeFisier);
            var extrasParser = _extrasParserFactory.Create();
            listaExtrase = extrasParser.Parse(statementLines);
            return listaExtrase;
        }

        private void StatementGridRowClick(object sender, RowClickEventArgs e)
        {
            int rowHandle = e.RowHandle;
        }

    }

    public interface IStatementFormPresenter
    {
        List<Extras> CreateRuntimeExtrasList(string numeFisier);
    }
}
