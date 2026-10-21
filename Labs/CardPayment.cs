namespace Labs;

public class CardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Оплачено картой: {amount}");
    }
}
