namespace _367._Valid_Perfect_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectSquare(16));
        }

        public static bool IsPerfectSquare(int num)
        {
            int lowNum = 0, highNum = num/2;
            if ((num / 2) * (num / 2) == num) return true;

            while(lowNum <= highNum)
            {
                int mid = lowNum + (highNum - lowNum) / 2;
                if
            }

            return false;
        }
    }
}