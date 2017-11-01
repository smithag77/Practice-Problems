using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._4
{
    public class PermMissingElemFinder
    {
        public int FindMissingInt(int[] A)
        {
            //var sumOfAllElements = (A.Length + 1) * (A.Length + 2) / 2;
            //var sumOfArrayElements = A.Sum();

            //return sumOfAllElements - sumOfArrayElements;
            long sum = 0, sum1 = 0;
            int i;

            for (i = 0; i < A.Length; i++)
            {
                sum += Convert.ToInt64(i + 1);
                sum1 += Convert.ToInt64(A[i]);
            }
            sum += Convert.ToInt64(i + 1);

            return Convert.ToInt32(sum - sum1);
        }
    }
}
