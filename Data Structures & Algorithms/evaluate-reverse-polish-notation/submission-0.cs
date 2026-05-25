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
                stack.Push(token switch
                {
                    "+" => Add(a, b),
                    "-" => Sub(a, b),
                    "*" => Multiply(a, b),
                    _   => Divide(a, b)
                });
            }
        }

        return stack.Pop();
    }

    private int Add(int a , int b){
        return a+b;
    }
    private int Sub(int a , int b){
        return a-b;
    }

    private int Multiply(int a , int b){
        return a*b;
    }
    private int Divide(int a , int b){
        return a/b;
    }
}
