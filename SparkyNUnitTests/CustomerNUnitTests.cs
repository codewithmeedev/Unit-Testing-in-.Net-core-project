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

    [Test]
    public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
    {
        int result = customer.Discount;
        Assert.That(result, Is.InRange(10,25));
    }

    [Test]
    public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
    {
        customer.GreetAndCombineNames("Dev","");
        Assert.IsNotNull(customer.GreetMessage);
        Assert.IsFalse(string.IsNullOrEmpty(customer.GreetMessage));
    }

    [Test]
    public void GreetMessage_EmptyFirstName_ThrowsException()
    {
        //Exception With Error Message
        var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("","Solanki"));
        Assert.AreEqual("Empty First Name", exceptionDetails.Message);

        Assert.That(() => customer.GreetAndCombineNames("","Solanki"),
            Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));

        //Exception With Error Message
        Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("","Solanki"));

        Assert.That(() => customer.GreetAndCombineNames("","Solanki"),
            Throws.ArgumentException);
    }

    [Test]
    public void CustomerType_CreateCustomerWithLessThan100OrderTotal_ReturnsBasicCustomer()
    {
        customer.OrderTotal = 50;
        var result = customer.GetCustomerDetails();
        Assert.That(result, Is.TypeOf<BasicCustomer>());
    }

    [Test]
    public void CustomerType_CreateCustomerWithMoreThan100OrderTotal_ReturnsPlatinumCustomer()
    {
        customer.OrderTotal = 150;
        var result = customer.GetCustomerDetails();
        Assert.That(result, Is.TypeOf<PlatinumCustomer>());
    }
}
