public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> data= new   Dictionary<string, List<string>>();

        foreach(string str in strs)
        {
             char [] sort= str.ToCharArray();
             Array.Sort(sort);
              string key = new string(sort);
             if(!data.ContainsKey(key))
             {
                    data[key]= new List<string>();
                    
             }
             data[key].Add(str);
        }
                return data.Values.ToList();

    }
}
