using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace BankStatementReader
{
    public class StatementFormPresenter : IStatementFormPresenter
    {
        private readonly IExtrasParserFactory _extrasParserFactory;
        private readonly IStatementForm _statementForm;
        private readonly IDialogService _dialogService;
        private List<Extras> _listaExtrase;

        public StatementFormPresenter(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm, IDialogService dialogService)
        {
            _statementForm = statementForm;
            _extrasParserFactory = extrasParserFactory;
            _dialogService = dialogService;
            _statementForm.StatementShown += WhenStatementFormShown;
            _statementForm.StatementGridRowClicked += StatementGridRowClick;
            _statementForm.WhenStatementFormClosed += AfterStatementFormClosed;
            _statementForm.ActiveStatementForm += ActiveStatments;
        }

        private void ActiveStatments(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new ActiveStatementMessage(this));
        }

        private void AfterStatementFormClosed(object sender, FormClosedEventArgs e)
        {
            EventAggregator.Instance.Publish(new CloseStatementFormMessage(this));
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

        public void SetMdiParent(Form mdiParent)
        {
            _statementForm.SetMdiParent(mdiParent);
        }

        public string ObtineNumeFisier(string numeFisier)
        {
            return numeFisier;
        }

        public async void WhenStatementFormShown(object sender, EventArgs e)
        {
            string numeFisier = ObtineNumeFisier(_statementForm.Text);
            List<Extras> listaExtrase = CreateRuntimeExtrasList(numeFisier);
            try
            {
                BindingList<StatementGridItemModel> statementsBindingList = new BindingList<StatementGridItemModel>();
                BindingList<TransactionGridItemModel> transactionsBindingList = new BindingList<TransactionGridItemModel>();
                await Task.Run(() => statementsBindingList = GetBindingStatementsList(listaExtrase));
                transactionsBindingList = GetTransactionsBindingList(listaExtrase[0]);
                _statementForm.Text = _statementForm.Text.Substring(_statementForm.Text.LastIndexOf('\\') + 1);
                _statementForm.BindStatements(statementsBindingList);
                _statementForm.BindTransactions(transactionsBindingList);
            }
            catch (ArgumentException)
            {
                _dialogService.Show("Fisierul nu este valid.");
                _statementForm.CloseStatementForm();
            }
        }

        public void CloseStatementFile(StatementForm statementForm)
        {
            statementForm.CloseStatementForm();
        }

        private void StatementGridRowClick(object sender, RowClickEventArgs e)
        {
            int rowHandle = e.RowHandle;
            BindingList<TransactionGridItemModel> transactionsBindingList = GetTransactionsBindingList(_listaExtrase[rowHandle]);
            _statementForm.BindTransactions(transactionsBindingList);
        }

        public void Activate()
        {
            _statementForm.ActivateStatementForm();
        }

        public string GetStatementFormName()
        {
            return _statementForm.Text;
        }

        public BindingList<StatementGridItemModel> GetBindingStatementsList(List<Extras> listaExtrase)
        {
            BindingList<StatementGridItemModel> statementGridData = new BindingList<StatementGridItemModel>();
            statementGridData.Clear();
            for (int index = 0; index < listaExtrase.Count; index += 1)
            {
                statementGridData.Add(new StatementGridItemModel(listaExtrase[index]));
            }

            return statementGridData;
        }

        public BindingList<TransactionGridItemModel> GetTransactionsBindingList(Extras extras)
        {
            BindingList<TransactionGridItemModel> listaTranzactii = new BindingList<TransactionGridItemModel>();
            listaTranzactii.Clear();
            for (int index = 0; index < extras.Tranzactii.Count; index += 1)
            {
                listaTranzactii.Add(new TransactionGridItemModel(extras.Tranzactii[index]));
            }
            return listaTranzactii;
        }
    }

    public interface IStatementFormPresenter
    {
        List<Extras> CreateRuntimeExtrasList(string numeFisier);
        void SetMdiParent(Form mdiParent);
    }
}
