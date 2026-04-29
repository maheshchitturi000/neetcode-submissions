public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<int> store=new Stack<int>();
         foreach (var token in tokens)
        {
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                int b = store.Pop();
                int a = store.Pop();

                switch (token)
                {
                    case "+":
                        store.Push(a + b);
                        break;
                    case "-":
                        store.Push(a - b);
                        break;
                    case "*":
                        store.Push(a * b);
                        break;
                    case "/":
                        store.Push(a / b);
                        break;
                }
            }
            else
            {
                store.Push(int.Parse(token));
            }
        }

        return store.Pop();
    }
}
