using System.Text;

namespace Solutions._0394DecodeString;

public class Solution
{
    public string DecodeString(string s)
    {
        Stack<char> stack = new();
        foreach (var c in s)
        {
            if (c != ']')
            {
                stack.Push(c);
            }
            else // encounter ']'
            {
                StringBuilder sb = new();
                char popChar;
                while (stack.TryPop(out popChar) && popChar != '[')
                {
                    sb.Insert(0, popChar);
                }

                char repeat;
                StringBuilder sbRepeat = new();
                while (stack.TryPeek(out repeat) && Char.IsNumber(repeat))
                {
                    sbRepeat.Insert(0, stack.Pop());
                }

                StringBuilder newString = new();
                int num = Int32.Parse(sbRepeat.ToString());
                for (int i = 0; i < num; i++)
                {
                    foreach (var tmp in sb.ToString())
                    {
                        stack.Push(tmp);
                    }
                }
            }
        }

        var result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}