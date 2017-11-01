using Codility._4;
using NUnit.Framework;

namespace CodilityTests._4
{
    public class FrogRiverOne_should_
    {
        [Test]
        public void return_neg1_if_never_able_to_jump()
        {
            var fro = new FrogRiverOne();
            var A = new[] {1, 3, 1, 3, 1, 3, 1, 4};
            var X = 5;

            var expectedResult = -1;
            var actualResult = fro.GetEarliestPathTime(A, X);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void return_neg1_if_X_gt_length()
        {
            var fro = new FrogRiverOne();
            var A = new[] { 1, 3, 1};
            var X = 5;

            var expectedResult = -1;
            var actualResult = fro.GetEarliestPathTime(A, X);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void return_leaf_count_when_able()
        {
            var fro = new FrogRiverOne();
            var A = new[] { 1, 3, 1,4,2,3,5,4 };
            var X = 5;

            var expectedResult = 6;
            var actualResult = fro.GetEarliestPathTime(A, X);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
