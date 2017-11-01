using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._5
{
    class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            var minI = 0;
            var minValue = 100001.0;

            for (var i = 0; i < A.Length - 1; i++)
            {

                if (((A[i] + A[i + 1]) / 2.0) < minValue)
                {
                    minI = i;
                    minValue = (A[i] + A[i + 1]) / 2.0;

                }
                if (i < A.Length - 2)
                {
                    if (((A[i] + A[i + 1] + A[i + 2]) / 3.0) < minValue)
                    {
                        minI = i;
                        minValue = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    }
                }
            }

            return minI;
        }
    }
}
