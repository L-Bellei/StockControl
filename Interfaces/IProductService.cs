using StockControl.Entities;
using StockControl.Models;

namespace StockControl.Interfaces
{
    public interface IProductService
    {
        Task<ProductModel> AddProductAsync(ProductViewModel product); 
        Task<ProductModel> GetProductByIdAsync(Guid Id);
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<ProductModel> UpdateProductAsync(Guid Id, ProductModel product);
        void DeleteProductAsync(Guid Id);
    }
}
