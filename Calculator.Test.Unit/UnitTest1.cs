using System;
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
            // Arrange
            uut = new Calculate();
            uut.Accumulator = 2;
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
        public void Add_AddAccumulatorAnd5_EqualTo7()
        {
            //Act
            double result = uut.Add(5);

            //Assert
            Assert.That(result, Is.EqualTo(7));
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
        public void Subtract_SubtractAccumulatorAnd1_EqualTo1()
        {
            //Act 
            double result = uut.Subtract(1);

            //Assert
            Assert.That(result, Is.EqualTo(1));
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
        public void Multiply_MultiplyAccumulatorAnd3_EqualTo6()
        {
            //Act 
            double result = uut.Multiply(3);

            //Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Power_Power2And3_EqualTo8()
        {
            //Act 
            double result = uut.Power(2, 3);

            //Assert
            Assert.That(result, Is.EqualTo(8));
        }


        [Test]
        public void Power_PowerAccumulatorAnd3_EqualTo8()
        {
            //Act 
            double result = uut.Power(3);

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

        [TestCase(10, 5, 2)]
        [TestCase(20, 4, 5)]
        [TestCase(30, 3, 10)]
        public void divide_divideaAndb_equaToExpected(double a, double b, double expected)
        {
            //Act 
            double result = uut.Divide(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 8)]
        [TestCase(2, 4, 16)]
        public void power_poweraAndb_equaToExpected(double a, double b, double expected)
        {
            //Act 
            double result = uut.Power(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void divide_dividebynot0_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => uut.Divide(300, 12));
        }

        [Test]
        public void divide_divideby0_Throws()
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide(400, 0));
        }


        [Test]
        public void divide_divideAccumulatorbynot0_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => uut.Divide( 2));
        }

        [Test]
        public void divide_divideAccumulatorby0_Throws()
        {
            Assert.Throws<DivideByZeroException>(() => uut.Divide( 0));
        }
    }
}