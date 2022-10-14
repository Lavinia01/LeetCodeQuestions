public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        
        int X = 0;
        for(int i = 0; i < operations.Length; i++){
            
            if(operations[i] == "++X" || operations[i] == "X++"){
                X += 1;
            }
            else if (operations[i] == "--X" || operations[i] == "X--"){
                X-= 1;
            }
        }
        return X;
    }
}