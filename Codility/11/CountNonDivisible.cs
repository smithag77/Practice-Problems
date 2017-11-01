using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._11
{
    class CountNonDivisible
    {
        public int[] solution(int[] A)
        {
            var nIntCount = A.Length; 
            var nMaxInt = nIntCount + nIntCount; 
            var anIntCounts = new int[nMaxInt + 1]; 
            var anDivisorCounts = new int[nMaxInt + 1]; 
            var anNotDivCounts = new int[nIntCount];
            foreach (var a in A)
            {
                anIntCounts[a]++;
            }
            for (var i = 0; i <= nMaxInt; i++)
            {
                if (anIntCounts[i] > 0)
                {
                    for (var im = i; im <= nMaxInt; im += i)
                    {
                        anDivisorCounts[im] += anIntCounts[i];
                    }
                }
            }

            for (var i = 0; i < nIntCount; i++)
            {
                anNotDivCounts[i] = nIntCount - anDivisorCounts[A[i]];
            }

            return anNotDivCounts;
        }


        private int[] solutionWithDocs(int[] A) // time complexity O(N*log(N)), space complexity O(N)
        {
            var nIntCount = A.Length; // = N in problem statement
            var nMaxInt = nIntCount + nIntCount; // max possible input int; problem statement specifies this
            var anIntCounts = new int[nMaxInt + 1]; // array of counters for all possible input ints
            // (plus a never-used counter for 0)
            var anDivisorCounts = new int[nMaxInt + 1]; // array of counters for counts of divisors
            var anNotDivCounts = new int[nIntCount]; // to be returned, length and order same as input array A
            foreach (var a in A) // transform input array A into counts of its ints
                anIntCounts[a]++;
            for (var i = 0; i <= nMaxInt; i++) // cycling thru counter array instead of input array A speeds things up!
                if (anIntCounts[i] > 0) // skip this iteration if input array A didn't have this int
                    for (var im = i; im <= nMaxInt; im += i) // mark multiples (they're divisable by this int, of course)
                        // since we're in the Sieve of Eratosthenes lesson
                        anDivisorCounts[im] += anIntCounts[i]; // mark by storing input int counts
            // (some counts will never be read)
            for (var i = 0; i < nIntCount; i++)
                anNotDivCounts[i] = nIntCount - anDivisorCounts[A[i]]; // compute counts of non-divisors
            // (in original order of input array A)
            return anNotDivCounts;
        }
    }
}
