namespace Labs;

public class Cart
{
    public List<Product> Products { get; } = new();

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public void ShowProducts()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("Корзина пуста.");
            return;
        }

        Console.WriteLine("Товары в корзине:");
        foreach (Product product in Products)
        {
            Console.WriteLine($"  {product.Name} — {product.Price} руб.");
        }
    }

    public double GetTotal()
    {
        double total = 0;
        foreach (Product product in Products)
        {
            total += product.Price;
        }

        return total;
    }
}
