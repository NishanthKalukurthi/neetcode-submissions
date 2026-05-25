public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length) return false;
        
        int k=s1.Length;
        int[] count=new int[26];
        int[] window=new int[26];
        for(int i=0;i<k;i++){
            count[s1[i]-'a']++;
            window[s2[i]-'a']++;
        }
        if(Match(count,window)) return true;
        for(int i=k;i<s2.Length;i++){

            //if(i+k>=s2.Length) continue;
          window[s2[i]-'a']++;
          window[s2[i-k]-'a']--;
          if(Match(count,window)) return true;

          
        }
        return false;
    }
    private bool Match(int[] a, int[] b){
        for(int i=0;i<26;i++){
            if(a[i]!=b[i]) return false;
        }
        return true;
    }
}
