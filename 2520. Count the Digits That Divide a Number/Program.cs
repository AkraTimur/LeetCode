namespace _2520._Count_the_Digits_That_Divide_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountDigits(121));
        }

        public static int CountDigits(int num)
        {
            int count = 0;
            var s = num.ToString();

            for (int i = 0; i < s.Length; i++)
            {
                if (num % int.Parse(s[i].ToString()) == 0)
                    count++;
            }
            return count;
        }
    }
}