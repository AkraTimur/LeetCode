namespace _80._Remove_Duplicates_from_Sorted_Array_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            Console.WriteLine(sol.RemoveDuplicates(new [] { 1, 1, 1, 2, 2, 2, 3, 3 }));
        }

        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                var duplicates = nums.GroupBy(x => x)
                    .Where(g => g.Count() > 2)
                    .ToDictionary(g => g.Key, g => g.Count());

                int pointer = 0;
                 int count = 0;
                int sigma = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    bool containsKey = duplicates.ContainsKey(nums[i]);

                    if (containsKey && count <2 && nums[i] != sigma)
                    {
                        nums[pointer] = nums[i];
                        pointer++;
                        count++;
                    }
                    else if(containsKey && nums[i] == sigma)
                    {
                        count = 0;
                        sigma = nums[i];
                        continue;
                    }
                    else
                    {
                        nums[pointer] = nums[i];
                        pointer++;
                        count = 0;
                    }
                }

                return pointer;
            }
        }
    }
}