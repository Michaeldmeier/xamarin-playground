using Microsoft.VisualStudio.TestTools.UnitTesting;
using XamarinPlayground.calculator;

namespace XamarinPlayground.Test
{

    [TestClass]
    public class OperationTests
    {
        ICalculator calc;

        public OperationTests() {
            this.calc = new Calculator();
        }

        [TestMethod]
        public void TestSumOfTwoNumbers()
        {
            double n1 = 12;
            double n2 = 567;
            Assert.AreEqual(579, calc.Sum(n1, n2));
        }

        [TestMethod]
        public void TestSumOfMultipleNumbers()
        {
            double[] numbers = { 12, 34, 23 };
            Assert.AreEqual(69, calc.Sum(numbers));
        }

    }
}
