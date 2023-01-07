namespace _1._Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Solution.TwoSum(new[] { 3, 2, 4 }, 6);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}