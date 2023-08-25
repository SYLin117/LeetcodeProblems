namespace Others.Walmart;

public class DeferExeTest
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var evenElement = from element in array
            where (element % 2) == 0
            select element;
        int count = 0;
        foreach (int elm in evenElement)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}