public class Solution {
    public int LongestConsecutive(int[] nums) {
            if(nums ==null|| nums.Length==0)
            {
                 return 0;
            }
        var data = new HashSet<int>(nums);
        int longestStreak = 0;
        foreach(int i in data)
        {
             if(!data.Contains(i-1))
             {
                int currentNum = i;
            int currentStreak = 1;

            while (data.Contains(currentNum + 1))
            {
                currentNum++;
                currentStreak++;
            }

            longestStreak = Math.Max(longestStreak, currentStreak);
             }
        }
        return longestStreak;
        
    }
}
