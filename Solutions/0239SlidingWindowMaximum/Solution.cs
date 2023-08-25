namespace Solutions._0239SlidingWindowMaximum;

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        LinkedList<int> queue = new LinkedList<int>(); // we store the index in the queue
        List<int> res = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while (queue.Count > 0 && queue.First.Value < i - k + 1) // REMEMBER: queue store the index, (i - k + 1) is the range of window
            {
                // if the largest value in the queue is out of window, we remove it
                queue.RemoveFirst();
            }

            var currentVal = nums[i];

            // we need to make sure that the queue is in 'descending order', we achieve this by 'removing all the item in the queue that is smaller than the current val'
            // we only need to track the largest value, so removing the smaller item does not matter.
            while (queue.Count > 0 && nums[queue.Last.Value] < currentVal)
                queue.RemoveLast();

            queue.AddLast(i);

            // we start to add max item to the result set when i = k-1.
            if (i >= k - 1)
                res.Add(nums[queue.First.Value]);
        }

        return res.ToArray();
    }
}