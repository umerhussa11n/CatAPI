using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CatApp.Models
{
    [XmlRoot("categories")]
    public class CategoriesViewModel
    {
        public CategoriesViewModel()
        {
            _categories = new List<Category>();
            _lstCategories = new List<SelectListItem>();
        }


        private List<Category> _categories;
        [XmlElement("category")]
        public List<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        private List<SelectListItem> _lstCategories;
        public List<SelectListItem> lstCategories
        {
             get { return _lstCategories;  }
            set { _lstCategories = value;  }
        }



        public string SelectedCategory { get; set; }

        public class Category 
        {
            [XmlElement("id")]
            [Key]
            public int Id { get; set; }

            [XmlElement("name")]
            public string Name { get; set; }
        }

    }
}
