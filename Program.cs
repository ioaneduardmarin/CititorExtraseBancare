using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankStatementReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();
            IStatementFormFactory statementFormFactory = new StatementFormFactory();
            IStatementFormPresenterFactory statementFormPresenterFactory = new StatementFormPresenterFactory();
            DialogService dialogService=new DialogService();
            IMainFormPresenter presenter = new MainFormPresenter(mainForm, statementFormFactory, statementFormPresenterFactory, dialogService);
            Application.Run(mainForm);
        }
    }
}
