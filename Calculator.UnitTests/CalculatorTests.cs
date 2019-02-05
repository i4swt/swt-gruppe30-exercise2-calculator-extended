using NUnit.Framework;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _uut;
        [SetUp]
        public void SetUp()
        {
            _uut = new Calculator();
        }


        //One way to use [TestCase]
        [Test]
        [TestCase(1,1, ExpectedResult = 2)]
        [TestCase(-1,3, ExpectedResult = 2)]
        [TestCase(-100.1,300, ExpectedResult = 199.9)]
        [TestCase(0,0, ExpectedResult = 0)]
        [TestCase(-1,-1, ExpectedResult = -2)]
        public double Add_WhenCalled_ReturnsTheSumOfTheTwoInputs(double a, double b)
        {
            return _uut.Add(a, b);
        }

        [Test]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(-1,  ExpectedResult = -1)]
        [TestCase(-5, ExpectedResult = -5)]
        public double Add_OverloadedSoAccumulatorReturnsSameAsAddInput_AccumulatorReturnsResult(double a)
        {
        
            _uut.Add(a);
            return _uut.Accumulator;
        }

        [Test]
        [TestCase(1, ExpectedResult = 2)]
        [TestCase(2, ExpectedResult = 4)]
        [TestCase(-5, ExpectedResult = -10)]
        public double Add_AddsInputTwiceToTestAccumulation_ReturnsAccumulatedSum(double a)
        {
            _uut.Add(a);
            _uut.Add(a);
            return _uut.Accumulator;
        }



        //Another way of using [TestCase]
        [Test]
        [TestCase(1,2,-1)]
        [TestCase(2,2,0)]
        [TestCase(0.5,-0.5,1)]
        [TestCase(-1,-1,0)]
        [TestCase(-2,1,-3)]
        public void Subtract_WhenCalled_ReturnsBSubtractedFromA(double a, double b, double expectedResult)
        {
            var result = _uut.Subtract(a, b);
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
            return _uut.Power(x, exp);
        }

        //A much more time consuming way of testing the Multiply method
        [Test]
        public void Multiply_TwoPositiveInputs_ReturnsAPositiveNumber()
        {
            var result = _uut.Multiply(2, 2);
            Assert.That(result,Is.EqualTo(4));
        }

        [Test]
        public void Multiply_OnePositiveAndOneNegativeInput_ReturnsANegativeNumber()
        {
            var result = _uut.Multiply(-2, 2);
            Assert.That(result, Is.EqualTo(-4));
        }

        [Test]
        public void Multiply_TwoNegativeInputs_ReturnsAPositiveNumber()
        {
            var result = _uut.Multiply(-2, -2);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Multiply_OneInputEqualsZero_ReturnsZero()
        {
            var result = _uut.Multiply(0, 2);
            Assert.That(result,Is.EqualTo(0));
        }

        [Test]
        [TestCase(1, ExpectedResult = -1)]
        public double Subtract_WhenCalledWithOneInput_StoresResultInAccumulator(double a)
        {
            _uut.Subtract(a);
            return _uut.Accumulator;
        }

        [Test]
        [TestCase(1, ExpectedResult = -3)]
        [TestCase(3, ExpectedResult = -9)]
        public double Subtract_WhenCalledWithOneInputRepeatedly_StoresResultInAccumulator(double a)
        {
            _uut.Subtract(a);
            _uut.Subtract(a);
            _uut.Subtract(a);
            return _uut.Accumulator;
        }

        [Test]
        [TestCase(5, 2, ExpectedResult = 0)]
        [TestCase(-10, 2, ExpectedResult = 0)]
        [TestCase(-15, -6, ExpectedResult = 0)]
        public double Clear_CalledOnMultipleCalculations_AccumulatorIsZero(double a, double b)
        {
            _uut.Subtract(a);
            _uut.Add(b);
            _uut.Clear();
            return _uut.Accumulator;
        }

    }
}