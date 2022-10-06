using Microsoft.EntityFrameworkCore;
using StockControl.Entities;
using StockControl.Interfaces;
using StockControl.Models;

namespace StockControl.Services
{
    public class ProductService : IProductService
    {
        private readonly Infra.AppContext db;

        public ProductService(Infra.AppContext db)
        {
            this.db = db;
        }

        public async Task<ProductModel> AddProductAsync(ProductViewModel product)
        {
            CategoryModel? category = await db.Categories.Where(c => c.CategoryName == product.Category).FirstOrDefaultAsync();

            ProductModel prod = new ProductModel
            {
                Category = category,
                Name = product.Name,
                Price = product.Price,
            };

            await db.Products.AddAsync(prod);
            await db.SaveChangesAsync();

            var productAdded = db.Products.Select(p => p).Where(p => p.Name == product.Name).FirstOrDefault();

            if (productAdded != null)
                return productAdded;

            else 
                throw new Exception("Could not add product");
        }

        public async void DeleteProductAsync(Guid Id)
        {
            var product = await db.Products.FirstOrDefaultAsync(p => p.Id == Id);

            if (product != null && !(db.Stock.Select(s => s.ProductId == Id).ToList().Count > 0))
            {
                db.Products.Remove(product);

                await db.SaveChangesAsync();
            }
            else
                throw new Exception("Can not possible to exclude this product");
        }

        public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            IEnumerable<ProductModel> products = await db.Products.ToListAsync();

            if (products.Any())
                return products;
            else
                throw new Exception("Don't have products registereds");
        }

        public async Task<ProductModel> GetProductByIdAsync(Guid Id)
        {
            var product = await db.Products.Select(p => p).Where(p => p.Id == Id).FirstOrDefaultAsync();

            if (product != null)
                return product;
            else
                throw new Exception("Don't have product with this id");
        }

        public async Task<ProductModel> UpdateProductAsync(Guid Id, ProductModel product)
        {
            var productFinded = await db.Products.Where(p => p.Id == Id).FirstOrDefaultAsync();

            if(productFinded != null)
            {
                ProductModel productUpdated = productFinded; 

                productUpdated.Name = product.Name;
                productUpdated.Price = product.Price;
                productUpdated.Category = product.Category;

                db.Products.Update(productUpdated);
                await db.SaveChangesAsync();
            
                return productUpdated;
            }
            else 
                throw new Exception("Can not possible to update this product");
        }
    }
}
