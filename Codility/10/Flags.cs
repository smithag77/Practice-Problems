using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._10
{
    class Flags
    {
        public static int solution(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }

            // get a new array with peaks
            var peaks = new List<int>();
            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            // if a 1-2 peaks, we can return them directly
            if (peaks.Count <= 2)
            {
                return peaks.Count;
            }

            // start binary search
            var maxFlags = peaks.Count;
            var minFlags = 1;
            var result = 0;
            while (maxFlags >= minFlags)
            {
                var flags = (minFlags + maxFlags) / 2; // get middle of interval (binary search)
                if (CheckFlags(flags, peaks))
                {
                    result = flags;
                    minFlags = flags + 1;
                }
                else
                {
                    maxFlags = flags - 1;
                }
            }

            return result;
        }

        private static bool CheckFlags(int flagsCount, List<int> flags)
        {
            var i = 1;
            // assume first flag in first position
            var lastFlag = flags[0];
            var actualFlags = flagsCount - 1;
            while (actualFlags > 0 && i < flags.Count)
            {
                if (flags[i] - lastFlag >= flagsCount)
                {
                    actualFlags--; // can put one flag
                    lastFlag = flags[i];
                }

                i++;
            }

            return actualFlags == 0; // all flags were placed
        }
    }
}
