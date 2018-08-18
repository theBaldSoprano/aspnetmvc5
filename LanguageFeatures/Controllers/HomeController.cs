using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public string Index() {
            return "Navigate to url to show an example";
        }

        public ViewResult AutoProperty() {
            Product product = new Product();
            product.Name = "key";
            string foo = product.Name;
            return View(
                    "Result",
                    (object)String.Format("Prod name: {0}", foo)
                    );
        }
    }
}