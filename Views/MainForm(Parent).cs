using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
                openButton.Click += value;
            }
            remove
            {
                openButton.Click -= value;
            }
        }

        public event EventHandler WindowButtonClicked
        {
            add
            {
                windowButton.Click += value;
            }
            remove
            {
                windowButton.Click -= value;
            }
        }

        public void WindowButtonClick(List<StatementFormPresenter> listStatementFormPresenters)
        {
            if (windowButton.DropDownItems.Count > 0)
            {
                windowButton.DropDown.Dispose();
            }

            windowButton.DropDown = new ToolStripDropDown();
            foreach (StatementFormPresenter statementFormPresenter in listStatementFormPresenters)
            {
                var statementWindowItem = new ToolStripMenuItem();
                {
                    statementWindowItem.Text = statementFormPresenter.GetStatementFormName();
                    statementWindowItem.Tag = statementFormPresenter;
                }
                windowButton.DropDownItems.Add(statementWindowItem);
                statementWindowItem.Click += WindowStatementClicked;
            }
        }

        public event EventHandler WindowStatementClicked;

        public void ShowStatementForm(IStatementForm statementForm)
        {
            statementForm.Show();
        }

        public void SetAsMdiParent(Form childForm)
        {
            childForm.MdiParent = this;
        }

        public Form GetForm()
        {
            return this;
        }

        public void RenameAfterActiveStatement(string activeStatement)
        {
            Text = "Bank Statement Reader " + activeStatement;
        }

        public bool HasChildForms()
        {
            if (this.MdiChildren.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public event EventHandler MainFormActivated
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

    public interface IMainForm
    {
        void ShowStatementForm(IStatementForm statementForm);
        event EventHandler OpenButtonClicked;
        event EventHandler WindowButtonClicked;
        public void WindowButtonClick(List<StatementFormPresenter> listStatementFormPresenters);
        public event EventHandler WindowStatementClicked;
        void SetAsMdiParent(Form childForm);
        Form GetForm();
        void RenameAfterActiveStatement(string activeStatement);
        event EventHandler MainFormActivated;
        bool HasChildForms();
    }
}
