namespace Others.Walmart;

public class BoolOperations
{
    public static void Solution()
    {
        int i = 2;
        int j = i;
        if (Convert.ToBoolean((i | j & 5) & (j - 25 * 1)))
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0); // answer
        }
    }
}