namespace _704._Binary_Search
{
    public class Solution
    {
        public static int Search(int[] nums, int target)
        {
            var low = 0;
            var high = nums.Length - 1;
            var guess = 0;
            int count = 0;

            while (low <= high)
            {
                guess = (low + high) / 2;
                if (target == nums[guess]) return guess;
                else if(target < nums[guess])
                {
                    high = guess - 1;
                }
                else
                {
                    low= guess + 1;
                }
            }
            return -1;
        }
    }
}


