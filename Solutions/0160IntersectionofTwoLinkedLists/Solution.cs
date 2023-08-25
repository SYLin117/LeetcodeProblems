using MyDataStructure;

namespace Solutions._0160IntersectionofTwoLinkedLists;

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int sizeA = 0;
        int sizeB = 0;
        var curA = headA;
        while (curA != null)
        {
            sizeA++;
            curA = curA.next;
        }

        var curB = headB;
        while (curB != null)
        {
            sizeB++;
            curB = curB.next;
        }

        curA = headA;
        curB = headB;
        var diff = Math.Abs(sizeA - sizeB);
        if (sizeA >= sizeB)
        {
            while (diff > 0)
            {
                curA = curA.next;
                diff--;
            }
        }
        else
        {
            while (diff > 0)
            {
                curB = curB.next;
                diff--;
            }
        }

        while (curA != null && curB != null)
        {
            if (curA.Equals(curB))
            {
                return curA;
            }

            curA = curA.next;
            curB = curB.next;
        }

        return null;
    }
}