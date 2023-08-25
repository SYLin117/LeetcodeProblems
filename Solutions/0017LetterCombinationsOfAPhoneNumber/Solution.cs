namespace Solutions._0017LetterCombinationsOfAPhoneNumber;

public class Solution
{
    private Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>()
    {
        { 2, new List<string>() { "a", "b", "c" } },
        { 3, new List<string>() { "d", "e", "f" } },
        { 4, new List<string>() { "g", "h", "i" } },
        { 5, new List<string>() { "j", "k", "l" } },
        { 6, new List<string>() { "m", "n", "o" } },
        { 7, new List<string>() { "p", "q", "r", "s" } },
        { 8, new List<string>() { "t", "u", "v" } },
        { 9, new List<string>() { "w", "x", "y", "z" } },
    };

    private IList<string> path = new List<string>();
    private IList<string> result = new List<string>();

    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0) return result;
        Backtracking(digits, 0);
        return result;
    }

    private void Backtracking(string digits, int index)
    {
        if (index == digits.Length)
        {
            result.Add(string.Join("", path));
            return;
        }

        char c = digits[index];
        var num = Int32.Parse(c.ToString());
        var chars = dict[num];
        foreach (var tmp in chars)
        {
            path.Add(tmp);
            Backtracking(digits, index + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}