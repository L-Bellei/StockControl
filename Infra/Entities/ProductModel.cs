namespace StockControl.Entities
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public CategoryModel Category { get; set; }
        public List<StockModel> Stocks { get; set; }

        public ProductModel()
        {
        }

        public ProductModel(string name, decimal price, CategoryModel category)
        {
            Id = new Guid();
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
