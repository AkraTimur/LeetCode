namespace _70._Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class Solution
        {
            public static int ClimbStairs(int n)
            {
                if (n == 1)
                {
                    return 1;
                }

                int n1 = 1;
                int n2 = 2;

                for (int i = 3; i <=n ; i++)
                {
                    int temp = n2;  // Сохраняем значение n2
                    n2 = n1 + n2;   // Обновляем n2
                    n1 = temp;      // Обновляем n1 с предыдущим значением n2
                }

                return n2;
            }
        }
    }
}