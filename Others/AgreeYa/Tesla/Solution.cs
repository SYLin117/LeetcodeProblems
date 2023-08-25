namespace Others.AgreeYa.Tesla;

public class Solution
{
    public static void Main()
    {
        Console.WriteLine(solution(2023, "Jan", "Feb", "1"));
    }

    public static int solution(int Y, string A, string B, string W)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)

        string year = Convert.ToString(Y);
        string startingDateInput = A + " 1," + year;
        string endingDateInput = B + " 1," + year;

        var s = DateTime.Parse(startingDateInput);

        while (s.DayOfWeek != DayOfWeek.Monday)
        {
            s = s.AddDays(1);
        }

        var e = DateTime.Parse(endingDateInput);
        // If we can get starting day and ending day compared with Monday and Sunday, we don't necessarily need W, which is the starting day on January.
        // we can add 1 month and minus 1 day, so it can help us find the previous month's ending date and we don't need to condsider if that's 28/29/30/31 days in a month or if it's a leap year
        e = e.AddMonths(1).AddDays(-1);
        while (e.DayOfWeek != DayOfWeek.Sunday)
        {
            e = e.AddDays(-1);
        }

        var weeks = (e.Subtract(s).Days + 1) / 7;
        return weeks;
    }
}