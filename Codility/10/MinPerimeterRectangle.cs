using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._10
{
    class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            var minPerimeter = int.MaxValue;

            for (var i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    minPerimeter = Math.Min(minPerimeter, 2 * (N / i + i));
                }
            }

            return minPerimeter;
        }
    }
}
