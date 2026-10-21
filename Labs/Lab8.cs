namespace Labs;

public static class Lab8
{
    public static void Run()
    {
        Console.WriteLine("Класс Book");
        Book hobbit = new("Хоббит", "Джон Толкин", 1937);
        Book littlePrince = new("Маленький принц", "Антуан де Сент-Экзюпери", 1943, true);
        Book dune = new("Дюна", "Фрэнк Герберт", 1965, false);

        hobbit.ShowInfo();
        Console.WriteLine();
        littlePrince.ShowInfo();
        Console.WriteLine();
        dune.ShowInfo();
    }
}
