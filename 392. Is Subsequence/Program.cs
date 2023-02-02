namespace _392._Is_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
        }

        public static bool IsSubsequence(string s, string t)
        {
            int sIndex = 0, tIndex = 0;
            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }
            return sIndex == s.Length;
        }
    }
}
