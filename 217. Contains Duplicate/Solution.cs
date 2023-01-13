namespace _217._Contains_Duplicate
{
    public class Solution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var res = nums.GroupBy(x => x)
                          .Where(g => g.Count() > 1)
                          .Select(x => x.Count())
                          .ToList();

            return (res.Count >= 1);
        }
    }
}
