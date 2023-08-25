namespace Solutions._0020ValidParentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                char tmp;
                if (!stack.TryPop(out tmp)) return false;
                if (c == ')')
                {
                    if (tmp != '(') return false;
                }
                else if (c == ']')
                {
                    if (tmp != '[') return false;
                }
                else if (c == '}')
                {
                    if (tmp != '{') return false;
                }
            }
        }

        if (stack.Count > 0) return false;
        return true;
    }
}