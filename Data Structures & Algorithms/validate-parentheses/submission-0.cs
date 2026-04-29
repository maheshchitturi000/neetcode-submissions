public class Solution {
    public bool IsValid(string s) {
        if(s.Length<=0)
        {
                return false;
        }
        Stack<char> data=new Stack<char>();

        foreach(char c in s)
        {
            if(c=='(' || c=='[' || c=='{')
            {
                data.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            { 
                if(data.Count ==0)
                {
                    return false;

                }
                     char top = data.Pop();
                   if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    return false;
                }

            }
        }
           return data.Count == 0;

        
    }
}
