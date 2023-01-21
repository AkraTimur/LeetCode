using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _67._Add_Binary
{
    public static class Solution
    {
        public static string AddBinary(string binaryString1, string binaryString2)
        {
            int len1 = binaryString1.Length;
            int len2 = binaryString2.Length;
            if (len1 > len2)
                binaryString2 = binaryString2.PadLeft(len1, '0');
            else
                binaryString1 = binaryString1.PadLeft(len2, '0');

            int carry = 0;
            string result = "";

            for (int i = binaryString1.Length - 1; i >= 0; i--)
            {
                int bit1 = binaryString1[i] - '0';
                int bit2 = binaryString2[i] - '0';
                int sum = (bit1 ^ bit2 ^ carry);
                result = sum.ToString() + result;
                carry = (bit1 & bit2) | (bit1 & carry) | (bit2 & carry);
            }

            if (carry != 0)
                result = '1' + result;
            return result;
        }
    }
}
