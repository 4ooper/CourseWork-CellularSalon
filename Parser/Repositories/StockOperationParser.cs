using Models;

namespace Parser.Repositories
{
    public class StockOperationParser : Parser<StockOperation>
    {
        public StockOperationParser(string filepath) : base(filepath)
        {
        }
    }
}
