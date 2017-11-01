using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._10
{
    class Peaks
    {
        public int solution(int[] A)
        {
            var N = A.Length;

            // Find all the peaks
            var peaks = new List<int>();
            for (var i = 1; i < N - 1; i++)
            {
                if (A[i] > A[i - 1] &&
                    A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            for (var size = 1; size <= N; size++)
            {
                if (N % size != 0) continue; // skip if non-divisible
                var find = 0;
                var groups = N / size;
                var ok = true;

                // Find whether every group has a peak
                foreach (var peakIndex in peaks)
                {
                    if (peakIndex / size > find)
                    {
                        ok = false;
                        break;
                    }
                    if (peakIndex / size == find)
                    {
                        find++;
                    }
                }

                if (find != groups)
                {
                    ok = false;
                }

                if (ok)
                {
                    return groups;
                }
            }

            return 0;
        }
    }


}
