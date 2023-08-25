namespace Solutions._0003LengthOfLongestSubstring;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        
        int start = 0;
        int end = 0;
        int result = 0;
        int len = s.Length;
        HashSet<char> set = new();
        while (end < len)
        {
            if (set.Contains(s[end]))
            {
                while (set.Contains(s[end]))
                {
                    set.Remove(s[start]);
                    start++;
                }
            }
            else
            {
                set.Add(s[end]);
                end++;
                result = Math.Max(result, end - start);
            }
        }

        result = Math.Max(result, end - start);
        return result;
    }
}