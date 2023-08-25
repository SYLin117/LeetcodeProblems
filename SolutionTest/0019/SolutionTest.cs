using MyDataStructure;
using Solutions._0019RemoveNthNodeFromEndofList;

namespace SolutionTest._0019;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void Test()
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);
        head = new Solution().RemoveNthFromEnd(head, 2);
        head.Print();
    }
}