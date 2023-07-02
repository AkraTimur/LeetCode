namespace _1768._Merge_Strings_Alternately
{
    //    You are given two strings word1 and word2.Merge the strings by adding letters in alternating order, starting with word1.If a string is longer than the other, append the additional letters onto the end of the merged string.
    //    Return the merged string.

    public class Program
    {
        static void Main(string[] args)
        {
            var word1 = "abc";
            var word2 = "pqr";

           string word3 = "ab", word4 = "pqrs";

            Console.WriteLine(Solution.MergeAlternately(word3, word4));
        }
    }

    public class Solution
    {
        public static string MergeAlternately(string word1, string word2)
        {
            var list = new List<string>();

            var arr1 = word1.ToCharArray();
            var arr2 = word2.ToCharArray();

            var length = arr1.Length + arr2.Length;

            for (int i = 0; i < length; i++)
            {
                if (i < arr1.Length && arr1[i] != null) 
                {
                    list.Add(arr1[i].ToString());
                }

                if (i < arr2.Length && arr2[i] != null)
                {
                    list.Add(arr2[i].ToString());
                }
            }

            return string.Join("", list);
        }
    }
}