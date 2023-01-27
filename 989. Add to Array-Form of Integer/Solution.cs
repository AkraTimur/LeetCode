using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _989._Add_to_Array_Form_of_Integer
{
    public static class Solution
    {
        public static IList<int> AddToArrayForm(int[] num, int k)
        {
            string str = string.Join("", num);
            var list = new List<int>();
            list.Add(int.Parse(str) + k);

            return list;
        }
    }
}
//https://leetcode.com/problems/add-to-array-form-of-integer/