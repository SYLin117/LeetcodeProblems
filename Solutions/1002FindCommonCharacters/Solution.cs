namespace Solutions._1002FindCommonCharacters;

public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        int[] hash = new int[26];

        IList<string> result = new List<string>();
        foreach (char c in words[0])
        {
            hash[(int)c - (int)'a'] += 1;
        }

        for (int i = 1; i < words.Length; i++)
        {
            int[] otherHash = new int[26];
            foreach (char c in words[i])
            {
                otherHash[(int)c - (int)'a'] += 1;
            }

            for (int j = 0; j < 26; j++)
            {
                hash[j] = Math.Min(hash[j], otherHash[j]);
            }
        }

        for (int i = 0; i < 26; i++)
        {
            while (hash[i] > 0)
            {
                result.Add(Convert.ToString(Convert.ToChar((int)'a' + i)));
                hash[i]--;
            }
        }

        return result;
    }
}