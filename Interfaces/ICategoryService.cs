using StockControl.Entities;

namespace StockControl.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryModel> AddCategoryAsync(CategoryModel category);
        Task<CategoryModel> GetCategoryByIdAsync(Guid id);
        Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync();
        Task<CategoryModel> UpdateCategoryAsync(Guid id, CategoryModel category);
        void DeleteCategoryAsync(Guid id);
    }
}
