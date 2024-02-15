namespace _278._First_Bad_Version
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int FirstBadVersion(int n)
        {
            int start = 0;
            int end = n;
            int mid = (start + (end - start) / 2);

            while (start < end) 
            {
                 mid = (start + (end - start) / 2);
                bool res = IsBadVersion(mid);
                if (res == true)
                {
                    end = mid;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return start;
        }
    }
}