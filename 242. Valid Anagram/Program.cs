namespace _242._Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram", t = "nagaram";

            Console.WriteLine(Solution.IsAnagram(s, t));
        }

        public class Solution
        {
            public static bool IsAnagram(string s, string t)
            {
                if(s.Length != t.Length) return false;

                var arrS = s.ToCharArray();
                var arrT = t.ToCharArray();

                Array.Sort(arrS);
                Array.Sort(arrT);

                for (int i = 0;i < arrS.Length; i++)
                {
                    if (arrS[i] != arrT[i]) return false;
                }

                return true;
            }
        }
    }
}