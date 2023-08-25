namespace Solutions._0151ReverseWordsinaString;

public class Solution
{
    public string ReverseWords(string s)
    {
        s = s.Trim();
        char[] chars = s.ToCharArray();
        Reverse(chars, 0, s.Length - 1);
        int start = 0, end = 0;
        while (end < s.Length)
        {
            if (chars[end] == ' ')
            {
                Reverse(chars, start, end - 1);
                start = end + 1;
                end = start;
            }
            else
            {
                end++;
            }
        }

        Reverse(chars, start, end - 1);
        int newLength = RemoveSpace(chars);
        
        return string.Concat(chars.Take(newLength));
    }

    private void Reverse(char[] s, int start, int end)
    {
        while (start < end)
        {
            var tmp = s[start];
            s[start] = s[end];
            s[end] = tmp;
            start++;
            end--;
        }
    }

    private int RemoveSpace(char[] s)
    {
        int slow = 0; //整体思想参考https://programmercarl.com/0027.移除元素.html
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] != ' ')
            {
                //遇到非空格就处理，即删除所有空格。
                if (slow != 0) s[slow++] = ' '; //手动控制空格，给单词之间添加空格。slow != 0说明不是第一个单词，需要在单词前添加空格。
                while (i < s.Length && s[i] != ' ') // add new word until encounter a ' '
                {
                    //补上该单词，遇到空格说明单词结束。
                    s[slow++] = s[i++];
                }
            }
        }

        return slow; // new length
    }
}