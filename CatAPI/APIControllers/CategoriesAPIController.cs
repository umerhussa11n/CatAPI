using CatAPI.Interfaces;
using CatAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CatAPI.Controllers
{
    [Route("api/Categories")]
    public class CategoriesAPIController : Controller
    {
        ICategoryService _categoryService;
        ILogger _logger;
        public CategoriesAPIController(ICategoryService categoryService, ILogger<CategoriesAPIController> logger)
        {
            _categoryService = categoryService;
            _logger = logger;
        }

        [HttpGet]
        [Route("list")]
        [Produces("application/xml")]
        public List<Category> List()
        {
            _logger.LogInformation("api/CategoriesAPI/list");
            var categories = _categoryService.GetAllCategories();
            return categories;
        }
    }
}
