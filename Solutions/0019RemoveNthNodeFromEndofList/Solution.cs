using MyDataStructure;

namespace Solutions._0019RemoveNthNodeFromEndofList;

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var cur = head;
        int size = 0;
        while (cur != null)
        {
            size++;
            cur = cur.next;
        }

        if (n == size)
        {
            return head.next;
        }

        var slow = head;
        var fast = head;
        int idx = n + 1;
        while (idx > 0)
        {
            fast = fast.next;
            idx--;
        }

        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;
        return head;
    }
}