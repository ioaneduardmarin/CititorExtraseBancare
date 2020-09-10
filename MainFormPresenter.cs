using System;

namespace BankStatementReader
{
    class MainFormPresenter : IMainFormPresenter
    {
        private int _statementFormCounter = 0;
        private readonly IMainForm _mainForm;
        private readonly IStatementFormFactory _statementFormFactory;
        private readonly IStatementFormPresenterFactory _statementFormPresenterFactory;
        private readonly IDialogService _dialogService;
        private readonly IExtrasParserFactory _extrasParserFactory;
        public static string NumeFisier { get; set; }

        public MainFormPresenter(IMainForm mainForm, IStatementFormFactory statementFormFactory, IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService, IExtrasParserFactory extrasParserFactory)
        {
            _mainForm = mainForm;
            _statementFormFactory = statementFormFactory;
            _statementFormPresenterFactory = statementFormPresenterFactory;
            _dialogService = dialogService;
            _extrasParserFactory = extrasParserFactory;
            _mainForm.OpenButtonClicked += OnOpenButtonClick;
        }

        public void OnOpenButtonClick(object sender, EventArgs e)
        {
            NumeFisier = _dialogService.OpenFile();
            _statementFormCounter += 1;
            if (String.IsNullOrEmpty(NumeFisier) == false)
            {
                var statementForm = _statementFormFactory.Create();
                statementForm.Text += _statementFormCounter + " ,Cale Fisier: " + NumeFisier;
                var statementFormPresenter = _statementFormPresenterFactory.Create(_extrasParserFactory, statementForm);
                _mainForm.ShowStatementForm(statementForm);
            }
        }
    }

    public interface IMainFormPresenter
    {
        void OnOpenButtonClick(object sender, EventArgs e);
    }
}
