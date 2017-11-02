namespace Codility._12
{
    public class ChocolatesByNumbers
    {
        public int solution(int N, int M)
        {
            return N / FindGCDRecursive(N, M);
        }

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
            return N / FindGCDRecursive(N, M);
        }
    }
}
