public class Solution {
    public void SortColors(int[] nums) {
        int n=nums.Length;
        for(int i=0;i<n-1;i++)
        {
             for (int j=0;j<n-i-1;j++)
             {
                if(nums[j]>nums[j+1])
                {
                    int swap=nums[j];
                    nums[j]=nums[j+1];
                    nums[j+1]=swap;

                }
             }
        }
    }
}