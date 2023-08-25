namespace Solutions._0345ReverseVowelsOfAString;

public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] sList = s.ToCharArray();
        string vowels = "AEIOUaeiou";
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            while (left < s.Length && !vowels.Contains(sList[left]))
            {
                left++;
            }

            while (right >= 0 && !vowels.Contains(sList[right]))
            {
                right--;
            }

            if (!(left < right) || left >= s.Length || right < 0) break;
            else
            {
                var tmp = sList[left];
                sList[left] = sList[right];
                sList[right] = tmp;
                left++;
                right--;
            }
        }

        return new string(sList);
    }
}