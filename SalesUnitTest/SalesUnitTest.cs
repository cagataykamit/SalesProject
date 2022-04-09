using Business.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesUnitTest
{
    [TestClass]
    public class SalesUnitTest
    {
        [TestMethod]
        public void TestMultipleAndAdditional()
        {
            decimal res = SalesManager.CalculateAdditionalDiscounts(950);
            Assert.AreEqual(20, res);
        }
        [TestMethod]
        public void TestBase()
        {
            decimal res = SalesManager.CalculateAdditionalDiscounts(200);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void TestBelow()
        {
            decimal res = SalesManager.CalculateAdditionalDiscounts(195);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMultiple()
        {
            decimal res = SalesManager.CalculateAdditionalDiscounts(400);
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void TestZeroRate()
        {
            decimal totalAmount = SalesManager.CalculateAllDiscounts(0, 12000, 4000, out decimal discountAmount);
            Assert.AreEqual(15600, totalAmount);
            Assert.AreEqual(400, discountAmount);
        }

        [TestMethod]
        public void TestNonPercDiscountable()
        {
            decimal totalAmount = SalesManager.CalculateAllDiscounts(0, 0, 4000, out decimal discountAmount);
            Assert.AreEqual(3900, totalAmount);
            Assert.AreEqual(100, discountAmount);
        }

        [TestMethod]
        public void TestOnlyPercentageBased()
        {
            decimal totalAmount = SalesManager.CalculateAllDiscounts(0.30m, 100, 0, out decimal discountAmount);
            Assert.AreEqual(70, totalAmount);
            Assert.AreEqual(30, discountAmount);
        }

        [TestMethod]
        public void TestAllDiscountable()
        {
            decimal totalAmount = SalesManager.CalculateAllDiscounts(0.30m, 12000, 0, out decimal discountAmount);
            Assert.AreEqual(8190, totalAmount);
            Assert.AreEqual(3810, discountAmount);
        }

        [TestMethod]
        public void TestAll()
        {
            decimal totalAmount = SalesManager.CalculateAllDiscounts(0.30m, 12000, 4000, out decimal discountAmount);
            Assert.AreEqual(12090, totalAmount);
            Assert.AreEqual(3910, discountAmount);
        }

        [TestMethod]
        public void TestSales()
        {
            int res = SalesManager.DoSale();
            Assert.AreEqual(0, res);
        }
    }
}
