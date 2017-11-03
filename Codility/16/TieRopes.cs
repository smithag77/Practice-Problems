using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._16
{
    public class TieRopes
    {
        public int solution(int K, int[] A)
        {
            var result = 0;
            var length = 0;

            foreach (var rope in A)
            {
                length += rope;

                if (length >= K)
                {
                    result++;
                    length = 0;
                }
            }

            return result;
        }
    }
}
