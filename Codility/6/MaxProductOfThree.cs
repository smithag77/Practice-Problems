using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._6
{
    class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int a = 0;
            if (A[0] < 0 && A[1] < 0)
                a = A[0] * A[1] * A[A.Length - 1];
            int b = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

            if (a > b && (A[0] < 0 && A[1] < 0)) return a;
            return b;
        }
        /*
         There is two possibilities:
The first two elements are negative. Then we need to check if the triplet of those two elements and the last element in the array is > the product of the last three elements.
Any other situation, the maximal product is the product of the last three elements.
         */
    }
}
