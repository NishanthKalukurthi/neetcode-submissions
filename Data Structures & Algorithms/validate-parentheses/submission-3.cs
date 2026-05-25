public class Solution {
    public bool IsValid(string s) {
        Stack<char> stac=new();
        foreach(var ch in s){
            if(ch=='['||ch=='{'||ch=='('){
                stac.Push(ch);
            }
            else if(stac.Count==0) return false;
            else if((ch==']'&&stac.Pop()!='[')||(ch=='}'&&stac.Pop()!='{')
            ||(ch==')'&&stac.Pop()!='(')) return false;
        }
        return stac.Count==0;
    }
}
