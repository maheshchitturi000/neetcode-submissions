public class Solution {
    public int MaxArea(int[] heights) {
        if(heights.Length==0||heights.Length <=1 )
        {
            return 0;
        }
        int left=0;
        int right=heights.Length-1;
        int MaxArea=0;
        while(left<right)
        {
            int width=right-left;
            int area=width*Math.Min(heights[left],heights[right]);
            if(area>MaxArea)
            {
                 MaxArea=area;
            }
            
            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return MaxArea;
       
                                                                                                                                             
        
    }
}
