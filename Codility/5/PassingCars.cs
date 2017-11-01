namespace Codility._5
{
    public class PassingCars
    {
        public int CountPassingCars(int[] A)
        {
            var eastCount = 0;
            var passingPairs = 0;

            foreach (var i in A)
            {
                if (i == 1)
                {
                    passingPairs += eastCount;
                }
                else eastCount++;
            }

            if (passingPairs > 1e9 || passingPairs < 0)
            {
                return -1;
            }
            return passingPairs;
        }
    }
}
