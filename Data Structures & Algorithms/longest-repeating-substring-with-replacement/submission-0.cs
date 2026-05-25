public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l=0;
        int maxFreq=0;
        int result=0;
        Dictionary<char,int> count=new();
        for(int r=0;r<s.Length;r++){

            if(count.ContainsKey(s[r])){
                count[s[r]]++;
            }
            else{
                count[s[r]]=1;
            }
            maxFreq=Math.Max(maxFreq,count[s[r]]);
            while(((r-l+1)-maxFreq)>k){
                count[s[l]]--;
                l++;
            }
            result=Math.Max(result,(r-l+1));
        }
        return result;
    }
}
