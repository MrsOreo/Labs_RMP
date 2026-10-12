namespace Labs;

public static class Lab3
{
    public static void Run()
    {
        Console.WriteLine("for — таблица умножения");
        int number = ReadInt("Введите число: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} × {i} = {number * i}");
        }

        Console.WriteLine();
        Console.WriteLine("while — обратный отсчёт");
        int countdown = ReadInt("Введите число: ", 1);
        while (countdown >= 1)
        {
            Console.Write(countdown + " ");
            countdown--;
        }
        Console.WriteLine("Старт!");

        Console.WriteLine();
        Console.WriteLine("do...while — ответ «да» или «нет»");
        string? answer = null;
        do
        {
            Console.Write("Продолжить? Введите да или нет: ");
            string? input = Console.ReadLine();
            if (input is null)
            {
                break;
            }
            answer = input.Trim().ToLower();
        }
        while (answer != "да" && answer != "нет");
        if (answer is not null)
        {
            Console.WriteLine("Ответ принят: " + answer);
        }

        Console.WriteLine();
        Console.WriteLine("foreach — числа больше 10");
        int countNumbers = ReadInt("Сколько чисел в массиве: ", 1);
        int[] numbers = new int[countNumbers];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ReadInt($"Элемент [{i}]: ");
        }

        int count = 0;
        foreach (int value in numbers)
        {
            if (value > 10)
            {
                count++;
            }
        }
        Console.WriteLine($"Чисел больше 10: {count}");
    }

    private static int ReadInt(string prompt, int min = int.MinValue)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string? line = Console.ReadLine();
            if (line is null)
            {
                return 0;
            }
            if (int.TryParse(line, out result) && result >= min)
            {
                return result;
            }
            Console.WriteLine("Некорректный ввод, попробуйте ещё раз.");
        }
    }
}
