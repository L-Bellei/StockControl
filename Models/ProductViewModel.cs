namespace StockControl.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public ProductViewModel()
        {
        }

        public ProductViewModel(string Name, decimal Price, string Category)
        {
            this.Name = Name;
            this.Price = Price;
            this.Category = Category;
        }
    }
}
