using CatAPI.Models;
using System.Collections.Generic;

namespace CatAPI.Interfaces
{
    public interface IDataProviderCategory
    {
        List<Category> GetAllCategories();
    }
}
