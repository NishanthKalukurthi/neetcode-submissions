public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack=new();
        foreach(string token in tokens){
            bool valid=int.TryParse(token , out int number);
            if(valid){
                stack.Push(number);
            }
            else{
                int b=stack.Pop();
                int a=stack.Pop();
                stack.Push( token switch{
                    "+"=>a+b,
                    "-"=>a-b,
                    "*"=>a*b,
                    _=>a/b
                });
            }
        }

        return stack.Pop();
    }

}
