public class Solution {
    public bool IsPalindrome(string s) {
       
        string refinedInput=Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
         int start=0;
        int end=refinedInput.Length-1;
        while(start<=end){
                if(refinedInput[start]!=refinedInput[end])
                return false;
                start++;
                end--;
        }
        return true;
    }
}
