namespace Solutions._0383RansomNote;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] dict = new int[26];
        foreach (char c in magazine)
        {
            dict[(int)c - (int)'a'] += 1;
        }

        foreach (char c in ransomNote)
        {
            if (dict[(int)c - (int)'a'] <= 0) return false;
            dict[(int)c - (int)'a'] -= 1;
        }

        return true;
    }
}