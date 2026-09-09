using System;
using NUnit.Framework;

namespace Sparky;
[TestFixture]
public class GradingCalcultorNUnitTests
{
    private GradingCalculator gradingCalculator;
    [SetUp]
    public void SetUp()
    {
        gradingCalculator = new GradingCalculator();
    }

    [Test]
    public void GradingCalculator_InputScoreAndAttendance_ReturnsGradeA()
    {
        gradingCalculator.Score = 95;
        gradingCalculator.AttendancePercentage = 80;
        string result = gradingCalculator.GradeCalculator();
        Assert.That(result, Is.EqualTo("A"));
    }
    [Test]
    public void GradingCalculator_InputScoreAndAttendance_ReturnsGradeB()
    {
        gradingCalculator.Score = 81;
        gradingCalculator.AttendancePercentage = 90;
        string result = gradingCalculator.GradeCalculator();
        Assert.That(result, Is.EqualTo("B"));
    }
    [Test]
    public void GradingCalculator_InputScoreAndAttendance_ReturnsGradeC()
    {
        gradingCalculator.Score = 65;
        gradingCalculator.AttendancePercentage = 90;
        string result = gradingCalculator.GradeCalculator();
        Assert.That(result, Is.EqualTo("C"));
    }

    [Test]
    [TestCase(95,55)]
    [TestCase(65,55)]
    [TestCase(55,90)]
    public void GradingCalculator_FailedScenarios_ReturnsGradeF( int score, int attendance)
    {
        gradingCalculator.Score = score;
        gradingCalculator.AttendancePercentage = attendance;
        string result = gradingCalculator.GradeCalculator();
        Assert.That(result, Is.EqualTo("F"));
    }

    [Test]
    [TestCase(95,90,ExpectedResult = "A")]
    [TestCase(85,90,ExpectedResult = "B")]
    [TestCase(65,90,ExpectedResult = "C")]
    [TestCase(95,65,ExpectedResult = "B")]
    [TestCase(65,55,ExpectedResult = "F")]
    [TestCase(55,90,ExpectedResult = "F")]
    public string GradingCalculator_AllGradLogicalScenarios_ReturnsGradeOutput( int score, int attendance)
    {
        gradingCalculator.Score = score;
        gradingCalculator.AttendancePercentage = attendance;
        return gradingCalculator.GradeCalculator();
    }
}
