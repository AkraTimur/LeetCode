using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Two_Sum
{
    public  class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        list.Add(i);
                        list.Add(j);
                        break;
                    }
                }
            }

            return list.ToArray();
        }
    }
}
