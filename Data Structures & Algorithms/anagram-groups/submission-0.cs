public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> anagrams=new();
        foreach(string str in strs)
        {
            string encoder=Encode(str);

            if(!anagrams.ContainsKey(encoder)){
                anagrams[encoder]=new List<string>();
            }

            anagrams[encoder].Add(str);
        }

        List<List<string>> result=new();

        foreach(var item in anagrams){
            result.Add(item.Value);
        }

        return result;
    }

    private string Encode(string str)
    {
        int[] charsCount=new int[26];
        foreach(char ch in str){
            charsCount[ch-'a']++;
        }

        return string.Join('#',charsCount);
    }
}
