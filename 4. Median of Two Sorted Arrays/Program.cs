namespace _4._Median_of_Two_Sorted_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[] { 1, 3 };
            var arr2 = new int[] { 2 };
            var arr3 = new int[] { 1, 1 };
            var arr4 = new int[] { 1, 2 };
            Console.WriteLine(FindMedianSortedArrays(arr3,arr4));
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double res = 0.00;
            var array = nums1.Concat(nums2).ToArray();
            Array.Sort(array);

            if(array.Length % 2 == 1)
            {
                res = (double)array[array.Length / 2];
            }
            else
            {
                var num1 = (double)array[array.Length / 2];
                var num2 = (double)array[(array.Length / 2) -1];
                res = (num1 + num2) / 2.00;
            }
            return res;
        }
    }
}