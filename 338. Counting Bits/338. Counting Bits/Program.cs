namespace _338._Counting_Bits;
class Program
{
    static void Main(string[] args)
    {
        var solution = Solution.CountBits(2);
        Console.WriteLine("Hello, World!");
    }

    public static class Solution
    {
        public static int[] CountBits(int n)
        {
            var arr = new int[n + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i >> 1] + i % 2;
            }
            return arr;
        }
    }
}