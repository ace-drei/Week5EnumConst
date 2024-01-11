using System;
using System.Security;

namespace MoneyMan;
public enum Currency
{
    Dollar,
    Euro,
    Yen
}

public struct Money
{
    private const double EuroToDollarRate = 1.18;
    private const double DollarToEuroRate = 1 / EuroToDollarRate;
    private const double EuroToYenRate = 130.50;
    private const double DollarToYenRate = 110.30;
    private const double YenToEuroRate = 1 / EuroToYenRate;
    private const double YenToDollarRate = 1 / DollarToYenRate;

    public double Amount { get; set; }
    public Currency Currency { get; set; }

    public Money(double amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public Money Exchange(Currency currency)
    {

        if (currency == Currency)
        {
            throw new ArgumentException("You cannot convert to the same currency");
        }

        switch (Currency)
        {
            case Currency.Euro:
                Amount = currency == Currency.Dollar ? Amount * EuroToDollarRate : Amount * EuroToYenRate;
                break;
            case Currency.Dollar:
                Amount = currency == Currency.Euro ? Amount * DollarToEuroRate : Amount * DollarToYenRate;
                break;
            case Currency.Yen:
                Amount = currency == Currency.Euro ? Amount * YenToEuroRate : Amount * YenToDollarRate;
                break;

        }



        return new Money(Amount, currency);
    }

    public Money AddMoney(Money m2)
    {

        Money otherConverted = m2.Exchange(this.Currency);
        return new Money(this.Amount + otherConverted.Amount, this.Currency);


    }

}

class Test
{
    public static void Main()
    {
        Money money1 = new Money(100, Currency.Euro);
        Money money2 = new Money(100, Currency.Dollar);

        Money sum = money1.AddMoney(money2);
        Console.WriteLine($"{sum.Amount} {sum.Currency}");
    }

}