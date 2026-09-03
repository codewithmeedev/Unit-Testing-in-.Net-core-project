using System;
using Sparky;
namespace Sparky;

[TestClass]
public class CalculatorMSTests
{
    private Calculator calculator;
    [TestInitialize]
    public void SetUp()
    {
        calculator = new Calculator();
    }
    [TestMethod]
    public void AddNumbers_InputTwoIntgers_ReturnSum()
    {
        //Arrange
        //Calculator calc = new();
        int expected = 60;

        //Act
        int result = calculator.AddNumbers(20,40);

        //Assert
        Assert.AreEqual(expected,result);
    }

    [TestMethod]
    public void IsOddnumberCheck_InputOddNumber_ReturnTrue()
    {
        //Arrange

        //Calculator calculator = new();

        bool expected = true;
        //Act

        bool result = calculator.IsOddNumber(5);
        //Assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
     public void GetEvenRange_InputMinAndMaxRange_ReturnEvenNumberRange()
    {
        //Calculator calculator = new();

        List<int> expectedRange = new() {2,4,6,8};    

        List<int>  result = calculator.GetEvenRange(2,8);       
        CollectionAssert.AreEquivalent(expectedRange,result);
    }
}
