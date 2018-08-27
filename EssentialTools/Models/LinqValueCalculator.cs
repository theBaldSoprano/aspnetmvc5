using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {
    public class LinqValueCalculator : IValueCalculator {
        private IDiscountHelper discounter;

        public LinqValueCalculator(IDiscountHelper dishelper) {
            this.discounter = dishelper;
        }

        public decimal ValueProducts(IEnumerable<Product> products) {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}