public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        int maxoverall = 0;
        for(int i = 0; i < accounts.Length; i++){
        
            int maxforperson = 0;
            
            foreach(int j in accounts[i]){
                maxforperson += j;
            }
            
            if(maxoverall < maxforperson){
                  maxoverall = maxforperson;
            }
        }
        return maxoverall;
    }
}