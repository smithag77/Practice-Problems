using Codility._6;
using NUnit.Framework;

namespace CodilityTests._6
{
    public class Distinct_should_
    {
        [Test]
        public void count_distincts()
        {
            var distinct = new Distinct();
            var A = new[] {2, 1, 1, 2, 3, 1};

            var expectedCount = 3;
            var actualCount = distinct.GetCount(A);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void handle_empty_array()
        {
            var distinct = new Distinct();
            var A = new int[0];

            var expectedCount = 0;
            var actualCount = distinct.GetCount(A);
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
