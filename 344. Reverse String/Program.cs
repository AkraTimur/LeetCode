using System.Linq;
using System.Net.WebSockets;

namespace _344._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString(new char[] {'h','e','x' });
        }
        public static void ReverseString(char[] s)
        {
            Array.Reverse(s);
            var str = new string(s);
            
            Console.WriteLine(str);
        }
    }
}