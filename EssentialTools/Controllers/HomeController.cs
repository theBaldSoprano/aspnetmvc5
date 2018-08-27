﻿using EssentialTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace EssentialTools.Controllers {

    public class HomeController : Controller {

        private IValueCalculator calc;
        private Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

        public HomeController(IValueCalculator calc, IValueCalculator calc2) {
            this.calc = calc;
        }

        // GET: Home
        public ActionResult Index() {

            ShoppingCart sc = new ShoppingCart(calc) {
                products = products
};

            decimal? d = sc.CalculateProductTotal();

            return View(d == null ? 0M : d);
        }
    }
}