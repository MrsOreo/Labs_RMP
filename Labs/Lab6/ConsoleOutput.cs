namespace Labs;

public class ConsoleOutput
{
    public void PrintTitle(string title)
    {
        Console.WriteLine();
        Console.WriteLine(title);
        Console.WriteLine(new string('-', title.Length));
    }

    public void PrintArray(int[] array)
    {
        Console.WriteLine("Массив: " + string.Join(", ", array));
    }

    public void PrintResult(string label, object value)
    {
        Console.WriteLine($"{label}: {value}");
    }
}
