public class Solution {
    public int[] SortArray(int[] nums) {
        int n=nums.Length; // 3,1,6,4
        for(int i=0;i<n-1;i++)
        {
            bool swapped = false;
            for(int j=0;j<n-i-1;j++)
            {
                  
                 if(nums[j]>nums[j+1])
                 {
                        int temp = nums[j];
                         nums[j] =nums[j+1];
                         nums[j+1]=temp;
                        swapped = true;
                 }
                
            }
           
        }
        return nums;
        
    }
}