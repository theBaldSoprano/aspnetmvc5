using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ViewResult Index() {
            return View("Home");
        }

        public ViewResult AutoProperty() {
            Product product = new Product();
            product.name = "key";
            string foo = product.name;
            return View(
                    "Result",
                    (object)String.Format("Prod name: {0}", foo)
                    );
        }

        public ViewResult UseExtension() {
            ShoppingCart cart = new ShoppingCart {
                products = new List<Product> {
                    new Product {name = "Kayak", price = 275M},
                    new Product {name = "Lifejacket", price = 48.95M},
                    new Product {name = "Soccer ball", price = 19.50M},
                    new Product {name = "Corner flag", price = 34.95M}
                    }
            };
            decimal total = cart.totalPrices();
            return View("Result",
                        (object)String.Format("Total: {0:c}", total));
        }

        public ViewResult UseExtensionEnumerable() {
            IEnumerable<Product> products = new ShoppingCart {
                products = new List<Product> {
                    new Product {name = "Kayak", price = 275M},
                    new Product {name = "Lifejacket", price = 48.95M},
                    new Product {name = "Soccer ball", price = 19.50M},
                    new Product {name = "Corner flag", price = 34.95M}
                }
            };
            // create and populate an array of Product objects
            Product[] productArray = {
                new Product {name = "Kayak", price = 275M},
                new Product {name = "Lifejacket", price = 48.95M},
                new Product {name = "Soccer ball", price = 19.50M},
                new Product {name = "Corner flag", price = 34.95M}
            };
            decimal foo = products.totalPrices();
            decimal bar = productArray.totalPrices();

            return View("Result",
                (object)String.Format("cart total: {0}, array total: {1}", foo, bar));
        }

        public ViewResult UseFilterExtensionMethod() {
            IEnumerable<Product> products = new ShoppingCart {
                products = new List<Product> {
                    new Product {name = "Kayak", price = 275M},
                    new Product {name = "Lifejacket", price = 48.95M, category = "Soccer"},
                    new Product {name = "Soccer ball", price = 19.50M},
                    new Product {name = "Corner flag", price = 34.95M}
                }
            };
            decimal foo = 0;
            foreach (Product p in products.FilterByCategory("Soccer")) {
                foo += p.price;
            }
            return View("Result",
                (object)String.Format("cart total: {0}", foo));
        }

        public ViewResult UseFilterMethod() {
            IEnumerable<Product> products = new ShoppingCart {
                products = new List<Product> {
                    new Product {name = "Kayak", price = 275M},
                    new Product {name = "Lifejacket", price = 48.95M, category = "Soccer"},
                    new Product {name = "Soccer ball", price = 19.50M},
                    new Product {name = "Corner flag", price = 34.95M}
                }
            };

            var temp = new {
                name = "foo",
                bar = "name"
            };

            decimal foo = 0;
            foreach (Product p in products.Filter(x => (x.category ?? "").ToUpper().StartsWith("S"))) {
                foo += p.price;
            }
            return View("Result",
                (object)$"total price of filtered: {foo}");
        }

        public ViewResult CreateAnonArray() {
            var foo = new[] {
                new {name = "apple"},
                new {name = "hat"},
                new {name = "pool]]"}
            };
            StringBuilder sb = new StringBuilder();
            foreach(var i in foo) {
                sb.Append(i.name).Append(" ");
            }
            return View("Result", (object)sb.ToString());
        }
    }
}