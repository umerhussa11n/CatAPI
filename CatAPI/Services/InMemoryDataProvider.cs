using CatAPI.Interfaces;
using CatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAPI.Services
{
    public class InMemoryDataProvider : IDataProviderCategory, IDataProviderImage
    {
        public virtual List<Category> GetAllCategories()
        {
            var allCategories =
               new List<Category>
                        {
                            new Category { Id = 1, Name = "Hats" },
                            new Category { Id = 2, Name = "Shirts" }
                       };

            return allCategories;
        }

        public List<Image> GetAllImages()
        {
            var images = new List<Image> { };
            images.Add(new Image { Id = "5if", CategoryId = 1, CategoryName = "hat", Source_URL = "http://thecatapi.com/?Id=5if", URL = "http://image1.jpg" });
            images.Add(new Image { Id = "6if", CategoryId = 2, CategoryName = "hat", Source_URL = "http://thecatapi.com/?Id=6if", URL = "http://image2.jpg" });
            images.Add(new Image { Id = "7if", CategoryId = 3, CategoryName = "shirt", Source_URL = "http://thecatapi.com/?Id=7if", URL = "http://image3.jpg" });

            return images;
        }
    }
}
