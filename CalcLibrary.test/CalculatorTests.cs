using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalcLibrary.test
{
    [TestFixture]
    class CalculatorTests
    {
        SimpleCalculator calculator = null;

        [SetUp]
        public void setUp()
        {
            calculator = new SimpleCalculator();
        }

        [TestCase(10, 20, ExpectedResult = 30)]
        public double TestAddition(double a, double b)
        {
            return calculator.Addition(a, b);
        }
        [TestCase(100, 50, ExpectedResult = 50)]
        public double TestSubtraction(double a, double b)
        {
            return calculator.Subtraction(a, b);
        }
        [TestCase(25, 100, ExpectedResult = 2500)]
        public double TestMultiplication(double a, double b)
        {
            return calculator.Multiplication(a, b);
        }
        [TestCase(500, 100, ExpectedResult = 5)]
        public double TestDivision(double a, double b)
        {
            return calculator.Division(a, b);
        }

        [TearDown]
        public void cleanUp()
        {
            calculator = null;
        }
    }
}