public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int sum = 0;
        
        for(int f = 0; f < nums.Length; f++){
            
            for(int s = f + 1; s < nums.Length; s++){
                
                sum = nums[f] + nums[s];
                
                if(sum == target){
                    
                 return new int[]{f, s};
                    
                }
                
            }
            
        }
        return null;
    }
}