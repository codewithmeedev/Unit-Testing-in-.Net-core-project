using System;
using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CalculatorNUnitTests
{
    private Calculator calculator;

    [SetUp]
    public void SetUp()
    {
        calculator = new Calculator();
    }
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

    [Test]
    public void GetEvenRange_InputMinAndMaxRange_ReturnEvenNumberRange()
    {
        //Calculator calc = new();

        List<int> expectedRange = new() {4,6,8};

        List<int> result = calculator.GetEvenRange(4,8);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EquivalentTo(expectedRange));
            Assert.That(result, Does.Contain(6));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
            Assert.That(result, Is.Not.Empty);
            Assert.AreEqual(expectedRange, result);
            Assert.Contains(6, result);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(5));
        });
    }
}