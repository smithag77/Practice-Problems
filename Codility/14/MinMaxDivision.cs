using System.Linq;

namespace Codility._14
{
    public class MinMaxDivision
    {
        public int solution(int K, int M, int[] A)
        {
            long sumLowerBound = A.Max();
            long sumUpperBound = A.Sum();

            long result = 0;
            // binary search in the large sums testing for the validity of the solution
            while (sumLowerBound <= sumUpperBound)
            {
                var midVal = (sumLowerBound + sumUpperBound) / 2;
                var isValid = IsValidSolution(A, midVal, K);

                if (isValid)
                {
                    sumUpperBound = midVal - 1;
                    result = midVal;
                }
                else
                {
                    sumLowerBound = midVal + 1;
                }
            }

            return (int)result;
        }

        private static bool IsValidSolution(int[] A, long M, int K)
        {
            var partialSum = A[0];
            var intervals = 0;
            for (var i = 1; i < A.Length; i++)
            {
                if (partialSum + A[i] > M)
                {
                    partialSum = A[i];
                    intervals++;
                }
                else
                {
                    partialSum += A[i];
                }

                if (intervals >= K)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
