using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace BankStatementReader
{
    class StatementFormPresenter : IStatementFormPresenter
    {
        private readonly IExtrasParserFactory _extrasParserFactory;
        private readonly IStatementForm _statementForm;
        private List<Extras> _listaExtrase;

        public StatementFormPresenter(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm)
        {
            _statementForm = statementForm;
            _extrasParserFactory = extrasParserFactory;
            _statementForm.StatementShown += ShownStatementForm;
            _statementForm.StatementGridRowClicked += StatementGridRowClick;
        }

        public List<Extras> CreateRuntimeExtrasList(string numeFisier)
        {
            List<Extras> listaExtrase = new List<Extras>();
            string[] statementLines = File.ReadAllLines(numeFisier);
            var extrasParser = _extrasParserFactory.Create();
            listaExtrase = extrasParser.Parse(statementLines);
            _listaExtrase = listaExtrase;
            return listaExtrase;
        }

        public string ObtineNumeFisier()
        {
            return MainFormPresenter.NumeFisier;
        }

        public void ShownStatementForm(object sender, EventArgs e)
        {
            string numeFisier = ObtineNumeFisier();
            List<Extras> listaExtrase = CreateRuntimeExtrasList(numeFisier);
            _statementForm.BindStatements(_listaExtrase);
            _statementForm.BindTransactions(_listaExtrase[0]);
        }

        private void StatementGridRowClick(object sender, RowClickEventArgs e)
        {
            int rowHandle = e.RowHandle;
            _statementForm.BindTransactions(_listaExtrase[rowHandle]);
        }
    }

    public interface IStatementFormPresenter
    {
        List<Extras> CreateRuntimeExtrasList(string numeFisier);
    }
}
