using CatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CatAPI.ViewModels
{
    public class ImagesViewModel
    {
        public ImagesViewModel()
        {
            _images = new List<Image>();
        }

        private List<Image> _images;
        public List<Image> Images
        {
            get { return _images; }
            set { _images = value; }
        }
    }
}
