namespace _121._Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });

        }

        public static class Solution
        {
            public static int MaxProfit(int[] prices)
            {
                int minPrice = int.MaxValue;
                int maxProfit = 0;

                foreach (int price in prices)
                {
                    if (price < minPrice)
                    {
                        minPrice = price;
                    }
                    else if (price - minPrice > maxProfit)
                    {
                        maxProfit = price - minPrice;
                    }
                }

                return maxProfit;
            }
        }
    }
}
