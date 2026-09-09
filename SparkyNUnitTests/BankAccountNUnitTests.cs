using System;
using NUnit.Framework;
namespace Sparky;

[TestFixture]
public class BankAccountNUnitTests
{
    private BankAccount bankAccount;
    [SetUp]
    public void SetUp()
    {
        bankAccount = new(new LogBook());
    }

    [Test]
    public void BankDeposit_Added100_ReturnsTrue()
    {
        var result = bankAccount.Deposit(100);
        Assert.IsTrue(result);
        Assert.That(bankAccount.GetBalance, Is.EqualTo(100));
    }
}
