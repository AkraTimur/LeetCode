namespace _238._Product_of_Array_Except_Self;
class Program
{
    static void Main(string[] args)
    {
        var res = ProductExceptSelf(new int[] { 1, 2, 3, 4 });
        Console.WriteLine("Hello, World!");
    }

    public static int[] ProductExceptSelf(int[] nums)
    {
        var pointer = 0;
        var multiRes = 1;
        var listOfRes = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] != nums[pointer] && nums[j] != nums[pointer])
                {
                    multiRes = nums[i] * nums[j] * multiRes;
                }
                listOfRes.Add(multiRes);
                multiRes = 1;
                pointer++;
            }
        }
        return listOfRes.ToArray();
    }
}

