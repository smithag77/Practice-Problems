using System;

namespace Codility._4
{
    public class MissingInteger
    {
        public int GetFirstPositiveMissingInteger(int[] A)
        {
            var founds = new bool[A.Length + 1];
            var max = A.Length;
            var threshold = 1;

            foreach (var item in A)
            {
                if (item > 0 && item <= max)
                {
                    founds[item] = true;
                }

                if (item > threshold)
                {
                    threshold = item;
                }
            }

            for (var i = 1; i < founds.Length; i++)
            {
                if (!founds[i])
                    return i;
            }
            return threshold+1;
        }
    }
}
