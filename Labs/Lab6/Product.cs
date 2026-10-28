namespace Labs;

public class Product
{
    public string Name { get; }

    public double Price { get; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name} — {Price} руб.");
    }
}
