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
            SalesManager salesManager = new SalesManager();
            decimal res = salesManager.CalculateAdditionalDiscounts(950);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void TestBase()
        {
            SalesManager salesManager = new SalesManager();
            decimal res = salesManager.CalculateAdditionalDiscounts(200);
            Assert.AreEqual(res, 5);
        }
        [TestMethod]
        public void TestBelow()
        {
            SalesManager salesManager = new SalesManager();
            decimal res = salesManager.CalculateAdditionalDiscounts(195);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void TestMultiple()
        {
            SalesManager salesManager = new SalesManager();
            decimal res = salesManager.CalculateAdditionalDiscounts(400);
            Assert.AreEqual(res, 10);
        }
        [TestMethod]
        public void TestZeroRate()
        {
            SalesManager salesManager = new SalesManager();
            decimal totalAmount = salesManager.CalculateAllDiscounts(0, 12000, 4000, out decimal discountAmount);
            Assert.AreEqual(totalAmount, 15600);
            Assert.AreEqual(discountAmount, 400);
        }

        [TestMethod]
        public void TestNonPercDiscountable()
        {
            SalesManager salesManager = new SalesManager();
            decimal totalAmount = salesManager.CalculateAllDiscounts(0, 0, 4000, out decimal discountAmount);
            Assert.AreEqual(totalAmount, 3900);
            Assert.AreEqual(discountAmount, 100);
        }

        [TestMethod]
        public void TestOnlyPercentageBased()
        {
            SalesManager salesManager = new SalesManager();
            decimal totalAmount = salesManager.CalculateAllDiscounts(0.30m, 100, 0, out decimal discountAmount);
            Assert.AreEqual(totalAmount, 70);
            Assert.AreEqual(discountAmount, 30);
        }

        [TestMethod]
        public void TestAllDiscountable()
        {
            SalesManager salesManager = new SalesManager();
            decimal totalAmount = salesManager.CalculateAllDiscounts(0.30m, 12000, 0, out decimal discountAmount);
            Assert.AreEqual(totalAmount, 8190);
            Assert.AreEqual(discountAmount, 3810);
        }

        [TestMethod]
        public void TestAll()
        {
            SalesManager salesManager = new SalesManager();
            decimal totalAmount = salesManager.CalculateAllDiscounts(0.30m, 12000, 4000, out decimal discountAmount);
            Assert.AreEqual(totalAmount, 12090);
            Assert.AreEqual(discountAmount, 3910);
        }
    }
}
