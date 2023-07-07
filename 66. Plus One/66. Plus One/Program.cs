using System.Numerics;

namespace _66._Plus_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 1, 2, 3};

            var res = Solution.PlusOne(digits);
        }

        public class Solution
        {
            public static int[] PlusOne(int[] digits)
            {
                BigInteger bigInteger = BigInteger.Parse(string.Join("", digits)) + 1;

                var sum = bigInteger.ToString();

                List<int> result = new List<int>();

                foreach (var digit in sum) 
                {
                    result.Add(Convert.ToInt32(digit.ToString()));
                }

                return result.ToArray();
            }
        }
    }
}