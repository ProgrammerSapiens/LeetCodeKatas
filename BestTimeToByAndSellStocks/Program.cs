using System.Globalization;
using System.Numerics;

namespace BestTimeToByAndSellStocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 7, 1, 5, 3, 6, 4 };

            Solution solution = new Solution();
            int result = solution.MaxProfit(nums);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int min = prices[0];
            int max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] >= min && prices[i] <= max)
                    continue;

                if (prices[i] < min)
                {
                    min = prices[i];
                    max = min;
                    continue;
                }

                if (prices[i] > max)
                {
                    max = prices[i];
                    profit = max - min > profit ? max - min : profit;
                }
            }
            return profit;
        }
    }
}
