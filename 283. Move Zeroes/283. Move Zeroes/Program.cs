namespace _283._Move_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,1 };

            Solution.MoveZeroes(nums);


        }

        public class Solution
        {
            public static void MoveZeroes(int[] nums)
            {
                int i, j;

                for (i = 0, j = 1; i < nums.Length && j < nums.Length;)
                {
                    if (nums.Length < 2) break;

                    if (nums[i] != 0)
                    {
                        i++;
                        if (nums[j] != 0) j++;
                    }
                    else if (nums[j] == 0) j++;
                    else
                    {
                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
    }
}