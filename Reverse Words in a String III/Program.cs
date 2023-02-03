namespace Reverse_Words_in_a_String_III
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("God Ding"));
        }

        public static string ReverseWords(string s)
        {
            var list= new List<string>();
            var arr = s.Split(' ');
            foreach (var item in arr) 
            {
                var ch = item.ToArray();
                Array.Reverse(ch);
                list.Add(new string(ch));
            }

            return string.Join(" ", list);
        }
    }
}
