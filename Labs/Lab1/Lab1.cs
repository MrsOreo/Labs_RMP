using System.Globalization;

namespace Labs;

public static class Lab1
{
    public static void Run()
    {
        FillNumbers(out double number1, out double number2, out double number3);

        double sum = GetSum(number1, number2, number3);

        Console.Write("Введите число для умножения суммы: ");
        double multiplier = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double product = GetProduct(sum, multiplier);

        PrintResult("Сумма", sum);
        PrintResult("Произведение", product);
    }

    private static void FillNumbers(out double number1, out double number2, out double number3)
    {
        Console.Write("Введите первое число: ");
        number1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Введите второе число: ");
        number2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.Write("Введите третье число: ");
        number3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
    }

    private static double GetSum(double number1, double number2, double number3)
    {
        return number1 + number2 + number3;
    }

    private static double GetProduct(double sum, double multiplier)
    {
        return sum * multiplier;
    }

    private static void PrintResult(string label, double value)
    {
        string formattedValue = value.ToString("G", CultureInfo.InvariantCulture);
        Console.WriteLine($"{label}: {formattedValue}");
    }
}
