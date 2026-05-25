public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> target=new();
        foreach(var ch in t){
            if(!target.ContainsKey(ch)){
                target[ch]=0;
            }
            target[ch]++;
        }

        Dictionary<char,int> window=new();
        int have=0;
        int need=target.Count;
        int left=0;
        int startIndex=0;
        int minWindow=int.MaxValue;
        for(int r=0;r<s.Length;r++){
            if(!window.ContainsKey(s[r])){
                window[s[r]]=0;
            }
            window[s[r]]++;

            if(target.ContainsKey(s[r])&&target[s[r]]==window[s[r]]){
                have++;
            }
            while(have==need){
                int curLength=r-left+1;
                if(curLength<minWindow){
                    minWindow=curLength;
                    startIndex=left;
                }
               
                window[s[left]]--;

                if(target.ContainsKey(s[left])&& target[s[left]]>window[s[left]])
                have--;

                left++;

            }

        }
        if(minWindow==int.MaxValue) return "";

        return s.Substring(startIndex,minWindow);
    }
}
