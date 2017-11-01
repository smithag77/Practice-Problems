using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._12
{
    public class ChocolatesByNumbers
    {

        private static int FindGCDRecursive(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            return FindGCDRecursive(b, a % b);
        }

        public int CountChocolates(int N, int M)
        {
            var lcm = N * M / FindGCDRecursive(N, M);
            return lcm / M;
        }
    }
}
