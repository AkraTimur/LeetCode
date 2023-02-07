namespace _202._Happy_Number
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsHappy(n));
        }

        public static bool IsHappy(int n)
        {
            int slow = n, fast = n;
            do
            {
                slow = SumOfSquaredDigits(slow);
                fast = SumOfSquaredDigits(SumOfSquaredDigits(fast));
            } while (slow != fast);

            return slow == 1;
        }

        private static int SumOfSquaredDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }
            return sum;
        }
    }
}
