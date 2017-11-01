using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._10
{
    class CountFactors
    {
        public int solution(int N)
        {
            var i = 1;
            var result = 0;
            while (i < Math.Sqrt(N))
            {
                if (N % i == 0)
                {
                    result += 2;
                }
                i++;
            }
            if (Math.Pow(i, 2) == N)
            {
                result += 1;
            }
            return result;
        }
    }
}
