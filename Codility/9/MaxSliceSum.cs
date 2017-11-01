using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._9
{
    class MaxSliceSum
    {
        public int solution(int[] A)
        {
            var maxEndingHere = A[0];
            var maxSoFar = A[0];
            for (var i = 1; i < A.Length; i++)
            {
                maxEndingHere = Math.Max(A[i], maxEndingHere + A[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }
    }
}
