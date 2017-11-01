using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility._3
{
    public class TapeEquilibriumFinder
    {
        public int FindEqui(int[] A)
        {
            List<int> diffs = new List<int>();
            int left = 0;
            int sum = A.Sum();
            foreach (int item in A)
            {
                left += item;
                diffs.Add(Math.Abs((sum - left) - left));
            }
            return diffs.Min();
        }
    }
}
