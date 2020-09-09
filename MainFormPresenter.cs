using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace BankStatementReader
{
    class MainFormPresenter : IMainFormPresenter
    {
        private readonly IMainForm _mainForm;
        private readonly IStatementFormFactory _statementFormFactory;
        private readonly IStatementFormPresenterFactory _statementFormPresenterFactory;
        private readonly IDialogService _dialogService;
        private readonly IExtrasParserFactory _extrasParserFactory;
        public static string NumeFisier { get; set; }


        public MainFormPresenter(IMainForm mainForm, IStatementFormFactory statementFormFactory, IStatementFormPresenterFactory statementFormPresenterFactory, IDialogService dialogService)
        {
            _mainForm = mainForm;
            _statementFormFactory = statementFormFactory;
            _statementFormPresenterFactory = statementFormPresenterFactory;
            _dialogService = dialogService;
            mainForm.OpenButtonClicked += OnOpenButtonClick;
        }

        public void OnOpenButtonClick(object sender, EventArgs e)
        {
            NumeFisier = _dialogService.OpenFile();

            if (String.IsNullOrEmpty(NumeFisier) == false)
            {
                var statementForm = _statementFormFactory.Create();
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
