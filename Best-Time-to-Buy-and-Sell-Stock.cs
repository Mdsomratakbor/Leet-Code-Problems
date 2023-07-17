using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Best_Time_to_Buy_and_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            if(prices == null)
            {
                return 0;
            }
            int minimumPrice = prices.Min();
            int minimumPriceIndex = Array.IndexOf(prices, minimumPrice);
            int maximumPrice = 0;
            for(int i= minimumPriceIndex; i<prices.Length; i++)
            {
                int price = prices[i] - minimumPrice;
                if (maximumPrice < price)
                {
                    maximumPrice = price;
                }
                
            }
            return maximumPrice;
        }
    }
}
