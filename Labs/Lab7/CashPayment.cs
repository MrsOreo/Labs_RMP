namespace Labs;

public class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Оплачено наличными: {amount}");
    }
}
