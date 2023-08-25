namespace _303._Range_Sum_Query___Immutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class NumArray
        {
            private int[] prefixSum;

            public NumArray(int[] nums)
            {
                int n = nums.Length;
                prefixSum = new int[n];

                prefixSum[0] = nums[0];
                for (int i = 1; i < n; i++)
                {
                    prefixSum[i] = prefixSum[i - 1] + nums[i];
                }
            }

            public int SumRange(int left, int right)
            {
                if (left == 0)
                {
                    return prefixSum[right];
                }
                else
                {
                    return prefixSum[right] - prefixSum[left - 1];
                }
            }
        }

    }
}