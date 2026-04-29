public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      Dictionary<int, int> data = new Dictionary<int, int>();

 foreach (int num in nums)
 {
      if(data.ContainsKey(num))
     {
         data[num]++;
     }
     else
     {
         data[num] = 1;
     }
 }
var result = data
            .OrderByDescending(x => x.Value)  
            .Take(k)                       
            .Select(x => x.Key)            
            .ToArray();

        
        return result;
    }
}
