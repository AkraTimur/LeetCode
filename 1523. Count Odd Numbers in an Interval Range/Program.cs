namespace _1523._Count_Odd_Numbers_in_an_Interval_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int CountOdds(int low, int high)
        {
            int count = 0;

            for (int i = low; i <= high; i++)
            {
                if (i % 2 != 0) count++;
            }
            return count;
        }
    }
}