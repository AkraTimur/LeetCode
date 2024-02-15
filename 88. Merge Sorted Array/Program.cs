namespace _88._Merge_Sorted_Array
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new [] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new[] { 2, 5, 6 };
            var n = 3;

            var sol = new Solution();

            sol.Merge(nums1, m, nums2, n);
        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var j = 0;
            
            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[j];
                j++;
            }

            Array.Sort(nums1);
        }
    }
}