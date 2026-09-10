using System;
using NUnit.Framework;
using Moq;
namespace Sparky;

[TestFixture]
public class BankAccountNUnitTests
{
    private BankAccount account;
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void BankDepositFakeLogger_Added100_ReturnsTrue()
    {
        BankAccount bankAccount = new(new LogBookFake());
        var result = bankAccount.Deposit(100);
        Assert.IsTrue(result);
        Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
    }

    [Test]
    public void BankDepositMoq_Added100_ReturnsTrue()
    {
        var logMoq = new Mock<ILogBook>();
        logMoq.Setup(x=> x.Message(""));
        BankAccount bankAccount = new(logMoq.Object);
        var result = bankAccount.Deposit(100);
        Assert.IsTrue(result);
        Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
    }
}
