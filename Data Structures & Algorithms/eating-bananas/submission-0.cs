public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if(h ==0 || piles.Length > h)
        {
            return 0;
        }
        int speed=1;
        while(true)
        {
             long totaltime=0;
             foreach(int p in piles)
             {
                totaltime += (int)Math.Ceiling((double)p/speed);
             }

             if(totaltime<=h)
             {
                return speed;
             }
             speed++;
        }

    }
}
