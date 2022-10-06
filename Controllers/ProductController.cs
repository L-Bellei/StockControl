using Microsoft.AspNetCore.Mvc;
using StockControl.Entities;
using StockControl.Interfaces;
using StockControl.Models;

namespace StockControl.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService services;

        public ProductController(IProductService services)
        {
            this.services = services;
        }

        public IActionResult Product()
        {
            try
            {
                return View();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public IActionResult AddProduct()
        {
            try
            {
                return View();

            } catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<ProductViewModel> CreateProductAsync([FromBody] ProductViewModel product)
        {
            try
            {
                var item = await services.AddProductAsync(product);

                if (item == null) throw new Exception("Unexpected Error");

                ProductViewModel prod = new()
                {
                    Category = item.Category.CategoryName,
                    Name = item.Name,
                    Price = item.Price,
                };

                return prod;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
