using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankStatementReader
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler OnOpenButtonClick
        {
            add => openButton.Click += value;
            remove => openButton.Click -= value;
        }

        public event EventHandler OnWindowButtonClick
        {
            add => windowButton.Click += value;
            remove => windowButton.Click -= value;
        }

        public event EventHandler OnMainFormLoad
        {
            add => this.Load += value;
            remove => this.Load += value;
        }

        public event EventHandler OnPreviewReportButton
        {
            add => previewReportButton.Click += value;
            remove => previewReportButton.Click -= value;
        }

        public void CreateWindowDropDownList(List<Tuple<string, object>> listStatementFormTagText)
        {
            if (windowButton.DropDownItems.Count > 0)
            {
                windowButton.DropDown.Dispose();
            }

            windowButton.DropDown = new ToolStripDropDown();
            foreach (Tuple<string, object> textTagTuple in listStatementFormTagText)
            {
                var statementWindowItem = new ToolStripMenuItem();
                {
                    statementWindowItem.Text = textTagTuple.Item1;
                    statementWindowItem.Tag = textTagTuple.Item2;
                }
                windowButton.DropDownItems.Add(statementWindowItem);
                statementWindowItem.Click += OnWindowStatementClick;
            }
        }

        public void SetWindowsListDropDownEnabledState(bool windowButtonEnable)
        {
            if (!windowButtonEnable)
            {
                windowButton.Enabled = false;
            }
            else
            {
                windowButton.Enabled = true;
            }
        }

        public void SetPreviewButtonEnabledState(bool previewButtonEnable)
        {
            if (!previewButtonEnable)
            {
                previewReportButton.Enabled = false;
            }
            else
            {
                previewReportButton.Enabled = true;
            }
        }

        public event EventHandler OnWindowStatementClick;

        public void ShowStatementForm(IStatementForm statementForm)
        {
            statementForm.Show();
        }

        public Form GetForm()
        {
            return this;
        }

        public void SetMainFormTitle(string activeStatement)
        {
            Text = "Bank Statement Reader " + activeStatement;
        }
    }

    public interface IMainForm
    {
        void ShowStatementForm(IStatementForm statementForm);
        event EventHandler OnOpenButtonClick;
        event EventHandler OnWindowButtonClick;
        public void CreateWindowDropDownList(List<Tuple<string, object>> listStatementFormPresenters);
        public event EventHandler OnWindowStatementClick;
        Form GetForm();
        void SetMainFormTitle(string activeStatement);
        event EventHandler OnMainFormLoad;
        void SetWindowsListDropDownEnabledState(bool windowButtonEnable);
        event EventHandler OnPreviewReportButton;
        void SetPreviewButtonEnabledState(bool previewButtonEnable);
    }
}
