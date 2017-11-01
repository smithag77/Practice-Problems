using System.Runtime.InteropServices;
using Codility._3;
using NUnit.Framework;

namespace CodilityTests._3
{
    public class TapeEquilibriumFinder_should_
    {
        [Test]
        public void find_least_equilibrium()
        {
            var A = new[] {3, 1, 2, 4, 3};
            var expectedEqui = 1;
            var actualEqui = new TapeEquilibriumFinder().FindEqui(A);

            Assert.AreEqual(expectedEqui, actualEqui);
        }
    }
}
