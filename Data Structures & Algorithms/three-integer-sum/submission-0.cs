public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int n=nums.Length;
        List<List<int>> result = new List<List<int>>();
        HashSet<string> seen = new HashSet<string>();
        for(int i=0;i<n;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                for(int k=j+1;k<n;k++)
                {
                     if(nums[i]+nums[j]+nums[k]==0)
                     {

List<int> triplet = new List<int> { nums[i], nums[j], nums[k] };
                        triplet.Sort();
                        string key = string.Join(",", triplet);
                        if (!seen.Contains(key)) {
                            seen.Add(key);
                            result.Add(new List<int>(triplet));
                        }
                     }
                }
            }
        }
        return result;
    }
}
