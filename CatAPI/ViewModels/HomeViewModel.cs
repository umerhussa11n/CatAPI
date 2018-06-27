using CatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAPI.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            _categories = new List<Category>();
        }

        public string Title { get; set; }

        private List<Category> _categories; 
        public List<Category> Categories
        {
            get { return _categories; }
            set { _categories = value;  }
        }
    }
}
