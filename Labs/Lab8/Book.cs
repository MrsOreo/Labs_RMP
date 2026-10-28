namespace Labs;

public class Book
{
    public string Title { get; }

    public string Author { get; }

    public int Year { get; }

    public bool IsAvailable { get; }

    public Book(string title, string author, int year)
        : this(title, author, year, true)
    {
    }

    public Book(string title, string author, int year, bool isAvailable)
    {
        Title = title;
        Author = author;
        Year = year;
        IsAvailable = isAvailable;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Год издания: {Year}");
        Console.WriteLine($"Доступна в библиотеке: {(IsAvailable ? "да" : "нет")}");
    }
}
