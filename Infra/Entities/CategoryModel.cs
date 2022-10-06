namespace StockControl.Entities
{
    public class CategoryModel
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public CategoryModel(string categoryName, string description)
        {
            this.CategoryName = categoryName;
            this.Description = description;
        }
    }
}
