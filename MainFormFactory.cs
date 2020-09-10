namespace BankStatementReader
{
    public interface IMainFormFactory
    {
        IMainForm Create();
    }
    public class MainFormFactory : IMainFormFactory
    {
        public IMainForm Create()
        {
            return new MainForm();
        }
    }
}
