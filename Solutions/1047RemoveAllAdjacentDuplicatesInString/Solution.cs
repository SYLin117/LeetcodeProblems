namespace Solutions._1047RemoveAllAdjacentDuplicatesInString;

public class Solution
{
    public string RemoveDuplicates(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            char tmp;
            if (stack.TryPeek(out tmp) && tmp == c)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        // Why Reverse? latest inserted element would be at index 0
        return new string(stack.Reverse().ToArray());
    }
}