using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatAPI.Models
{
    public class Image
    {
        public string Id { get; set; }

        public string URL { get; set; }

        public string Source_URL { get; set; }

        public Int64 CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
