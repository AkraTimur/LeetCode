namespace _1332._Remove_Palindromic_Subsequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemovePalindromeSub("ababa"));
        }

        public static int RemovePalindromeSub(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            if (IsPalindrom(s)) return 1;
            return 2;
        }

        public static bool IsPalindrom(string s)
        {
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right]) return false;

                left++;
                right--;
            }
            return true;
        }
    }
}
