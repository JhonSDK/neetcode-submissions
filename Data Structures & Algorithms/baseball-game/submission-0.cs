public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();

        foreach(var op in operations){
            if(op == "+"){
                int top = stack.Pop();
                int newTop = top + stack.Peek();
                stack.Push(top);
                stack.Push(newTop);
            } else if (op == "C"){
                stack.Pop();
            } else if (op == "D"){
                stack.Push(2 * stack.Peek());
            } else {
                stack.Push(int.Parse(op));
            }
        }
         int total = 0;
         foreach(var val in stack){
            total += val;
         }
         
         return total;
    }
}