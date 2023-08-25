using System.Diagnostics;

namespace Solutions._1657DetermineifTwoStringsAreClose;

public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length) return false;
        int[] cnt1 = new int[26];
        int[] cnt2 = new int[26];
        HashSet<char> set = new();
        foreach (var c in word1)
        {
            cnt1[c - 'a']++;
            set.Add(c);
        }

        foreach (var c in word2)
        {
            // two words could only have same characters(could have different occurence)
            if (set.Contains(c)) cnt2[c - 'a']++;
        }

        Array.Sort(cnt1);
        Array.Sort(cnt2);
        for (int i = 0; i < cnt1.Length; i++)
        {
            
            if (cnt1[i] != cnt2[i]) return false;
        }

        return true;
    }
}