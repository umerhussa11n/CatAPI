using CatAPI.Interfaces;
using CatAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CatAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Images")]
    public class ImagesAPIController : Controller
    {
        IImageService _imageService;
        public ImagesAPIController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [Route("Get")]
        [Produces("application/xml")]
        public ActionResult Get(string category)
        {
            if (category.Length < 3)
            {
                return BadRequest("length of specified cateogry too short, minimum three characters required");
            }

            var model = new ImagesViewModel();
            var images = _imageService.GetImages(category);
            model.Images = images;
            if (model.Images.Count > 0)
            {
                return Ok(model);
            }
            else
            {
                return NotFound("Unable to find any images for this category");
            }
        }        
     }
}
