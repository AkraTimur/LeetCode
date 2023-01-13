using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Reverse_Integer
{
    public class Solution
    {
        public static int Reverse(int x)
        {
            var str = $"{x}";
            var reverseStr = str.Reverse();
            string res = new string(reverseStr.ToArray());
            int number = Convert.ToInt32(res);
            
            
            return number;
        }
    }
}
