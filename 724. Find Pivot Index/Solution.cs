namespace _724._Find_Pivot_Index
{
    public class Solution
    {
        public static int PivotIndex(int[] nums)
        {
            int leftSum = 0;
            int sum = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                //The sum of the elements to the right of the current index
                int rightSum = sum - leftSum - nums[i];

                //Check if the sum of the elements to the left and right are equal
                if (leftSum == rightSum)
                {
                    return i;
                }

                //Add the current element to the left sum
                leftSum += nums[i];
            }

            //Return -1 if no pivot index exists
            return -1;
        }
    }
}
