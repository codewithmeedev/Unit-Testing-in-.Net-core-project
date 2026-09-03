using System;
using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CalculatorNUnitTests
{
    [Test]
    public void AddNumbers_InputTwoIntgers_ReturnSum()
    {
        //Arrange
        Calculator calc = new();
        int expected = 60;

        //Act
        int result = calc.AddNumbers(20,40);

        //Assert
        Assert.AreEqual(expected,result);
    }

    [Test]
    public void IsOddnumberCheck_InputOddNumber_ReturnTrue()
    {
        //Arrange

        Calculator calculator = new();

        //bool expected = true;
        //Act

        bool result = calculator.IsOddNumber(5);
        //Assert
        //Assert.IsTrue(result);

        Assert.That(result,Is.True);
    }

    [Test]
    [TestCase(10, ExpectedResult = false)]
    [TestCase(11, ExpectedResult = true)]
    public bool IsOddnumberCheck_InputNumber_ReturnTrueOrFalse(int a)
    {
        Calculator calc = new();

        return calc.IsOddNumber(a);
    }
}