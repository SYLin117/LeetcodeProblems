namespace Others.Codewars;

public class Narcissistic
{
    public static void Main()
    {
        Console.WriteLine(Solution(1));
    }

    public static bool Solution(int value)
    {
        // Code me
        int sum = 0;
        int digit = 0;
        int tmp = value;
        while (tmp > 0)
        {
            digit += 1;
            tmp /= 10;
        }

        tmp = value;
        while (tmp > 0)
        {
            sum += (int)Math.Pow((value % 10), digit);
            tmp /= 10;
        }

        return sum == value;
    }
}