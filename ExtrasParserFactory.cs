namespace BankStatementReader
{
    public interface IExtrasParserFactory
    {
        IExtrasParser Create();
    }
    public class ExtrasParserFactory : IExtrasParserFactory
    {
        public IExtrasParser Create()
        {
            return new ExtrasParser();
        }
    }
}
