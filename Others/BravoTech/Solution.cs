using System.Runtime.CompilerServices;
using Others.Walmart;

namespace Others.BravoTech;

// public class DuplicateDTO()
// {
//     public string Word { get; set; }
//     public int Count { get; set; }
// }
//
// public class Solution
// {
//     static Dictionary<string, string> test = new Dictionary<string, string>()
//     {
//         { "apple", "bad-request" },
//         { "pear", "bad-request" },
//         { "pineapple", "bad-request" },
//         { "banana", "bad-request" },
//         { "watermelon", "bad-request" },
//         { "kiwi", "bad-request" },
//         // { "apple", "bad-request" },
//         { "peach", "bad-request" },
//         { "grape", "bad-request" },
//         { "lime", "bad-request" },
//         { "lemon", "bad-request" },
//         // { "banana", "bad-request" },
//         // { "watermelon", "bad-request" }
//     };
//
//     public static void Main()
//     {
//         var ans1 = test.Keys.Distinct();
//         Console.WriteLine(string.Join(",", ans1));
//
//         var ans2 = test.Keys.GroupBy(x => x).Where(g => g.Count() >= 2).Select(g => g.Key);
//         foreach (var tmp in ans2)
//         {
//             Console.WriteLine($"{tmp} ");
//         }
//
//         var ans3 = test.Keys.GroupBy(x => x).Select(g => new DuplicateDTO()
//         {
//             Count = g.Count(),
//             Word = g.Key
//         });
//     }
// }