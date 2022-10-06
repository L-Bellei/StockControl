namespace StockControl.Entities
{
    public class StockModel
    {
        public Guid Id { get; set; }
        public Shelf Shelf { get; set; }
        public ProductModel Product { get; set; }
        public Guid ProductId { get; set; }
    }

    public enum Shelf 
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,  
        Nine = 9,
        Ten = 10
    }
}
