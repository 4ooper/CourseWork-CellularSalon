namespace Models
{
    public class Stock
    {
        public string model;
        public int count;

        public Stock() { }

        public Stock(string model, int count)
        {
            this.model = model;
            this.count = count;
        }
    }
}
