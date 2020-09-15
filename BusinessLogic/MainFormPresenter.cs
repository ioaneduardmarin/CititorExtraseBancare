using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;

namespace BankStatementReader
{
    class MainFormPresenter : IMainFormPresenter
    {
        private readonly IMainForm _mainForm;
        private readonly IStatementFormFactory _statementFormFactory;
        private readonly IStatementFormPresenterFactory _statementFormPresenterFactory;
        private readonly IDialogService _dialogService;
        private readonly IExtrasParserFactory _extrasParserFactory;
        private string _numeFisier;
        private List<StatementFormPresenter> _listStatementFormPresenters = new List<StatementFormPresenter>();

        public MainFormPresenter(IMainForm mainForm, IStatementFormFactory statementFormFactory, IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService, IExtrasParserFactory extrasParserFactory)
        {
            _mainForm = mainForm;
            _statementFormFactory = statementFormFactory;
            _statementFormPresenterFactory = statementFormPresenterFactory;
            _dialogService = dialogService;
            _extrasParserFactory = extrasParserFactory;
            _mainForm.OpenButtonClicked += OnOpenButtonClick;
            _mainForm.WindowButtonClicked += OnWindowButtonClick;
            _mainForm.WindowStatementClicked += WindowStatementClickEvent;
            EventAggregator.Instance.Subscribe<OpenStatementFormMessage>(e => _listStatementFormPresenters.Add(e.StatementFormPresenter));
            EventAggregator.Instance.Subscribe<OpenStatementFormMessage>(e => _mainForm.WindowButtonClick(_listStatementFormPresenters));
            EventAggregator.Instance.Subscribe<ActiveStatementMessage>(e => ActiveStatementForm(e.StatementFormPresenter));
            EventAggregator.Instance.Subscribe<CloseStatementFormMessage>(e => _listStatementFormPresenters.Remove(e.StatementFormPresenter));
            EventAggregator.Instance.Subscribe<CloseStatementFormMessage>(e => ResetMainForm());
        }

        private void ResetMainForm()
        {
            if (_listStatementFormPresenters.Count == 0)
            {
                _mainForm.RenameAfterActiveStatement("");
            }
        }

        private void OnWindowButtonClick(object sender, EventArgs e)
        {
            _mainForm.WindowButtonClick(_listStatementFormPresenters);
        }

        public void OnOpenButtonClick(object sender, EventArgs e)
        {
            _numeFisier = _dialogService.OpenFile();
            if (String.IsNullOrEmpty(_numeFisier) == false)
            {
                var statementForm = _statementFormFactory.Create();
                statementForm.Text = _numeFisier;
                var statementFormPresenter = _statementFormPresenterFactory.Create(_extrasParserFactory, statementForm, _dialogService);
                statementFormPresenter.SetMdiParent(_mainForm.GetForm());
                _mainForm.WindowButtonClick(_listStatementFormPresenters);
                EventAggregator.Instance.Publish(new OpenStatementFormMessage((StatementFormPresenter)statementFormPresenter));
                _mainForm.ShowStatementForm(statementForm);
            }
        }

        public void WindowStatementClickEvent(object sender, EventArgs e)
        {
            var stripMenuItem = (ToolStripMenuItem)sender;
            var statementFormPresenter = (StatementFormPresenter)stripMenuItem.Tag;
            statementFormPresenter.Activate();
            EventAggregator.Instance.Publish(new ActiveStatementMessage(statementFormPresenter));
        }

        public async void ActiveStatementForm(StatementFormPresenter statementFormPresenter)
        {
            string statementFormName = statementFormPresenter.GetStatementFormName()
                 .Substring(statementFormPresenter.GetStatementFormName().LastIndexOf('\\') + 1);
            _mainForm.RenameAfterActiveStatement(statementFormName);
        }
    }

    public interface IMainFormPresenter
    {
        void OnOpenButtonClick(object sender, EventArgs e);
    }
}
