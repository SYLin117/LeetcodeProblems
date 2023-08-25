namespace Solutions._0150EvaluateReversePolishNotation;

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        foreach (string token in tokens)
        {
            if (token.Equals("+"))
            {
                var num2 = stack.Pop();
                var num1 = stack.Pop();
                stack.Push(num1 + num2);
            }
            else if (token.Equals("-"))
            {
                var num2 = stack.Pop();
                var num1 = stack.Pop();
                stack.Push(num1 - num2);
            }
            else if (token.Equals("*"))
            {
                var num2 = stack.Pop();
                var num1 = stack.Pop();
                stack.Push(num1 * num2);
            }
            else if (token.Equals("/"))
            {
                var num2 = stack.Pop();
                var num1 = stack.Pop();
                stack.Push(num1 / num2);
            }
            else
            {
                stack.Push(Int32.Parse(token));
            }
        }

        return stack.Peek();
    }
}