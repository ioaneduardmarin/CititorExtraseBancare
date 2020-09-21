using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankStatementReader.Parser;
using DevExpress.XtraGrid.Views.Grid;

namespace BankStatementReader
{
    public class StatementFormPresenter : IStatementFormPresenter
    {
        private readonly IExtrasParserFactory _extrasParserFactory;
        private readonly IStatementForm _statementForm;
        private readonly IDialogService _dialogService;
        private readonly IReportBuilder _reportBuilder;
        private List<Extras> _listaExtrase;
        private BindingList<StatementReportDataSource> _listaExtraseReport;

        public StatementFormPresenter(IExtrasParserFactory extrasParserFactory, IStatementForm statementForm, IDialogService dialogService, IReportBuilder reportBuilder)
        {
            _statementForm = statementForm;
            _extrasParserFactory = extrasParserFactory;
            _dialogService = dialogService;
            _reportBuilder = reportBuilder;
            _statementForm.OnStatementShown += WhenStatementFormShown;
            _statementForm.OnStatementGridRowClick += StatementGridRowClick;
            _statementForm.OnStatementFormClosing += AfterStatementFormClosed;
            _statementForm.OnStatementFormActivating += ActiveStatments;
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
            string[] statementLines = File.ReadAllLines(numeFisier);
            var extrasParser = _extrasParserFactory.Create();
            List<Extras> listaExtrase = extrasParser.Parse(statementLines);
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
                await Task.Run(() => statementsBindingList = GetStatementsBindingList(listaExtrase));
                transactionsBindingList = GetTransactionsBindingList(listaExtrase[0]);
                _statementForm.Text = _statementForm.Text.Substring(_statementForm.Text.LastIndexOf('\\') + 1);
                _statementForm.BindStatements(statementsBindingList);
                _statementForm.BindTransactions(transactionsBindingList);
                CreateReportBindingList(listaExtrase);
            }
            catch (ArgumentException)
            {
                _dialogService.Show("Fisierul nu este valid.");
                _statementForm.CloseStatementForm();
            }
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

        public BindingList<StatementGridItemModel> GetStatementsBindingList(List<Extras> listaExtrase)
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

        public List<TransactionItemReportModel> GetTransactionsReportBindingList(Extras extras)
        {
            List<TransactionItemReportModel> listaTranzactii = new List<TransactionItemReportModel>();
            listaTranzactii.Clear();
            for (int index = 0; index < extras.Tranzactii.Count; index += 1)
            {
                listaTranzactii.Add(new TransactionItemReportModel(extras.Tranzactii[index]));
            }
            return listaTranzactii;
        }

        public BindingList<StatementReportDataSource> CreateReportBindingList(List<Extras> listaExtrase)
        {
            BindingList<StatementReportDataSource> listaExtraseReport = new BindingList<StatementReportDataSource>();
            listaExtraseReport.Clear();
            for (int indexExtras = 0; indexExtras < listaExtrase.Count; indexExtras += 1)
            {
                var reportDataSource = new StatementReportDataSource(listaExtrase[indexExtras]);
                reportDataSource.Id = listaExtrase[indexExtras].ExtrasId;
                reportDataSource.NumarReferintaCont = listaExtrase[indexExtras].NumarReferinta;
                reportDataSource.ContIban = listaExtrase[indexExtras].Iban;
                reportDataSource.NumarExtras = listaExtrase[indexExtras].NrExtras;
                reportDataSource.SumaSoldInitial = listaExtrase[indexExtras].SumaSoldInitial;
                reportDataSource.SumaSoldFinalRezervat = listaExtrase[indexExtras].SumaSoldRezervat;
                reportDataSource.SumaSoldFinalDisponibil = listaExtrase[indexExtras].SumaSoldFinalDisponibil;
                reportDataSource.DataExtras = listaExtrase[indexExtras].DataSoldInitial;
                reportDataSource.ValutaCont = listaExtrase[indexExtras].ValutaSoldInitial;
                reportDataSource.Tranzactii = GetTransactionsReportBindingList(listaExtrase[indexExtras]);
                listaExtraseReport.Add(reportDataSource);
            }
            return listaExtraseReport;
        }

        public StatementReport CreateReport()
        {
            StatementReport statementReport = _reportBuilder.CreateReport(this);
            var listaExtraseReport = CreateReportBindingList(_listaExtrase);
            statementReport.BindReportData(listaExtraseReport);
            return statementReport;
        }
    }

    public interface IStatementFormPresenter
    {
        void SetMdiParent(Form mdiParent);
    }
}
