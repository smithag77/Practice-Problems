using System.Linq;

namespace Codility._6
{
    public class Distinct
    {
        public int GetCount(int[] A)
        {
            return A.Distinct().Count();
        }
    }
}
