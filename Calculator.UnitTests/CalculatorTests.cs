using NUnit.Framework;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        //One way to use [TestCase]
        [Test]
        [TestCase(1,3, ExpectedResult = 4)]
        [TestCase(-1,3, ExpectedResult = 2)]
        [TestCase(-100.1,300, ExpectedResult = 199.9)]
        [TestCase(0,0, ExpectedResult = 0)]
        public double Add_WhenCalled_ReturnsTheSumOfTheTwoInputs(double a, double b)
        {
            return Calculator.Add(a, b);
        }

        //Another way of using [TestCase]
        [Test]
        [TestCase(1,2,-1)]
        [TestCase(2,2,0)]
        [TestCase(0.5,-0.5,1)]
        [TestCase(-1,-1,0)]
        [TestCase(-2,1,-3)]
        public void Substract_WhenCalled_ReturnsBSubstractedFromA(double a, double b, double expectedResult)
        {
            var result = Calculator.Substract(a, b);
            Assert.That(result,Is.EqualTo(expectedResult));
        }

        //And i use my preferred method again
        [Test]
        [TestCase(0,2,ExpectedResult = 0)]
        [TestCase(1,10,ExpectedResult = 1)]
        [TestCase(-1,3,ExpectedResult = -1)]
        [TestCase(-1,2,ExpectedResult = 1)]
        [TestCase(10,1,ExpectedResult = 10)]
        [TestCase(2,4,ExpectedResult = 16)]
        public double Power_WhenCalled_ReturnsXRaisedToThePowerOfExp(double x, double exp)
        {
            return Calculator.Power(x, exp);
        }

        //A much more time consuming way of testing the Multiply method
        [Test]
        public void Multiply_TwoPositiveInputs_ReturnsAPositiveNumber()
        {
            var result = Calculator.Multiply(2, 2);
            Assert.That(result,Is.EqualTo(4));
        }

        [Test]
        public void Multiply_OnePositiveAndOneNegativeInput_ReturnsANegativeNumber()
        {
            var result = Calculator.Multiply(-2, 2);
            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void Multiply_TwoNegativeInputs_ReturnsAPositiveNumber()
        {
            var result = Calculator.Multiply(-2, -2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Multiply_OneInputEqualsZero_ReturnsZero()
        {
            var result = Calculator.Multiply(0, 2);
            Assert.That(result,Is.EqualTo(0));
        }
    }
}