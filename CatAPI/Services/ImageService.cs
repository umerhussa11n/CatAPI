using CatAPI.Interfaces;
using CatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAPI.Services
{
    public class ImageService : Interfaces.IImageService 
    {
        IDataProviderImage _dataProvider;
        public ImageService(IDataProviderImage dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public List<Image> AllImages
        {
            get { return _dataProvider.GetAllImages();  }
        }

        public List<Image> GetImages(string Category)
        {
            var images = new List<Image>();
            if (!string.IsNullOrWhiteSpace(Category))
            {
                images = AllImages.Where(x => x.CategoryName == Category.ToLower()).ToList();
            }
            else
            {
                images = AllImages;
            }
            return images;
        }
    }
}
