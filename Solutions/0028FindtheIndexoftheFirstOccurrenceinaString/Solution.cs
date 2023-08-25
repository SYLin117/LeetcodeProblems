namespace Solutions._0028FindtheIndexoftheFirstOccurrenceinaString;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        return BruteForce(haystack, needle);
    }

    private int BruteForce(string haystack, string needle)
    {
        int result = -1;
        if (needle.Length > haystack.Length) return -1;
        bool find = false;

        for (int i = 0; i < haystack.Length; i++)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                if (i + j >= haystack.Length || haystack[i + j] != needle[j])
                {
                    break;
                }

                if (j == needle.Length - 1)
                {
                    find = true;
                    result = i;
                }
            }

            if (find) break;
        }

        return result;
    }

    private int KMP(string haystack, string needle)
    {
        return -1;
    }
}