using CatAPI.Services;
using Xunit;

namespace CatAPI.Tests
{
    public class CategoryServiceTest
    {
        [Fact]
        public void CategoryService_WhenAllCategoriesAreRequested_ShouldReturnAllCategories()
        {
            var fakeCategoryDataProvider = new FakeCategoryDataProvider();
            var categoryService = new CategoryService(fakeCategoryDataProvider);
            var allCategories = categoryService.GetAllCategories();
            Assert.Equal(3, allCategories.Count);
        }
    }
}
