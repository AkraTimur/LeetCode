namespace _189._Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = TwoSum(new int[] { 2, 3, 4 }, 6);
            Console.WriteLine("Hello, World!");
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int sum = 0;

            var iIndex = 1;
            var jIndex = 1;
            var list = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length ; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        iIndex += i;
                        jIndex += j;
                        list.Add(iIndex);
                        list.Add(jIndex);
                        return list.ToArray(); ;
                    }
                }
            }
            return list.ToArray();
        }
    }
}
