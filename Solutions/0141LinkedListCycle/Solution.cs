using MyDataStructure;

namespace Solutions._0141LinkedListCycle;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast != null && slow != null)
        {
            slow = slow.next;
            fast = fast.next;
            if (fast != null) fast = fast.next;
            if (slow == null || fast == null) break;
            if (slow.Equals(fast)) return true;
        }

        return false;
    }
}