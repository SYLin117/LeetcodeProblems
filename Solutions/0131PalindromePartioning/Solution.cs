namespace Solutions._0131PalindromePartioning;

public class Solution
{
    IList<IList<string>> result = new List<IList<string>>();
    IList<string> current = new List<string>();

    public IList<IList<string>> Partition(string s)
    {
        Backtracking(s, 0);
        return result;
    }

    public void Backtracking(string s, int start)
    {
        if (start >= s.Length)
        {
            result.Add(new List<string>(current));
            return;
        }

        for (int i = start; i < s.Length; i++)
        {
            if (IsPalindrome(s, start, i))
            {
                current.Add(s.Substring(start, i - start + 1));
            }
            else
            {
                continue;
            }

            Backtracking(s, i + 1);
            current.RemoveAt(current.Count - 1);
        }
    }

    public bool IsPalindrome(string s, int start, int end)
    {
        if (end - start + 1 == 1) return true; // substring length 1
        while (start < end)
        {
            if (s[start] != s[end]) return false;
            start++;
            end--;
        }

        return true;
    }
}