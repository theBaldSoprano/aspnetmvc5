using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models {
    public class Product {
        public string name { get; set; }
        public int productId { get; set; }
        public string discription { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
    }
}