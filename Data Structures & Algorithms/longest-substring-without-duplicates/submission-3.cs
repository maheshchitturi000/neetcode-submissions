public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if(s ==null )
        {
             return 0;
        }
        HashSet<char> uniquedata= new HashSet<char>();
        int visitedelement=0;
        int maxLen = 0;
        

        for(int i=0;i<s.Length;i++)
        {
            char current=s[i];
            while(uniquedata.Contains(current))
            {
                uniquedata.Remove(s[visitedelement]);
                visitedelement++;
            }
            uniquedata.Add(current);
            maxLen = Math.Max(maxLen, i - visitedelement + 1);
        }
        return maxLen;
    }
}
