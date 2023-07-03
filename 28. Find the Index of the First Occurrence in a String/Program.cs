namespace _28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haystack = "sadbutsad", needle = "sad";
            Console.WriteLine(Solution.StrStr(haystack, needle));
        }

        public class Solution
        {
            public static int StrStr(string haystack, string needle)
            {
                if(haystack.Contains(needle))
                {
                    int index = haystack.IndexOf(needle);
                    return index;
                }

                return -1;
            }
        }
    }
}