namespace Labs;

public class ArrayFiller
{
    private readonly Random _random = new();

    public int[] Fill(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = _random.Next(1, 101);
        }

        return array;
    }
}
