using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1480._Running_Sum_of_1d_Array
{
    public class Solution
    {
        public static int[] RunningSum(int[] nums)
        {
            int sum = 0;
            for (int i = nums.Length-1; i > 0; i--)
            {
                sum = 0;
                for (int j = 0; j <= i; j++)
                {
                    sum += nums[j];
                }
                nums[i] = sum;
            }
            return nums;
        }
    }
}
