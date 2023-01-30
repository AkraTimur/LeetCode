namespace _1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    public static class Solution
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int count = 0;
            var listOfRes = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if(nums[j] < nums[i])
                    {
                        count++;
                    }
                }
                listOfRes.Add(count);
            }
            return listOfRes.ToArray();
        }
    }
}
