using System;
using System.Windows.Forms;

namespace BankStatementReader
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            IStatementFormFactory statementFormFactory = new StatementFormFactory();
            IExtrasParserFactory extrasParserFactory = new ExtrasParserFactory();
            IStatementFormPresenterFactory statementFormPresenterFactory = new StatementFormPresenterFactory();
            IDialogService dialogService = new DialogService();
            IMainFormPresenterFactory mainFormPresenterFactory = new MainFormPresenterFactory();
            var presenter = mainFormPresenterFactory.Create(mainForm, statementFormFactory, statementFormPresenterFactory, dialogService, extrasParserFactory);
            Application.Run(mainForm);
        }
    }
}
