namespace Utils;

public static class TwoDimListExt
{
    public static void Print2dList<T>(this IList<IList<T>> lists)
    {
        foreach (var list in lists)
        {
            foreach (var item in list)
            {
                Console.Write($"{item.ToString()} ");
            }

            Console.WriteLine();
        }
    }
}