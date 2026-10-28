namespace Labs;

public class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Животное издаёт звук");
    }
}
