namespace Labs;

public static class Lab7
{
    public static void Run()
    {
        Console.WriteLine("Оплата картой и наличными");
        CardPayment cardPayment = new();
        CashPayment cashPayment = new();
        cardPayment.Pay(500);
        cashPayment.Pay(300);

        Console.WriteLine();
        Console.WriteLine("Список способов оплаты");
        List<IPayment> payments = new()
        {
            cardPayment,
            cashPayment,
            new CardPayment()
        };
        double[] amounts = { 500, 300, 120 };
        for (int i = 0; i < payments.Count; i++)
        {
            payments[i].Pay(amounts[i]);
        }
    }
}
