using System.Linq;

namespace Codility._13
{
    public class Ladder
    {
        public int[] solution(int[] A, int[] B)
        {
            var maxLadderSize = A.Max();

            var fibo = BuildFiboSequence(maxLadderSize + 2);
            var result = new int[A.Length];

            for (var i = 0; i < A.Length; i++)
            {
                var positionResult = fibo[A[i]];

                result[i] = (int)(positionResult & (ulong)((1 << B[i]) - 1));
            }

            return result;
        }

        public ulong[] BuildFiboSequence(int ladderSize)
        {
            var fibo = new ulong[ladderSize];

            fibo[0] = 1;
            fibo[1] = 1;

            for (var i = 2; i < ladderSize; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            return fibo;
        }
    }
}
