using Codility._4;
using NUnit.Framework;

namespace CodilityTests._4
{
    public class MissingInteger_should_
    {
        [Test]
        public void return_1_if_all_negative()
        {
            var mi = new MissingInteger();
            var A = new[] {-1, -3};
            Assert.AreEqual(1, mi.GetFirstPositiveMissingInteger(A));
        }

        [Test]
        public void return_next_positive_int_if_sequential()
        {
            var mi = new MissingInteger();
            var A = new[] {1, 2, 3};
            Assert.AreEqual(4, mi.GetFirstPositiveMissingInteger(A));
        }

        [Test]
        public void skip_numbers_higher_than_first_found()
        {
            var mi = new MissingInteger();
            var A = new[] {1, 3, 6, 4, 1, 2};
            Assert.AreEqual(5, mi.GetFirstPositiveMissingInteger(A));
        }
    }
}
