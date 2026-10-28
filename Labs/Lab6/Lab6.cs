namespace Labs;

public static class Lab6
{
    public static void Run()
    {
        ConsoleOutput output = new();

        Console.WriteLine("Задание 1 — товар и корзина");
        Product bread = new("Хлеб", 50);
        Product milk = new("Молоко", 90);
        bread.ShowInfo();
        milk.ShowInfo();

        Cart cart = new();
        cart.Add(bread);
        cart.Add(milk);
        cart.ShowProducts();
        Console.WriteLine($"Итоговая стоимость: {cart.GetTotal()} руб.");

        Console.WriteLine();
        Console.WriteLine("Задание 2 — наследование");
        Dog dog = new("Шарик");
        Cat cat = new("Мурка");
        dog.MakeSound();
        cat.MakeSound();
        Console.WriteLine($"Имя собаки: {dog.Name}");
        Console.WriteLine($"Имя кошки: {cat.Name}");

        Console.WriteLine();
        Console.WriteLine("Доп. 1 — класс с обычным Main");
        Console.WriteLine("Точка входа: Lab6App.Main");

        Console.WriteLine();
        Console.WriteLine("Доп. 2 — перегрузка статического метода Sum");
        output.PrintResult("float", Lab6Sum.Sum(1.5f, 2.25f));
        output.PrintResult("int", Lab6Sum.Sum(3, 4));
        output.PrintResult("double", Lab6Sum.Sum(1.5, 2.25));
        output.PrintResult("string", Lab6Sum.Sum("Хлеб", " и Молоко"));

        Console.WriteLine();
        Console.WriteLine("Доп. 3 — нестатический метод заполняет массив");
        ArrayFiller filler = new();
        int[] numbers = filler.Fill(8);
        output.PrintArray(numbers);

        Console.WriteLine();
        Console.WriteLine("Доп. 4 — минимальный элемент и его индекс");
        MinFinder finder = new();
        int minValue = finder.FindMin(numbers, out int minIndex);
        output.PrintResult("Минимальный элемент", minValue);
        output.PrintResult("Его индекс", minIndex);

        Console.WriteLine();
        Console.WriteLine("Доп. 5 — класс вывода");
        output.PrintTitle("Проверка вывода");
        output.PrintArray(numbers);
        int total = 0;
        foreach (int value in numbers)
        {
            total += value;
        }
        output.PrintResult("Сумма элементов", total);
    }
}
