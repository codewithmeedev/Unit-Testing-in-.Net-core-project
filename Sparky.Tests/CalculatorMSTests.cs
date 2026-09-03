using System;
using Sparky;
namespace Sparky;

[TestClass]
public class CalculatorMSTests
{
    [TestMethod]
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

    [TestMethod]
    public void IsOddnumberCheck_InputOddNumber_ReturnTrue()
    {
        //Arrange

        Calculator calculator = new();

        bool expected = true;
        //Act

        bool result = calculator.IsOddNumber(5);
        //Assert
        Assert.AreEqual(expected, result);
    }
}
