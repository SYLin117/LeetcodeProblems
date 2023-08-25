using MyDataStructure;

namespace Solutions._2130MaximumTwinSumOfALinkedList;

public class Solution
{
    private ListNode l;
    private int max = Int32.MinValue;

    public int PairSum(ListNode head)
    {
        int result = Int32.MinValue;
        List<int> deque = new List<int>();
        while (head != null)
        {
            deque.Add(head.val);
            head = head.next;
        }

        int left = 0;
        int right = deque.Count - 1;
        while (left < right)
        {
            result = Math.Max(result, deque[left] + deque[right]);
            left++;
            right--;
        }

        return result;
    }
    
}