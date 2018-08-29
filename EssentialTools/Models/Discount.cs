using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {
    public interface IDiscountHelper {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper {
        public decimal DiscountSize { get; set; }
        private decimal DiscountSize2;

        public DefaultDiscountHelper(decimal discountSize2) {
            DiscountSize2 = discountSize2;
        }

        public decimal ApplyDiscount(decimal totalParam) {
            return (totalParam - (DiscountSize * DiscountSize2 / 100M * totalParam));
        }
    }
}