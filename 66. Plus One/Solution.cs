using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _66._Plus_One
{
    public static class Solution
    {
        public static int[] PlusOne(int[] digits)
        {     
            //part 1
            string digitToString = string.Join("", digits);
            var maxBigInteger = BigInteger.Parse(digitToString)+1;

            //part 2 back to string and arr
            var backToString = string.Join("", maxBigInteger);
            var array = backToString.ToCharArray();

            //part 2 array char to arr int
            var listOfres = new List<int>();
            foreach( var item in array ) 
            {
                listOfres.Add(int.Parse(item.ToString()));
            }

            return listOfres.ToArray();
        }
    }
}
