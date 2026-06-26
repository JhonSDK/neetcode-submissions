public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int actual = 0;
        int max = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1){
                actual++;
                if (actual > max) max = actual;
            }else{
                actual = 0;
            }
        }
        return max;
    }
}