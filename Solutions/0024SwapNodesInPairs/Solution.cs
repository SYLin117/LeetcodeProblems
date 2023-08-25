using MyDataStructure;

namespace Solutions._0024SwapNodesInPairs;

public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null) return head;

        var dummy = new ListNode(next: head);
        var cur = dummy;

        while (cur.next != null && cur.next.next != null)
        {
            var tmp1 = cur.next;
            var tmp2 = cur.next.next;
            var tmp3 = cur.next.next.next;

            cur.next = tmp2;
            cur.next.next = tmp1;
            cur.next.next.next = tmp3;

            cur = cur.next.next;
        }

        dummy.next.Print();
        return dummy.next;
    }
}