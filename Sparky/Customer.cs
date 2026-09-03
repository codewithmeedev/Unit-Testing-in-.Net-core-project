using System;

namespace Sparky;

public class Customer
{
    public string GreetMessage { get; set; }
    public string GreetAndCombineNames(string firstName, string lastName)
    {
        GreetMessage = $"Hii, {firstName} {lastName}";
        return GreetMessage;
    }
}
