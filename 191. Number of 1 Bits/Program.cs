namespace _191._Number_of_1_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingWeight(00000000000000000000000000001011));
        }
        public static int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                count += (int)(n & 1);
                n >>= 1;
            }
            return count;
        }
    }
}