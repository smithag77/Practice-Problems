namespace Codility._4
{
    public class FrogRiverOne
    {
        public int GetEarliestPathTime(int[] A, int X)
        {
            var founds = new bool[X];
            var leafCount = 0;

            if (X > A.Length)
            {
                return -1;
            }

            for (var i = 0; i < A.Length; i++)
            {
                var item = A[i];
                if (item > X)
                {
                    continue;
                }
                if (!founds[item - 1])
                {
                    founds[item - 1] = true;
                    leafCount++;
                }
                if (leafCount == X)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
