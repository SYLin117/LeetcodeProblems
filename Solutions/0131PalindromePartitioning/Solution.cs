namespace Solutions._0131PalindromePartitioning;

public class Solution
{
    private IList<IList<String>> lists = new List<IList<string>>();
    LinkedList<String> deque = new LinkedList<string>();

    public IList<IList<String>> Partition(String s)
    {
        Backtracking(s, 0);
        return lists;
    }

    private void Backtracking(String s, int startIndex)
    {
        //如果起始位置大于s的大小，说明找到了一组分割方案
        if (startIndex >= s.Length)
        {
            lists.Add(new List<string>(deque));
            return;
        }

        for (int i = startIndex; i < s.Length; i++)
        {
            //如果是回文子串，则记录
            if (IsPalindrome(s, startIndex, i))
            {
                String str = s.Substring(startIndex, i + 1);
                deque.AddLast(str);
            }
            else
            {
                continue;
            }

            //起始位置后移，保证不重复
            Backtracking(s, i + 1);
            deque.RemoveLast();
        }
    }

    //判断是否是回文串
    private bool IsPalindrome(String s, int startIndex, int end)
    {
        for (int i = startIndex, j = end; i < j; i++, j--)
        {
            if (s[i] != s[j])
            {
                return false;
            }
        }

        return true;
    }
}