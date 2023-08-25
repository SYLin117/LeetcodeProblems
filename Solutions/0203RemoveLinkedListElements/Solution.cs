using MyDataStructure;

namespace Solutions._0203RemoveLinkedListElements;

public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        var prev = new ListNode(0, head);
        var dummy = prev;
        while (head != null)
        {
            if (head.val == val)
            {
                var tmp = head.next;
                prev.next = tmp;
                head = head.next;
            }
            else
            {
                prev = prev.next;
                head = head.next;
            }
        }

        return dummy.next;
    }
}