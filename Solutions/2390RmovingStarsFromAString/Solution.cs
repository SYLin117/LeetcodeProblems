namespace Solutions._2390RmovingStarsFromAString;

public class Solution {
    public string RemoveStars(string s)
    {
        Stack<char> stack = new();
        foreach (var c in s)
        {
            if (c != '*')
            {
                stack.Push(c);
            }
            else
            {
                stack.Pop();
            }
        }

        var result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}