using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _905._Sort_Array_By_Parity
{
    public static class Solution
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            var parity = nums.Where(x => x % 2 == 0).ToList();
            var notParity = nums.Where(x => x % 2 !=0).ToList();

            return parity.Concat(notParity).ToArray();
        }
    }
}
