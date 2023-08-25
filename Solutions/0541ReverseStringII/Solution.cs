namespace Solutions._0541ReverseStringII;

public class Solution
{
    public string ReverseStr(string s, int k)
    {
        var sChars = s.ToCharArray();
        for (int i = 0; i < s.Length; i += 2 * k)
        {
            if (i + k < s.Length)
            {
                Reverse(sChars, i, i + k - 1);
            }
            else
            {
                Reverse(sChars, i, s.Length - 1);
            }
        }

        return new string(sChars);
    }

    public void Reverse(char[] s, int index1, int index2)
    {
        while (index1 < index2)
        {
            var tmp = s[index1];
            s[index1] = s[index2];
            s[index2] = tmp;

            index1++;
            index2--;
        }
    }
}