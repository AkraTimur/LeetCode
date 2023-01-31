using System.Numerics;
using System.Text;

namespace _1903._Largest_Odd_Number_in_String
{
    public static class Solution
    {
        public static string LargestOddNumber(string num)
        {
            string sub = num;
            int len = sub.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                if (sub[i] % 2 != 0)
                {
                    return sub.Substring(0, i + 1);
                }
            }

            return "";
        }
    }
}
