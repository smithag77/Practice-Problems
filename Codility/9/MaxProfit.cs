using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._9
{
    class MaxProfit
    {
        public int solution(int[] A)
        {
            if (A.Length <= 1)
            {
                return 0;
            }

            var minBuyingPrice = A[0];
            var maxProfitSoFar = 0;

            for (var i = 1; i < A.Length; i++)
            {
                maxProfitSoFar = Math.Max(maxProfitSoFar, A[i] - minBuyingPrice);
                minBuyingPrice = Math.Min(minBuyingPrice, A[i]);
            }

            return maxProfitSoFar;
        }
    }
}
