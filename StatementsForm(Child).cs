using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data.XtraReports.DataProviders;
using DevExpress.XtraGrid.Views.Grid;

namespace BankStatementReader
{
    public partial class StatementForm : Form, IStatementForm
    {
        public StatementForm()
        {
            InitializeComponent();
        }

        public event RowClickEventHandler StatementGridRowClicked
        {
            add
            {
                StatementsGridView.RowClick += value;
            }
            remove
            {
                StatementsGridView.RowClick -= value;
            }
        }

        public void BindStatements( List<Extras> listaExtrase)
        {
            BindingList<StatementGridItemModel> statementGridData = new BindingList<StatementGridItemModel>();
            statementGridData.Clear();
            for (int index = 0; index < listaExtrase.Count; index += 1)
            {
                statementGridData.Add(new StatementGridItemModel(listaExtrase[index]));
            }
            StatementsGrid.DataSource = statementGridData;
        }

        public void BindTransactions(StatementForm statementForm, Extras extras)
        {
            BindingList<TransactionGridItemModel> listaTranzactii = new BindingList<TransactionGridItemModel>();
            listaTranzactii.Clear();
            for (int index = 0; index < extras.Tranzactii.Count; index += 1)
            {
                listaTranzactii.Add(new TransactionGridItemModel(extras.Tranzactii[index]));
            }
            statementForm.TransactionsGrid.DataSource = listaTranzactii;
        }

        public event EventHandler StatementShown
        {
            add
            {
                this.Shown += value;
            }
            remove
            {
                this.Shown -= value;
            }
        }
    }

    public interface IStatementForm
    {
        string Text { get; set; }

        event RowClickEventHandler StatementGridRowClicked;
        event EventHandler StatementShown;
        void BindStatements(List<Extras> listaExtrase);
        void BindTransactions(StatementForm statementForm, Extras extras);
        void Show();
    }
}
