namespace _3._Longest_Substring_Without_Repeating_Characters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int LengthOfLongestSubstring(string s)
        {
            var chars = s.ToCharArray();
            var longest = 0;
            var current = 0;
            var currentString = "";
            for (int i = 0; i < chars.Length; i++)
            {
                var currentChar = chars[i];
                if (currentString.Contains(currentChar))
                {
                    currentString = currentString.Substring(currentString.IndexOf(currentChar) + 1);
                    current = currentString.Length;
                }
                currentString += currentChar;
                current++;
                longest = Math.Max(longest, current);
            }
            return longest;
        }
    }
}
