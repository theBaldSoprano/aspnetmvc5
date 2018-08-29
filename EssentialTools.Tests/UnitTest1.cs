using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;


namespace EssentialTools.Tests {

    [TestClass]
    public class UnitTest1 {

        private IDiscountHelper getTestObject() {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100() {
            var dh = getTestObject();
            decimal total = 140;

            var result = dh.ApplyDiscount(total);

            Assert.AreEqual(total * 0.9M, result);
        }

        [TestMethod]
        public void Discount_Between_10_and_100() {
            var dh = getTestObject();
            decimal min = 10;
            decimal max = 100;
            decimal between = 50;

            var minResult = dh.ApplyDiscount(min);
            var maxResult = dh.ApplyDiscount(max);
            var btwResult = dh.ApplyDiscount(between);

            Assert.AreEqual(min - 5M, minResult);
            Assert.AreEqual(max - 5M, maxResult);
            Assert.AreEqual(between - 5M, btwResult);
        }

        [TestMethod]
        public void Discount_Under_10() {
            var dh = getTestObject();
            decimal total = 5;
            decimal zero = 0;

            var result = dh.ApplyDiscount(total);
            var resultzero = dh.ApplyDiscount(zero);

            Assert.AreEqual(total, result);
            Assert.AreEqual(zero, resultzero );
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_Price() {
            var target = getTestObject();

            target.ApplyDiscount(-333);
        }

    }
}
