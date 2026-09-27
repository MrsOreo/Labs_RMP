using System.Globalization;

namespace Labs;

public static class Lab2
{
    public static void Run()
    {
        Console.WriteLine("Перегрузка 1: два целых числа");
        Console.Write("Введите первое целое число: ");
        int intNumber1 = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Введите второе целое число: ");
        int intNumber2 = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        PrintResult("Сумма", GetSum(intNumber1, intNumber2));

        Console.WriteLine();
        Console.WriteLine("Перегрузка 2: три целых числа");
        Console.Write("Введите третье целое число: ");
        int intNumber3 = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        PrintResult("Сумма", GetSum(intNumber1, intNumber2, intNumber3));

        Console.WriteLine();
        Console.WriteLine("Перегрузка 3: два целых числа и одно double");
        Console.Write("Введите double число: ");
        double doubleNumber = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        PrintResult("Сумма", GetSum(intNumber1, intNumber2, doubleNumber));

        Console.WriteLine();
        Console.WriteLine("Перегрузка 4: два double");
        Console.Write("Введите первое double число: ");
        double doubleNumber1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Введите второе double число: ");
        double doubleNumber2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        PrintResult("Сумма", GetSum(doubleNumber1, doubleNumber2));

        Console.WriteLine();
        Console.WriteLine("Перегрузка 5: две строки");
        Console.Write("Введите первую строку: ");
        string string1 = Console.ReadLine()!;
        Console.Write("Введите вторую строку: ");
        string string2 = Console.ReadLine()!;
        PrintResult("Сумма", GetSum(string1, string2));
    }

    private static int GetSum(int number1, int number2)
    {
        return number1 + number2;
    }

    private static int GetSum(int number1, int number2, int number3)
    {
        return number1 + number2 + number3;
    }

    private static double GetSum(int number1, int number2, double number3)
    {
        return number1 + number2 + number3;
    }

    private static double GetSum(double number1, double number2)
    {
        return number1 + number2;
    }

    private static string GetSum(string string1, string string2)
    {
        return string1 + string2;
    }

    private static void PrintResult(string label, object value)
    {
        Console.WriteLine($"{label}: {value}");
    }
}
