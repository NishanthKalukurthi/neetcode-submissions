public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] chars=new int[26];
        if(s.Length!=t.Length) return false;
        for(int i=0;i<s.Length;i++){
            chars[s[i]-'a']++;
            chars[t[i]-'a']--;
        }
        for(int i=0;i<26;i++){
            if(chars[i]!=0) return false;
        }
        return true;
    }
}
