using System.Text;

namespace _1790._Check_if_One_String_Swap_Can_Make_Strings_Equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = "aa"; 
            var s2 = "ac";

            Console.WriteLine(AreAlmostEqual(s1,s2));
        }

        public static bool AreAlmostEqual(string s1, string s2)
        {
            int count = 0;
            int index1 = -1;
            int index2 = -1;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s2[i] != s1[i])
                {
                    count++;
                    if (count == 1)
                    {
                        index1 = i;
                    }
                    else if (count == 2)
                    {
                        index2 = i;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return count <= 2 && (count == 0 || (count == 2 && s1[index1] == s2[index2] && s1[index2] == s2[index1]));
        }
    }
}
