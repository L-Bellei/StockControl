using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using StockControl.Entities;
using StockControl.Interfaces;

namespace StockControl.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService services;

        public CategoryController(ICategoryService services)
        {
            this.services = services;
        }

        [Route("category")]
        public IActionResult Category()
        {
            return View();
        }

        [Route("addcategory")]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpGet]
        [Route("getcategories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var categories = await services.GetAllCategoriesAsync();

                if (categories.Any())
                {
                    return Ok(new JsonResult(categories));
                }

                return BadRequest(new JsonResult(null));

            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
