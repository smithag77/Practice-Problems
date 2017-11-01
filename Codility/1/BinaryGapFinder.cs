using System;
using System.Collections;

namespace Codility._1
{
    public class BinaryGapFinder
    {
        public string GetBinaryStringForInt(int intToConvert)
        {
            return Convert.ToString(intToConvert, 2);
        }

        public int GetLargestBinaryGap(int intToCheck)
        {
            var ba = new BitArray(new[] { intToCheck });

            var maxCount = 0;
            var startGapIndex = -1;

            for (var i = 0; i < ba.Length; i++)
            {
                if (!ba[i]) continue;

                if (startGapIndex != -1)
                {
                    var count = i - startGapIndex - 1;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                startGapIndex = i;
            }
            return maxCount;
        }
    }
}
