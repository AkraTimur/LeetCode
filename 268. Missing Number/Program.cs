namespace _268._Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.MissingNumber(new int[] {1,2 }));
        }

        public class Solution
        {
            public static int MissingNumber(int[] nums)
            {
                Array.Sort(nums);

                for (int i = 0; i < nums[nums.Length - 1]; i++)
                {
                    if (nums[i] != i)
                    {
                       return i;
                    }
                }

                return nums[nums.Length - 1] += 1;
            }
        }
    }
}
