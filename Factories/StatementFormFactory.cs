namespace BankStatementReader
{
    public interface IStatementFormFactory
    {
        IStatementForm Create();
    }
    public class StatementFormFactory : IStatementFormFactory
    {
        public IStatementForm Create()
        {
            return new StatementForm();
        }
    }
}
