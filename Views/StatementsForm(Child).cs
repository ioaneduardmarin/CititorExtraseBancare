using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void BindStatements(BindingList<StatementGridItemModel> listaExtrase)
        {
            StatementsGrid.DataSource = listaExtrase;
        }

        public void BindTransactions(BindingList<TransactionGridItemModel> listaTranzactii)
        {
            TransactionsGrid.DataSource = listaTranzactii;
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

        public event FormClosedEventHandler WhenStatementFormClosed
        {
            add
            {
                this.FormClosed += value;
            }
            remove
            {
                this.FormClosed += value;
            }
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

        public event EventHandler ActiveStatementForm
        {
            add
            {
                this.Activated += value;
            }
            remove
            {
                this.Activated -= value;
            }
        }
    }

    public interface IStatementForm
    {
        string Text { get; set; }
        event RowClickEventHandler StatementGridRowClicked;
        event EventHandler StatementShown;
        void BindStatements(BindingList<StatementGridItemModel> listaExtrase);
        void BindTransactions(BindingList<TransactionGridItemModel> listaTranzactii);
        void Show();
        void CloseStatementForm();
        event FormClosedEventHandler WhenStatementFormClosed;
        void ActivateStatementForm();
        void SetMdiParent(Form mdiParent);
        event EventHandler ActiveStatementForm;
    }
}
