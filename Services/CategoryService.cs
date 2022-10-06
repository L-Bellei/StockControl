using Microsoft.EntityFrameworkCore;
using StockControl.Entities;
using StockControl.Interfaces;

namespace StockControl.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly Infra.AppContext db;

        public CategoryService(Infra.AppContext db)
        {
            this.db = db;
        }

        public Task<CategoryModel> AddCategoryAsync(CategoryModel category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync()
        {
            IEnumerable<CategoryModel> categories = await db.Categories.ToListAsync();

            return categories;
        }

        public Task<CategoryModel> GetCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> UpdateCategoryAsync(Guid id, CategoryModel category)
        {
            throw new NotImplementedException();
        }
    }
}
