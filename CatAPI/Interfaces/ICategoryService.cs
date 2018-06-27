using CatAPI.Models;
using System.Collections.Generic;

namespace CatAPI.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
    }
}
