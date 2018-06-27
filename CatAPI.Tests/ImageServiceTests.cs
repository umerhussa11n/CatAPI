using CatAPI.Interfaces;
using CatAPI.Tests.Fakes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CatAPI.Services;
using System.Linq;

namespace CatAPI.Tests
{
    public class ImageServiceTests
    {
        IDataProviderImage DataProvider;
        public ImageServiceTests()
        {
            DataProvider  = new FakeImageDataProvider();
        }

        [Fact]
        public void ImageService_IfCategoryIsNotProvided_ReturnsAllImages()
        {
            var imageService = new ImageService(DataProvider);
            var imageCategory = string.Empty;
            var images = imageService.GetImages(imageCategory);
            var allImages = imageService.AllImages;
            Assert.Equal(images.Count, allImages.Count);

            imageCategory = null;
            images = imageService.GetImages(imageCategory);
            Assert.Equal(allImages.Count, images.Count);

            imageCategory = " ";
            images = imageService.GetImages(imageCategory);
            Assert.Equal(allImages.Count, images.Count);
        }

        [Fact]
        public void ImageService_IfCategoryIsProvided_FilterReturnedImages()
        {
            var imageService = new ImageService(DataProvider);
            var imageCategory = "hats";
            var images = imageService.GetImages(imageCategory);
            var expectedImages = imageService.AllImages.Where(x => x.CategoryName == imageCategory);
            Assert.Equal(expectedImages.Count(), images.Count);
        }
    }
}
