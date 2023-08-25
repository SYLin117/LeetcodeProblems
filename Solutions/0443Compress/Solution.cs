using System.Text;

namespace Solutions._0443Compress;

public class Solution
{
    public int Compress(char[] chars)
    {
        StringBuilder sb = new StringBuilder();
        int left = 0, right = 0;
        int cnt;
        while (right < chars.Length)
        {
            if (left == right) right++;
            else if (chars[left] == chars[right])
            {
                right++;
            }
            else
            {
                cnt = right - left;
                if (cnt == 1)
                {
                    sb.Append($"{chars[left]}");
                }
                else
                {
                    sb.Append($"{chars[left]}{cnt}");
                }

                left = right;
            }
        }

        cnt = right - left;
        if (cnt == 1)
        {
            sb.Append($"{chars[left]}");
        }
        else
        {
            sb.Append($"{chars[left]}{cnt}");
        }

        for (int i = 0; i < sb.Length; i++)
        {
            chars[i] = sb[i];
        }
        return sb.Length;
    }
}