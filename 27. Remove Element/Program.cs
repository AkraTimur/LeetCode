namespace _27._Remove_Element
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            Console.WriteLine(sol.RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
        }
    }
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
             int writePointer = 0;

            foreach (int i in nums)
            {
                if (i != val)
                {
                    nums[writePointer] = i;
                    writePointer++;
                }
            }

            return writePointer;
        }
    }
}