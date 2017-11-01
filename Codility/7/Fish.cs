using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._7
{
//The solution takes the first fish and pushes into the stack(as this is empty).
//Then with the second and following fishes, it checks three possibilities:
//While the stack is not empty, if the direction of the fish is 1 and the direction of the last fish in the stack is 0 (aliveFishes.Peek()) and the size of the fish is bigger that the last fish in the stack, the we pop(delete) the last fish in the stack(as it has been eaten).
//If the stack is not empty, and the direction of the fish and the last fish of the stack is not the right one(gets to live) we push the fish into the stack.
//if above condition doesn't occur, so the stack is empty, we push the fish (it won't be eaten yet).
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            Stack<int> aliveFishes = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (aliveFishes.Count == 0)
                {
                    aliveFishes.Push(i);
                }
                else
                {
                    while (aliveFishes.Count != 0
                           && B[i] - B[aliveFishes.Peek()] == -1
                           && A[aliveFishes.Peek()] < A[i])
                    { aliveFishes.Pop(); }

                    if (aliveFishes.Count != 0)
                    { if (B[i] - B[aliveFishes.Peek()] != -1) aliveFishes.Push(i); }

                    else { aliveFishes.Push(i); }
                }
            }
            return aliveFishes.Count;
        }
    }
}
