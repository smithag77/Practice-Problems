﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility._11
{
    class CountSemiprimes
    {
        public static int[] solution(int N, int[] P, int[] Q)
        {
            var sieveInput = Enumerable.Repeat(true, N + 1).ToArray();
            var nSqrt = Math.Sqrt(N);

            // perform sieve
            sieveInput[0] = false;
            sieveInput[1] = false;
            for (var i = 2; i < nSqrt; i++)
            {
                if (sieveInput[i])
                {
                    var j = i * i;
                    while (j <= N)
                    {
                        sieveInput[j] = false;
                        j += i;
                    }
                }
            }

            // get array of primes
            var primes = new List<int>();
            for (var i = 0; i < sieveInput.Length; i++)
            {
                if (sieveInput[i])
                {
                    primes.Add(i);
                }
            }

            // calculate semiprimes
            var semiPrimes = new int[N + 1];
            for (var i = 0; i <= nSqrt; i++)
            {
                for (var j = i; j < primes.Count(); j++)
                {
                    var semiPrime = primes[i] * primes[j];
                    if (semiPrime > N)
                    {
                        break;
                    }

                    semiPrimes[semiPrime] = 1;
                }
            }

            // calculate prefix sums
            var semiPrimesCount = new int[N + 1];
            for (var i = 1; i < semiPrimesCount.Length; i++)
            {
                semiPrimesCount[i] = semiPrimesCount[i - 1] + semiPrimes[i];
            }

            //obtain result
            var result = new List<int>();
            for (var i = 0; i < P.Length; i++)
            {
                result.Add(semiPrimesCount[Q[i]] - semiPrimesCount[P[i] - 1]);
            }

            return result.ToArray();
        }
    }
}