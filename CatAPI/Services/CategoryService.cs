using CatAPI.Interfaces;
using CatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CatAPI.Services
{
    public class CategoryService : ICategoryService
    {
        IDataProviderCategory _dataProvider;
        public CategoryService(IDataProviderCategory dataProvider)
        {
            _dataProvider = dataProvider;
        }
        public List<Category> GetAllCategories()
        {
            var allCategories = _dataProvider.GetAllCategories();
            return allCategories;
        }
    }
}
