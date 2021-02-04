using Calculate_Lektion0_1;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculate uut;
        [SetUp]
        public void Setup()
        {
            // Arange
            uut = new Calculate();
        }

        [Test]
        public void Add_Add3And6_EqualTo9()
        {
            //Act 
            double result = uut.Add(3, 6);

            //Assert
            Assert.That(result,Is.EqualTo(9));
        }

        [Test]
        public void Subtract_Subtract8And3_EqualTo5()
        {
            //Act 
            double result = uut.Subtract(8, 3);

            //Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Multiply_Multiply3And3_EqualTo9()
        {
            //Act 
            double result = uut.Multiply(3, 3);

            //Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void Power_Power2And3_EqualTo8()
        {
            //Act 
            double result = uut.Power(2, 3);

            //Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [TestCase(3,6,9)]
        [TestCase(5, 6, 11)]
        [TestCase(4, 9, 13)]
        public void Add_AddaAndb_EqualToExpected(double a, double b, double expected)
        {
            //Act 
            double result = uut.Add(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(7,6,1)]
        [TestCase(20, 6, 14)]
        [TestCase(4, 9, -5)]
        public void Subtract_subtractaAndb_equaToExpected(double a, double b, double expected)
        {
            //Act 
            double result = uut.Subtract(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}