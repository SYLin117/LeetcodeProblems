using System.Collections;

namespace Solutions._0212ValidAnagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        int[] dict = new int[26];
        if (s.Length != t.Length) return false;
        // var dict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            var ascii = (int)c - (int)'a';
            dict[ascii] += 1;
        }

        foreach (char c in t)
        {
            var ascii = (int)c - (int)'a';
            if (dict[ascii] <= 0) return false;
            dict[ascii] -= 1;
        }

        return true;
    }
}