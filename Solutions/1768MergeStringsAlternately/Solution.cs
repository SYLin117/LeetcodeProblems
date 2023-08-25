using System.Text;

namespace Solutions._1768MergeStringsAlternately;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int len1 = word1.Length;
        int len2 = word2.Length;
        int idx1 = 0;
        int idx2 = 0;
        StringBuilder sb = new StringBuilder();
        while (idx1 < len1 && idx2 < len2)
        {
            sb.Append(word1[idx1]);
            idx1++;
            sb.Append(word2[idx2]);
            idx2++;
        }

        if (idx1<=len1-1)
        {
            sb.Append(word1.Substring(idx1));
        }

        if (idx2<=len2-1)
        {
            sb.Append(word2.Substring(idx2));
        }

        return sb.ToString();
    }
}