using Models;

namespace Parser.Repositories
{
    public class StockParser : Parser<Stock>
    {
        public StockParser(string filepath) : base(filepath)
        {
        }
    }
}
