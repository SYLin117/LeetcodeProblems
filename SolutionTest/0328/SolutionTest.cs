using MyDataStructure;

namespace SolutionTest._0328;

using Solutions._0328OddEvenLinkedList;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        var sol = new Solution();
        var head = sol.OddEvenList(new int[] { 1, 2, 3, 4 }.ToListNode());
        Console.ReadLine();
    }
}