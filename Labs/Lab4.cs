namespace Labs;

public static class Lab4
{
    private static readonly Random Random = new();

    public static void Run()
    {
        Console.WriteLine("1 — Сумма положительных чисел");
        int[] array1 = FillRandom(ReadInt("Сколько чисел: ", 1));
        PrintArray(array1);
        int sum = 0;
        foreach (int value in array1)
        {
            if (value > 0)
            {
                sum += value;
            }
        }
        Console.WriteLine($"Сумма положительных чисел: {sum}");

        Console.WriteLine();
        Console.WriteLine("2 — Среднее арифметическое");
        int[] array2 = FillFromKeyboard(ReadInt("Сколько чисел: ", 1));
        int total = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            total += array2[i];
        }
        Console.WriteLine($"Среднее: {Math.Round((double)total / array2.Length, 2)}");

        Console.WriteLine();
        Console.WriteLine("3 — Подсчёт нулей");
        int[] array3 = FillFromKeyboard(ReadInt("Сколько чисел: ", 1));
        int zeros = 0;
        int index = 0;
        while (index < array3.Length)
        {
            if (array3[index] == 0)
            {
                zeros++;
            }
            index++;
        }
        Console.WriteLine($"Нулей: {zeros}");

        Console.WriteLine();
        Console.WriteLine("4 — Индексы элементов");
        int[] array4 = FillFromKeyboard(ReadInt("Сколько чисел: ", 1));
        int target = ReadInt("Введите число: ");
        List<int> found = new();
        for (int i = 0; i < array4.Length; i++)
        {
            if (array4[i] == target)
            {
                found.Add(i);
            }
        }
        if (found.Count == 0)
        {
            Console.WriteLine("Не найдено");
        }
        else
        {
            Console.WriteLine("Индексы: " + string.Join(", ", found));
        }

        Console.WriteLine();
        Console.WriteLine("5 — Количество чисел в заданном диапазоне");
        int[] array5 = FillFromKeyboard(ReadInt("Сколько чисел: ", 1));
        PrintArray(array5);
        int from = ReadInt("Граница от: ");
        int to = ReadInt("Граница до: ");
        while (to < from)
        {
            Console.WriteLine("Граница «до» не может быть меньше границы «от».");
            to = ReadInt("Граница до: ");
        }
        int inRange = array5.Count(value => value >= from && value <= to);
        Console.WriteLine($"Количество: {inRange}");
    }

    private static int[] FillRandom(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Next(-10, 16);
        }
        return array;
    }

    private static int[] FillFromKeyboard(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = ReadInt($"Элемент [{i}]: ");
        }
        return array;
    }

    private static void PrintArray(int[] array)
    {
        Console.WriteLine("Массив: " + string.Join(", ", array));
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
