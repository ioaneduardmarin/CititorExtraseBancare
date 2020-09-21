using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace BankStatementReader
{
    public partial class StatementForm : Form, IStatementForm
    {
        public StatementForm()
        {
            InitializeComponent();
        }

        public bool IsActive { get; }
        public void BindStatements(BindingList<StatementGridItemModel> listaExtrase)
        {
            StatementsGrid.DataSource = listaExtrase;
        }

        public void BindTransactions(BindingList<TransactionGridItemModel> listaTranzactii)
        {
            TransactionsGrid.DataSource = listaTranzactii;
        }

        public event EventHandler OnStatementShown
        {
            add => Shown += value;
            remove => Shown -= value;
        }

        public event RowClickEventHandler OnStatementGridRowClick
        {
            add => StatementsGridView.RowClick += value;
            remove => StatementsGridView.RowClick -= value;
        }

        public event FormClosedEventHandler OnStatementFormClosing
        {
            add => FormClosed += value;
            remove => FormClosed += value;
        }

        public event EventHandler OnStatementFormActivating
        {
            add => Activated += value;
            remove => Activated -= value;
        }

        public void CloseStatementForm()
        {
            this.Close();
        }

        public void ActivateStatementForm()
        {
            this.Activate();
        }

        public void SetMdiParent(Form mdiParent)
        {
            this.MdiParent = mdiParent;
        }
    }

    public interface IStatementForm
    {
        string Text { get; set; }
        event RowClickEventHandler OnStatementGridRowClick;
        event EventHandler OnStatementShown;
        void BindStatements(BindingList<StatementGridItemModel> listaExtrase);
        void BindTransactions(BindingList<TransactionGridItemModel> listaTranzactii);
        void Show();
        void CloseStatementForm();
        event FormClosedEventHandler OnStatementFormClosing;
        void ActivateStatementForm();
        void SetMdiParent(Form mdiParent);
        event EventHandler OnStatementFormActivating;
    }
}
