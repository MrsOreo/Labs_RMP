namespace Labs;

public class MinFinder
{
    public int FindMin(int[] array, out int index)
    {
        int minValue = array[0];
        index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                index = i;
            }
        }

        return minValue;
    }
}
