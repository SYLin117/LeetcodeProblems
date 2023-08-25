using System.Text.RegularExpressions;

namespace Others.Walmart;

public class RegexTest
{
    public static void Main()
    {
        string text = "one car red car blue car";
        string pattern = @"(\w+)\s+(car)";
        var r = new Regex(pattern, RegexOptions.IgnoreCase);
        Match m = r.Match(text);
        if (m.Success)
        {
            Console.Write(m.Value);
        }
        else
        {
            Console.WriteLine("no match");
        }
    }
}