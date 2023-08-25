namespace Solutions._0643MaximumAverageSubarrayI;

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int left = 0;
        int right = k-1;
        int current = 0;
        int result = Int32.MinValue;
        if(nums.Length<=1) return (double) nums[0];
        for(int i=0; i<nums.Length; i++){
            if(i < k){
                current += nums[i];
            }else{
                current -= nums[left];
                left++;
                current += nums[i];
            }
            result = Math.Max(result, current);
        }
        return (double)result/k;
    }
}