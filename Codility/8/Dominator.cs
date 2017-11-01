using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._8
{
    class Dominator
    {
        public int solution(int[] A)
        {
            var n = A.Length;
            var size = 0;
            var s = new Stack<int>();

            for (var i = 0; i < n; i++)
            {
                if (size == 0)
                {
                    size += 1;
                    s.Push(A[i]);
                }
                else
                {
                    if (s.Peek() != A[i]) size -= 1;
                    else size += 1;
                }
            }
            var candidate = -1;
            if (size > 0) candidate = s.Peek();
            var count = 0;
            var leader = -1;

            for (var i = 0; i < n; i++)
            {
                if (A[i] == candidate) count += 1;
                if (count > n / 2) leader = candidate;
            }

            return Array.IndexOf(A, leader);
        }
    }
}
