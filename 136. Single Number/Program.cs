namespace _136._Single_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine(SingleNumber(input));
        }
        public static int SingleNumber(int[] nums)
        {
            int unique = 0;

            foreach (var num in nums)
            {
                unique ^= num;
            }
            return unique;
        }
    }
}
//Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

//You must implement a solution with a linear runtime complexity and use only constant extra space.
