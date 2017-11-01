using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility._3
{
    public class ArrayRotater
    {
        public int[] Rotate(int[] A, int K)
        {
            var rotater = new List<int>(A);

            for (var i = 0; i < K; i++)
            {
                rotater.Insert(0, rotater.Last());
                rotater.RemoveAt(rotater.Count - 1);
            }

            return rotater.ToArray();
            //Array.Reverse(A, 0, K - 1);
            //Array.Reverse(A, K - 1, A.Length - K + 1);
            //Array.Reverse(A, 0, A.Length);
            //return A;
        }
    }
}
