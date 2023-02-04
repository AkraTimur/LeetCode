namespace _1281._Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SubtractProductAndSum(234));
        }
        public static int SubtractProductAndSum(int n)
        {
            int sum = 0;
            int mult = 1;

            var _n = Convert.ToString(n).ToCharArray();
            for (int i = 0; i < _n.Length; i++)
            {
                sum += Convert.ToInt32(_n[i].ToString());
                mult *= Convert.ToInt32(_n[i].ToString());
            }

            return mult - sum;
        }
    }
}