using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._3
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            int distance = Y - X;
            int div = (distance / D);
            int mod = (distance % D);
            if (mod != 0)
            {
                return div + 1;
            }
            return div;
        }
    }
}
