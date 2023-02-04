namespace _367._Valid_Perfect_Square
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectSquare(808201));
        }

        public static bool IsPerfectSquare(int num)
        {
            int lowNum = 1, highNum = num/2;
            if ((num / 2) * (num / 2) == num || num == 1) return true;

            while(lowNum <= highNum)
            {
                int mid = lowNum + (highNum - lowNum) / 2;
                if (mid * mid == num) return true;
                else if(mid * mid < num)
                {
                    lowNum = mid +1;
                }
                else
                {
                    highNum = mid - 1;
                }
            }

            return false;
        }
    }
}
