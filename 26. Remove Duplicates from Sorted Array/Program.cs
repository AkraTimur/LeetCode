namespace _26._Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution res = new Solution();
    
            Console.WriteLine(res.RemoveDuplicates(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }

        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                int val = -1000;
                int writePointer = 1;

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] != nums[i-1])
                    {
                        nums[writePointer] = nums[i];
                        writePointer++;
                    }
                }

                return writePointer;
            }
        }
    }
}
