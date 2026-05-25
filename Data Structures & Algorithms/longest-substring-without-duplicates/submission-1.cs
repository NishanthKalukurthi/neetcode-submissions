public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length<=1) return s.Length;
        int startIndex=0;
        int lengthOfLongestSubstring=0;
        Dictionary<char,int> map=new();
        for(int i=0;i<s.Length;i++){
            char ch=s[i];
            if(map.ContainsKey(ch)){
                int curPosition=map[ch]+1;
                if(startIndex<curPosition){
                    startIndex=curPosition;
                }
            }
            map[ch]=i;
            lengthOfLongestSubstring=Math.Max(lengthOfLongestSubstring,i-startIndex+1);
        }
        return lengthOfLongestSubstring;
    }
}
