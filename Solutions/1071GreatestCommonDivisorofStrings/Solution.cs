namespace Solutions._1071GreatestCommonDivisorofStrings;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        // 因為不管順序如何都必須可以被整除 所以兩者應該要相同
        if (!(str1 + str2).Equals(str2 + str1)) return "";
        int gcd = GCD(str1.Length, str2.Length);
        return str1.Substring(0, gcd);
    }

    private int GCD(int n1, int n2)
    {
        if (n2 == 0) return n1;
        return GCD(n2, n1 % n2);
    }
}