using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._6
{
    public class Triangle
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            if (A.Length < 3) return 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                {
                    return 1;
                }
                if (A[i] == A[i + 2] &&
                    A[i + 2] == A[i + 1] &&
                    A[i] == Int32.MaxValue)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
