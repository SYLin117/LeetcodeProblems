using System.Runtime.InteropServices;

namespace Utils;

public static class StringListExt
{
    public static void PrintAllElement(this IList<string> list)
    {
        foreach (string s in list)
        {
            Console.Write($"{s}, ");
        }
    }
}