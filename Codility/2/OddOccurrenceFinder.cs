using System.Linq;

namespace Codility._2
{
    class OddOccurrenceFinder
    {
        public int FindOddOccurrence(int[] A)
        {
            return A.Aggregate(0, (a, b) => a ^ b);
        }
    }
}
