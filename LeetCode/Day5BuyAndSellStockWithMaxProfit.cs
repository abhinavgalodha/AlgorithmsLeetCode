namespace LeetCode
{
    public class Day5BuyAndSellStockWithMaxProfit
    {
        public int GetMaximumProfit(int[] prices)
        {
            
            // 1. Calculate differences between the numbers
            // 2. Choose max positive differences which are not consecutive.

            // 7,1,5,3,6,4
            // -6,4,-2,3,-2

            // 1,2,3,4,5
            // 1,1,1,1

            // 4,50,60, 12, 2, 10
            // 46, 10, -38, -10, 8

            // 10, 20, 30, 40, 50, 60
            // 10, 10, 10, 10, 10

            if (prices == null || prices.Length == 0)
            {
                return 0;
            }

            int maxProfit = 0;
            int lengthOfInputArray = prices.Length;
            int[] differenceArray = new int[lengthOfInputArray - 1];

            for (int index = 0; index < lengthOfInputArray - 1; index++)
            {
                differenceArray[index] = prices[index + 1] - prices[index];
            }

            for (int index = 0; index < lengthOfInputArray - 1; index++)
            {
                int currentDifference = differenceArray[index];
                if (currentDifference > 0)
                {
                    maxProfit = maxProfit + differenceArray[index];
                }
            }

            return maxProfit;
        }

        /// <exception cref="T:System.OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue"></see> elements.</exception>
        public int GetMaximumProfitSingleLoop(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }

            
            int maxProfit = 0;
            int lengthOfInputArray = prices.Length;
            
            for (int index = 0; index < lengthOfInputArray - 1; index++)
            {
                var currentProfit = prices[index];
                var nextProfit = prices[index + 1];

                if (nextProfit > currentProfit)
                {
                    maxProfit = maxProfit + nextProfit - currentProfit;    
                }
            }

            return maxProfit;
        }
    }
}
