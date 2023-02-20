using System.Numerics;

namespace _1822._Sign_of_the_Product_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
   
            Console.WriteLine(ArraySign(array));
        }

        public static int ArraySign(int[] nums)
        {
          BigInteger miltiply = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                miltiply *= nums[i];
            }
            return signFunc(miltiply);
        }

        public static int signFunc(BigInteger x)
        {
            if (x > 0) return 1;
            else if(x < 0) return -1;
            else return 0;
        }
    }
}