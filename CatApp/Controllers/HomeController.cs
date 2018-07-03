using CatApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CatApp.Controllers
{
    public class HomeController : Controller
    {
        public static HttpClient client = new HttpClient();
        

        public static async Task<CategoriesViewModel> GetAllCategories()
        {
            var model = new CategoriesViewModel();
            try
            {
                string uri = "http://thecatapi.com/api/categories/list";
                var response = await client.GetStreamAsync(uri);
                model = DeserializeXMLToObject<CategoriesViewModel>(response, "categories");
            }
            catch (Exception ex)
            {
                var exception = ex;
            }
            return model;
        }

        public static T DeserializeXMLToObject<T>(Stream stream, string startingNode)
        {
            T returnObject = default(T);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (var xmlReader = XmlReader.Create(stream))
                {
                    xmlReader.ReadToFollowing(startingNode); 
                    returnObject = (T)serializer.Deserialize(xmlReader);
                }
            }
            catch (Exception ex)
            {
                var exception = ex.InnerException;
            }
            return returnObject;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await GetAllCategories();

            var selectListItems = categories.Categories.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name }).ToList();
            categories.lstCategories = selectListItems;

            return View(categories);
        }

        public async Task<JsonResult> GetImagesForCategory(string Category)
        {
            var uri = "http://thecatapi.com/api/images/get?format=xml&amp;results_per_page={10}&amp;category=" + Category;

         
            var response = await client.GetStringAsync(uri);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);

            XmlNodeList ImageUrlNL = doc.GetElementsByTagName("url");

            List<string> ImageUrls = new List<string>();
            if (ImageUrlNL.Count <= 1)
            {
                foreach (XmlNode node in ImageUrlNL)
                {
                    ImageUrls.Add(node.InnerText);
                }

            }

            return Json(ImageUrls);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
