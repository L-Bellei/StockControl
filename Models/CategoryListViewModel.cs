namespace StockControl.Models
{
    public class CategoryListViewModel
    {
        public List<string> Categories { get; set; }

        public CategoryListViewModel()
        {
        }

        public CategoryListViewModel(List<string> Categories)
        {
            this.Categories = Categories;
        }
    }
}
