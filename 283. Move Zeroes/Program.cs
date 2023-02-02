namespace _283._Move_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
            Console.WriteLine();
        }
        public static void MoveZeroes(int[] arr)
        {
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                if (arr[i] != 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j++] = temp;
                }
            }
        }
    }
}