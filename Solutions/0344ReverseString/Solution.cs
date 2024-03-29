namespace Solutions._0344ReverseString;

public class Solution
{
    public void ReverseString(char[] s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            var tmp = s[left];
            s[left] = s[right];
            s[right] = tmp;
            left++;
            right--;
        }
    }
}