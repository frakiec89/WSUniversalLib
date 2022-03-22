using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest_4t_4m_Minus1()
        {
            Calculation calculation = new Calculation();

            int productType = 4;
            int materialType = 4;
            var expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, 1, 1 , 1);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetQuantityForProductTest_1t_4m_Minus1()
        {
            Calculation calculation = new Calculation();

            int productType = 1;
            int materialType = 4;
            var expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, 1, 1, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_4t_1m_Minus1()
        {
            Calculation calculation = new Calculation();

            int productType = 4;
            int materialType = 1;
            var expected = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, 1, 1, 1);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetQuantityForProductTest_1t_1m_1()
        {
            Calculation calculation = new Calculation();

            int productType = 1;
            int materialType = 1;
            var expected = 3;
            var actual = calculation.GetQuantityForProduct(productType, materialType, 1, 1, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_W_mins1_minus1()
        {
            Calculation calculation = new Calculation();

            int productType = 1;
            int materialType = 1;
            var expected = -1;
            var w = -1;
            var actual = calculation.GetQuantityForProduct(productType, materialType, 1, w, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_114148()
        {
            Calculation calculation = new Calculation();
            int count = 15;
            int productType = 3;
            int materialType = 1;
            var w = 20;
            var l = 45;
            var expected = 114148;


            //8.43
            //113805
            //342
            var actual = calculation.GetQuantityForProduct(productType, materialType, count, w, l);
            Assert.AreEqual(expected, actual);
        }


    }
}