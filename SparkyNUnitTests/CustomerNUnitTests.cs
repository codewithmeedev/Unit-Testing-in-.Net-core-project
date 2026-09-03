using System;
using NUnit.Framework;
namespace Sparky;
[TestFixture]
public class CustomersNUnitTests
{
    private Customer customer;

    [SetUp]
    public void SetUp()
    {
        customer = new Customer();
    }
    [Test]
    public void GreetAndCombineNames_InputFirstAndLastName_ReturnFullName()
    {
        //Customer customer = new Customer();

        string fullName = customer.GreetAndCombineNames("Dev", "Solanki");

        Assert.That(fullName, Is.EqualTo("Hii, Dev Solanki"));
    }
    [Test]
    public void GreetMessage_NotGreeted_ReturnNull()
    {
        //Customer customer = new Customer();

        //customer.GreetAndCombineNames("Dev", "Solanki");

        Assert.That(customer.GreetMessage, Is.Null);
    }
}
