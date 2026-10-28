namespace Labs;

public static class Lab5
{
    public static void Run()
    {
        Console.WriteLine("1 — List<int>: числа и среднее");
        List<int> numbers = new() { 3, 8, 12, 5, 20, 7 };
        Console.WriteLine("Числа: " + string.Join(", ", numbers));
        int total = 0;
        foreach (int value in numbers)
        {
            total += value;
        }
        Console.WriteLine($"Среднее: {Math.Round((double)total / numbers.Count, 2)}");

        Console.WriteLine();
        Console.WriteLine("2 — числа больше введённого");
        List<int> input = new();
        for (int i = 0; i < 5; i++)
        {
            input.Add(ReadInt($"Число [{i}]: "));
        }
        int bound = ReadInt("Введите число: ");
        Console.Write($"Больше {bound}: ");
        bool found = false;
        foreach (int value in input)
        {
            if (value > bound)
            {
                Console.Write(value + " ");
                found = true;
            }
        }
        if (!found)
        {
            Console.Write("нет");
        }
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("3 — обратный порядок");
        List<int> list = new() { 1, 2, 3, 4, 5 };
        Console.WriteLine("Было: " + string.Join(", ", list));
        list.Reverse();
        Console.WriteLine("Стало: " + string.Join(", ", list));

        Console.WriteLine();
        Console.WriteLine("4 — самое длинное слово");
        List<string> words = new() { "дом", "программирование", "окно" };
        string longest = "";
        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }
        Console.WriteLine($"Самое длинное слово: {longest}, количество символов: {longest.Length}");

        Console.WriteLine();
        Console.WriteLine("5 — список фильмов");
        List<string> films = new() { "Матрица", "Начало" };
        int choice;
        do
        {
            Console.WriteLine("1 — добавить фильм");
            Console.WriteLine("2 — найти фильм");
            Console.WriteLine("3 — вывести весь список");
            Console.WriteLine("0 — выход");
            choice = ReadInt("Выбор: ");
            switch (choice)
            {
                case 1:
                    Console.Write("Название: ");
                    string? title = Console.ReadLine();
                    if (title is null)
                    {
                        choice = 0;
                        break;
                    }
                    if (title.Trim() == "")
                    {
                        Console.WriteLine("Название не может быть пустым.");
                    }
                    else
                    {
                        films.Add(title.Trim());
                        Console.WriteLine("Фильм добавлен.");
                    }
                    break;
                case 2:
                    Console.Write("Название: ");
                    string? search = Console.ReadLine();
                    if (search is null)
                    {
                        choice = 0;
                        break;
                    }
                    int index = films.FindIndex(f => f.Equals(search.Trim(), StringComparison.OrdinalIgnoreCase));
                    if (index < 0)
                    {
                        Console.WriteLine("Не найдено");
                    }
                    else
                    {
                        Console.WriteLine($"Найден: {films[index]} (индекс {index})");
                    }
                    break;
                case 3:
                    Console.WriteLine("Фильмы: " + string.Join(", ", films));
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Неизвестный пункт меню.");
                    break;
            }
        }
        while (choice != 0);
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
