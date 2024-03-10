using System.ComponentModel.DataAnnotations;

namespace _49._Group_Anagrams
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GroupAnagrams(new string[] { "", "b", "" }));
        }

        public static IList<IList<string>> GroupAnagrams(string[] strsOld)
        {
            var strs = strsOld.ToList();
            IList<IList<string>> res = new List<IList<string>>();

            for (int i = 0; i < strs.Count; i++)
            {
                IList<string> list = new List<string>();

                if(!IsDuplicate(res, strs[i].ToString()))
                {
                    list.Add(strs[i]);

                    for (int j = i + 1; j < strs.Count; j++)
                    {
                        if (IsAnagram(strs[i].ToString(), strs[j].ToString()) /*&& !IsDuplicate(res, strs[j].ToString())*/)
                        {
                            list.Add(strs[j]);
                        }
                    }

                    res.Add(list);
                }
            }

            return res;
        }

        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            var arrOfchar1 = str1.ToCharArray();
            var arrOfchar2 = str2.ToCharArray();

            Array.Sort(arrOfchar1);
            Array.Sort(arrOfchar2);

            for (int i = 0; i < str1.Length; i++)
            {
                if (arrOfchar1[i] != arrOfchar2[i])
                    return false;
            }

            return true;
        }

        public static bool IsDuplicate(IList<IList<string>> strings, string findNumber)
        {
            foreach (var str in strings)
            {
                if (str.Contains(findNumber)) return true;
            }

            return false;
        }
    }
}