using CatAPI.Models;
using System.Collections.Generic;

namespace CatAPI.Interfaces
{
    public interface IImageService
    {
        List<Image> GetImages(string category);
    }
}
