public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length ==0)
        {
             return false;
        }
        string result="", alphanumeric="";

        for(int i=0;i<s.Length;i++)
        {
            char c=s[i];
            if(char.IsLetterOrDigit(c))
            {
                alphanumeric+=char.ToLower(c);
            }

        }
        for (int i = alphanumeric.Length - 1; i >= 0; i--) { 
            result += alphanumeric[i];
        }
  

        if(alphanumeric.Equals(result))
        {
            return true;
        }
        else 
        return false;
        
    }
}
