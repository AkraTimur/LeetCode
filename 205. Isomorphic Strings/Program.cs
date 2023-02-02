namespace _205._Isomorphic_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsomorphic("paper", "title"));
        }
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var map = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    if (map.ContainsValue(t[i]))
                        return false;

                    map[s[i]] = t[i];
                }
                else if (map[s[i]] != t[i])
                    return false;
            }
            return true;
        }
    }
}