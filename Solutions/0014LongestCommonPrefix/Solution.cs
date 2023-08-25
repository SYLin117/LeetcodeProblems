namespace Solutions._0014LongestCommonPrefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        Dictionary<int, char> dict = new(){
            {1, 'd'}
        };
        if (strs.Length == 0) return "";
        String prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
            while (strs[i].IndexOf(prefix) != 0)
            {
                // if prefix not exist in strs[i], shrink prefix by 1
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0) return "";
            }

        return prefix;
    }

    public void Main()
    {
        string[] strs = new[] { "flower", "flow", "flight" };
        LongestCommonPrefix(strs);
    }
}