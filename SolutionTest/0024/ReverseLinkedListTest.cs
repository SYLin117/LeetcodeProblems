using MyDataStructure;
using Solutions._0024SwapNodesInPairs;

namespace SolutionTest._0024;

[TestClass]
public class ReverseLinkedListTest
{
    [TestMethod]
    public void Test()
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        var solution = new Solution();
        head = solution.SwapPairs(head);
        head.Print();
    }
}