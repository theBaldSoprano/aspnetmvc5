using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models {
    public static class MyExtensionMethods {
        public static decimal totalPrices(this IEnumerable<Product> cart) {
            decimal total = 0;
            foreach(Product p in cart) {
                total += p.price;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> prodEnum, string catPar) {
            foreach(Product p in prodEnum) {
                if(p.category == catPar) {
                    yield return p;
                }
            }
        }

        public static IEnumerable<Product> Filter(
            this IEnumerable<Product> productEnum, Func<Product, bool> selector) {
            foreach(Product p in productEnum) {
                if (selector(p)) {
                    yield return p;
                }
            }
        }
    }
}