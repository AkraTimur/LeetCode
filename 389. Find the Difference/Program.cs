namespace _389._Find_the_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ae", t = "aea";
            //string s = "abcd", t = "abcde";

            Console.WriteLine(Solution.FindTheDifference(s, t));
        }
    }

    public class Solution
    {
        public static char FindTheDifference(string s, string t)
        {
            if (s.Length == 0) return t[0];


            var arr = s.ToCharArray().ToList();

            var arrT = t.ToCharArray().ToList();

            var combineAll = (s + t).ToCharArray().ToList();

            var findCount = combineAll.GroupBy(x => x).Where(g => g.Count() > 2).FirstOrDefault();

            if(findCount == null)
            {
                var res = arrT.Except(arr).FirstOrDefault();
                return res;
            }

            return findCount.FirstOrDefault();
            //var arrS = s.ToCharArray().ToList();
            //var arrT = t.ToCharArray().ToList();

            //var res = arrT.GroupBy(x => x).FirstOrDefault(g => g.Count() >= 2);

            //if(res == null)
            //{
            //    for(int i = 0; i < arrS.Count; i++) 
            //    {
            //        arrT.Remove(arrS[i]);
            //    }

            //    return arrT.First();
            //}

            //return res.FirstOrDefault();
        }
    }
}