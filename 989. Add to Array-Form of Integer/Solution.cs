using System.Numerics;

namespace _989._Add_to_Array_Form_of_Integer
{
    public static class Solution
    {
        public static IList<int> AddToArrayForm(int[] num, int k)
        {
            string str = string.Join("", num);
            IList<int>list = new List<int>();

            var num1 = BigInteger.Parse(str);
            var sum = num1 + k;
            var res = Convert.ToString(sum);

            foreach (var item in res)
            {
                list.Add(int.Parse(item.ToString()));
            }
            return list;
        }
    }
}
//https://leetcode.com/problems/add-to-array-form-of-integer/