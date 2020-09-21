using System;
using System.Threading;
using System.Windows.Forms;
using BankStatementReader.Parser;

namespace BankStatementReader
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ApplicationOnThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUhandledException;

            var mainForm = new MainForm();
            IStatementReport statementReport= new StatementReport();
            IStatementFormFactory statementFormFactory = new StatementFormFactory();
            IExtrasParserFactory extrasParserFactory = new ExtrasParserFactory();
            IStatementFormPresenterFactory statementFormPresenterFactory = new StatementFormPresenterFactory();
            IDialogService dialogService = new DialogService();
            IMainFormPresenterFactory mainFormPresenterFactory = new MainFormPresenterFactory();
            IReportBuilder reportBuilder= new ReportBuilder();
            var presenter = mainFormPresenterFactory.Create(mainForm, statementFormFactory, statementFormPresenterFactory, dialogService, extrasParserFactory, reportBuilder);
            Application.Run(mainForm);

            void CurrentDomainOnUhandledException(object sender, UnhandledExceptionEventArgs e)
            {
                var mesaj = String.Format("A avut loc o eroare!\r\n" + "{0}\r\n", ((Exception)e.ExceptionObject).Message);
                Console.WriteLine("Error {0}: {1}", DateTimeOffset.Now, (Exception)e.ExceptionObject);
                MessageBox.Show(mesaj, "Eroare neasteptata");
            }

            void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e)
            {
                var mesaj = String.Format("A avut loc o eroare!\r\n" + "{0}\r\n", e.Exception.Message);
                Console.WriteLine("Error {0}: {1}", DateTimeOffset.Now, e.Exception);
                MessageBox.Show(mesaj, "Eroare neasteptata");
            }
        }
    }
}
