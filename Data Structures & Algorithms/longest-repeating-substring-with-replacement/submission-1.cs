public class Solution {
    public int CharacterReplacement(string s, int k) {
        if(s==null )
        {
            return 0;
        }
        
        Dictionary<char , int> map=new Dictionary<char,int>();
        int maxcount=0;
        int left=0;
        int maxLength = 0;
        for(int i=0;i<s.Length;i++)
        {
            if(!map.ContainsKey(s[i]))
            {
                 map.Add(s[i],1);
            }else{
                map[s[i]]++;
            }
            maxcount=Math.Max(maxcount,map[s[i]]);
            
            while ((i - left + 1) - maxcount > k)
             {
                 map[s[left]]--; 
                 left++; 
                 } 
            maxLength = Math.Max(maxLength, i - left + 1);

        }
        return maxLength;
    }
}
