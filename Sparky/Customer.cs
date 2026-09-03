using System;

namespace Sparky;

public class Customer
{
    public int Discount = 25;
    public string GreetMessage { get; set; }
    public string GreetAndCombineNames(string firstName, string lastName)
    {
        GreetMessage = $"Hii, {firstName} {lastName}";
        Discount = 20;
        return GreetMessage;
    }
}
