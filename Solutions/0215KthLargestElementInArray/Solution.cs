namespace Solutions._0215KthLargestElementInArray;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> queue = new();
        foreach (var num in nums)
        {
            if ((queue.Count >= k && queue.Peek() < num) || queue.Count < k) queue.Enqueue(num,  num);
            if (queue.Count > k) queue.Dequeue();
        }

        return queue.Dequeue();
    }
}