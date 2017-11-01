using Codility._4;
using NUnit.Framework;

namespace CodilityTests._4
{
    public class PermChecker_should_
    {
        [Test]
        public void return_1_if_permutation()
        {
            var A = new[] {4, 1, 3, 2};
            Assert.AreEqual(1, new PermChecker().CheckPerm(A));
        }

        [Test]
        public void return_0_if_item_greater_than_length()
        {
            var A = new[] {4, 1, 3};
            Assert.AreEqual(0, new PermChecker().CheckPerm(A));
        }

        [Test]
        public void return_0_if_item_occurs_more_than_once()
        {
            var A = new[] { 4, 1, 3, 4 };
            Assert.AreEqual(0, new PermChecker().CheckPerm(A));
        }
    }
}
