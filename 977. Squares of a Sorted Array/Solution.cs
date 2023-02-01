using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _977._Squares_of_a_Sorted_Array
{
    public class Solution
    {
        public static int[] SortedSquares(int[] nums)
        {
            var res = nums.Select(x => (x * x)).OrderBy(x => x).ToArray();
            return res;
        }
    }
}
