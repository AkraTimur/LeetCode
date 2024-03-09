namespace _389._Find_the_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "ae", t = "aea";
            string s = "abcd", t = "abcde";

            Console.WriteLine(Solution.FindTheDifference(s, t));
        }
    }

    public class Solution
    {
        public static char FindTheDifference(string s, string t)
        {
            if (s.Length == 0) return t[0];

            var arrS = s.ToCharArray();
            var arrT = t.ToCharArray();

            Array.Sort(arrS);
            Array.Sort(arrT);

            var listRes = new List<char>();

            for (int i = 0; i < arrT.Length; i++)
            {
                if (i > arrS.Length - 1)
                {
                    listRes.Add(arrT[i]);
                    break;
                }

                if (arrS[i] != arrT[i])
                    listRes.Add(arrT[i]);
            }

            return listRes.FirstOrDefault();
        }
    }
}
