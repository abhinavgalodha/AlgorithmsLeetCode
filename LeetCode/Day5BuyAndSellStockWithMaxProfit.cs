using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Day5BuyAndSellStockWithMaxProfit
    {
        public int GetMaximumProfit(int[] prices)
        {
            // 1. Calculate differences between the numbers
            // 2. Choose max positive differences which are not consecutive.

            var lengthOfInputArray = prices.Length;
            var differenceArray = new int[lengthOfInputArray - 1];

            for (int index = 0; index < lengthOfInputArray - 1; index++)
            {
                differenceArray[index] = prices[index + 1] - prices[index];
            }


        }
    }
}
