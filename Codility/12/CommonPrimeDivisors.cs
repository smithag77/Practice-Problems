namespace Codility._12
{
    class CommonPrimeDivisors
    {
        public int solution(int[] A, int[] B)
        {
            var counter = 0;

            for (var i = 0; i < A.Length; i++)
            {
                if (CheckCommonPrimeDivisors(A[i], B[i]))
                {
                    counter++;
                }
            }

            return counter;
        }

        private bool CheckCommonPrimeDivisors(int a, int b)
        {
            var ab_gcd = Gcd(a, b);

            while (a != 1)
            {
                var a_gcd = Gcd(a, ab_gcd);
                if (a_gcd == 1)
                {
                    break;
                }

                a /= a_gcd;
            }

            if (a != 1)
            {
                return false;
            }

            while (b != 1)
            {
                var b_gcd = Gcd(b, ab_gcd);

                if (b_gcd == 1)
                {
                    break;
                }

                b /= b_gcd;
            }

            if (b != 1)
            {
                return false;
            }

            return true;
        }

        private int Gcd(int a, int b)
        {
            if (a % b == 0)
            {
                return b; ;
            }
            return Gcd(b, a % b);
        }
    }
}
