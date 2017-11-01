using System.Linq;

namespace Codility._4
{
    public class PermChecker
    {
        public int CheckPerm(int[] A)
        {
            var founds = new bool[A.Length];

            foreach (var item in A)
            {
                if (item > founds.Length)
                {
                    return 0;
                }

                if (founds[item - 1])
                {
                    return 0;
                }

                founds[item - 1] = true;
            }

            return founds.AsQueryable().All(f => f) ? 1 : 0;
        }
    }
}
