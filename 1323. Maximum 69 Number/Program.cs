namespace _1323._Maximum_69_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maximum69Number(9669));
        }
        public static int Maximum69Number(int num)
        {
            var str = num.ToString().ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '6')
                {
                    str[i] = '9';
                    break;
                }       
            }

            return int.Parse(str);
        }
    }
}