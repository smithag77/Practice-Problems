using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._7
{
    public class StoneWall
    {
        public int solution(int[] H)
        {
            var blockCount = 0;
            var stack = new Stack<int>();
            foreach (var height in H)
            {
                while (stack.Count != 0 && stack.Peek() > height)
                {
                    stack.Pop();
                }

                if (stack.Count != 0 && stack.Peek() == height)
                {
                    //do nothing
                }
                else
                {
                    blockCount++;
                    stack.Push(height);
                }
            }

            return blockCount;
        }
    }
}
