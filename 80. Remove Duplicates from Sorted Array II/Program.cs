namespace _80._Remove_Duplicates_from_Sorted_Array_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            Console.WriteLine(sol.RemoveDuplicates(new [] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }));
        }

        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                int pointer = 0;

                int count = 0;

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i-1] == nums[i] && count < 2)
                    {
                        nums[pointer] = nums[i - 1];
                        pointer++;
                        count++;

                    }
                    else if (nums[i - 1] != nums[i] && nums[i - 2] != nums[i - 1])
                    {
                        nums[pointer] = nums[i-1];
                        pointer++;
                        count = 0;
                    }
                    else if (nums[i - 1] != nums[i] && nums[i - 2] == nums[i - 1] && count < 2)
                    {
                        nums[pointer] = nums[i - 1];
                        pointer++;
                        count = 0;
                    }
                }

                return pointer;
            }
        }
    }
}