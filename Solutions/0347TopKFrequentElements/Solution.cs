namespace Solutions._0347TopKFrequentElements;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        //哈希表-标权重
        Dictionary<int, int> dic = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i], 1);
            }
        }

        //优先队列-从小到大排列
        PriorityQueue<int, int> pq = new(); // PriorityQueue<TElement, TPriority>
        foreach (var num in dic)
        {
            pq.Enqueue(num.Key, num.Value);
            if (pq.Count > k)
            {
                pq.Dequeue(); // pop out the smallest value
            }
        }

        //数组倒装 (因為Dequeue取出的是最小的)
        int[] res = new int[k];
        for (int i = k - 1; i >= 0; i--)
        {
            res[i] = pq.Dequeue();
        }

        return res;
    }
}