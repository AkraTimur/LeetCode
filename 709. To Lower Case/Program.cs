namespace _709._To_Lower_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.ToLowerCase("Hello, World!"));
        }
    }
    public class Solution
    {
        public static string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }
}