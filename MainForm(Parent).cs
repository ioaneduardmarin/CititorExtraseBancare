using System;
using System.Windows.Forms;

namespace BankStatementReader
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler OpenButtonClicked
        {
            add
            {
                openToolStripMenuItem.Click += value;
            }
            remove
            {
                openToolStripMenuItem.Click -= value;
            }
        }

        public void ShowStatementForm(IStatementForm statementForm)
        {
            statementForm.Show();
        }
    }

    public interface IMainForm
    {
        event EventHandler OpenButtonClicked;
        void ShowStatementForm(IStatementForm statementForm);
    }
}
