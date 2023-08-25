using MyDataStructure;

namespace Solutions._0142LinkedListCycleII;

public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        bool met = false;
        while (slow != null && fast != null)
        {
            slow = slow.next;
            fast = fast.next;
            if (fast != null) fast = fast.next;
            if (slow == null || fast == null) break;
            if (slow.Equals(fast))
            {
                met = true;
                break;
            }
        }

        if (!met)
        {
            return null;
        }
        else
        {
            var index1 = head;
            var index2 = slow;
            while (!index1.Equals(index2))
            {
                index1 = index1.next;
                index2 = index2.next;
            }

            return index1;
        }
    }
}