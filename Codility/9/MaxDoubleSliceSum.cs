using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._9
{
    class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {
            var N = A.Length;
            var K1 = new int[N];
            var K2 = new int[N];

            for (var i = 1; i < N - 1; i++)
            {
                K1[i] = Math.Max(K1[i - 1] + A[i], 0);
            }
            for (var i = N - 2; i > 0; i--)
            {
                K2[i] = Math.Max(K2[i + 1] + A[i], 0);
            }

            var max = 0;

            for (var i = 1; i < N - 1; i++)
            {
                max = Math.Max(max, K1[i - 1] + K2[i + 1]);
            }

            return max;
        }
    }
}
