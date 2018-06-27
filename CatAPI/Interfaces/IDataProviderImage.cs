using CatAPI.Models;
using System.Collections.Generic;

namespace CatAPI.Interfaces
{
    public interface IDataProviderImage
    {
         List<Image> GetAllImages();
    }
}
