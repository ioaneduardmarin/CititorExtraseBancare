using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadsHoppingStateMachine;
using DialogResult = DevExpress.Utils.CommonDialogs.Internal.DialogResult;

namespace BankStatementReader
{
    class DialogService:IDialogService
    {
        public string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Statement files|* .STA" };
            string numeFisier;
            if (openFileDialog.ShowDialog() == (System.Windows.Forms.DialogResult) DialogResult.OK)
            {
               return numeFisier = openFileDialog.FileName;
            }
            else
            {
                return "";
            }
        }
    }
    public interface IDialogService
    {
        string OpenFile();
    }
}
