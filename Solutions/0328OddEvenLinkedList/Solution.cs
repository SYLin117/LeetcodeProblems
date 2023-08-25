using MyDataStructure;

namespace Solutions._0328OddEvenLinkedList;

public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode dummy = new ListNode(0, head);
        ListNode firstOdd = head;
        ListNode firstEven = head.next;

        var odd = firstOdd;
        var even = firstEven;
        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }

        odd.next = firstEven;
        return dummy.next;
    }
}