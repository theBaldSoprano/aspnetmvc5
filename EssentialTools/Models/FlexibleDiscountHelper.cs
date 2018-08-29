﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models {
    public class FlexibleDiscountHelper : IDiscountHelper {
        public decimal ApplyDiscount(decimal totalParam) {
            decimal discount = totalParam > 100 ? 25 : 10;
            return (totalParam - (discount * 100 / totalParam));
        }
    }
}