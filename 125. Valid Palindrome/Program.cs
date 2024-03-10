using System.Text.RegularExpressions;

namespace _125._Valid_Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("0P"));
        }
        public static bool IsPalindrome(string s)
        {
            var res = Regex.Replace(s, @"[^A-Za-z0-9]", "").ToLower();

            int j = res.Length - 1;
            int i = 0;

            while (i < j)
            {
                if (res[i] != res[j])
                    return false;

                j--;
                i++;
            }

            return true;
        }
    }
}