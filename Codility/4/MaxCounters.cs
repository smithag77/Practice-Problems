using System;

namespace Codility._4
{
    public class MaxCounters
    {
        public int[] GetCounters(int N, int[] A)
        {
            return solution(N, A);
            var counters = new int[N];
            var max = 0;

            foreach (var item in A)
            {
                if (item <= N && item >= 1)
                {
                    counters[item-1]++;
                    if (counters[item - 1] > max)
                    {
                        max = counters[item - 1];
                    }
                }

                if (item != N + 1) continue;

                for (var j = 0; j < counters.Length; j++)
                {
                    counters[j] = max;
                }
            }

            return counters;
        }

        //Exactly the same code
        public int[] solution(int N, int[] A)
        {
            var counters = new Counters(N);

            foreach (int item in A)
            {
                if (item <= N && item >= 1)
                    counters.IncreaseCounter(item);
                else if(item == N + 1)
                    counters.MaxAllCounters();
            }

            return counters.ToArray();
        }

        public class Counters
        {
            private int[] counters;
            private int greaterValueInCounter = 0;
            private int currentEquilibratedScore = 0;

            public Counters(int length)
            {
                counters = new int[length];
            }

            public void MaxAllCounters()
            {
                //We don't update the entire array anymore - that was what caused the O(N*M)
                //We just save the current equilibrated score value
                currentEquilibratedScore = greaterValueInCounter;
            }

            public void IncreaseCounter(int counterPosition)
            {
                //The counter is one-based, but our array is zero-based
                counterPosition--;

                //We need to add this "if" here because with this new solution the array
                //is not always updated, so if we detect that this position is lower than
                //the currentEquilibratedScore, we update it before any operation
                if (counters[counterPosition] < currentEquilibratedScore)
                    counters[counterPosition] = currentEquilibratedScore + 1;
                else
                    counters[counterPosition]++;

                if (counters[counterPosition] > greaterValueInCounter)
                    greaterValueInCounter = counters[counterPosition];
            }

            //The counters array is encapsuled in this class so if we provide external 
            //acess to it anyone could modify it and break the purpose of the encapsulation
            //So we just exposes a copy of it :)
            public int[] ToArray()
            {
                //Now we need to fix the unupdated values in the array
                //(the values that are less than the equilibrated score)
                for (int i = 0; i < counters.Length; i++)
                {
                    if (counters[i] < currentEquilibratedScore)
                        counters[i] = currentEquilibratedScore;
                }

                return (int[])counters.Clone();
            }
        }
    }
}
