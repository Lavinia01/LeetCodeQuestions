public class Solution {
    public int[] RunningSum(int[] nums) {
        
        int[] answer = new int [nums.Length];
        answer[0] = nums[0];
        for(int i = 1; i < nums.Length; i++){
            answer[i] = answer[i-1] + nums[i];
        }
        return answer;
    }
}