public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length ==0|| s2.Length ==0)
        {
            return false;
        }
        string value="";
        if(s1.Length==1)
        {
           return s2.Contains(s1);
        }
        char [] firstsortedchar=s1.ToCharArray();
        Array.Sort(firstsortedchar);
        string firstsortedvalue=new string(firstsortedchar);

        for(int i=0;i<s2.Length-s1.Length+1;i++)
        {
            value = s2.Substring(i, s1.Length);
            char[] charArray = value.ToCharArray();
            Array.Sort(charArray);
            string newvalue =new string(charArray);

            if(newvalue==firstsortedvalue)
            {
                 return true;
                 break;
            }
        }
        return false;
    }
}
