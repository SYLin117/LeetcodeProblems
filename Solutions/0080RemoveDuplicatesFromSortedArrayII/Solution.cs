namespace Solutions._0080RemoveDuplicatesFromSortedArrayII;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int result = 0;
        int prev = Int32.MinValue;
        int currentCnt = 0;
        for(int i=0; i<nums.Length; i++){
            var num = nums[i];
            if(i==0){
                currentCnt = 1;
                prev = num;
                continue;
            }
            if(prev == num){
                currentCnt++;
                continue;
            }
            if(i>0 && prev != num){
                nums[result] = prev;
                result++;
                if(currentCnt>1){
                    nums[result] = prev;
                    result++;
                }
                prev = num;
                currentCnt = 1;
            }
        }
        nums[result] = prev;
        result++;
        if(currentCnt>1){
            nums[result] = prev;
            result++;
        }
        return result;
    }
}