using MyDataStructure;

namespace Solutions._0206ReverseLinkedList;

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode cur = head;
        while (cur != null)
        {
            var tmp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = tmp;
        }

        return prev;
    }
}