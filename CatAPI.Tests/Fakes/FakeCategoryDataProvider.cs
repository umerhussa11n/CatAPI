using CatAPI.Models;
using CatAPI.Services;
using System.Collections.Generic;

namespace CatAPI.Tests
{
    public class FakeCategoryDataProvider : InMemoryDataProvider
    {
        public override List<Category> GetAllCategories()
        {
            var allCategories =
               new List<Category>
                        {
                            new Category { Id = 1, Name = "Hats" },
                            new Category { Id = 2, Name = "Shirts" },
                            new Category { Id = 2, Name = "Shoes" }
                       };

            return allCategories;
        }
    }
}
