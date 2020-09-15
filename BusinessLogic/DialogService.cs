using System.IO;
using System.Security;
using System.Windows.Forms;
using DialogResult = DevExpress.Utils.CommonDialogs.Internal.DialogResult;

namespace BankStatementReader
{
    class DialogService : IDialogService
    {
        public string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "STA",
                Filter = "Statement files|* .STA"
            };
            string numeFisier;
            if (openFileDialog.ShowDialog() == (System.Windows.Forms.DialogResult)DialogResult.OK)
            {
                try
                {
                    return numeFisier = openFileDialog.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                }
            }
            else
            {
                return "";
            }
            return null;
        }

        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }


    public interface IDialogService
    {
        string OpenFile();
        void Show(string message);
    }
}
