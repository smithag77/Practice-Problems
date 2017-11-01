using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility._4;

namespace CodilityTests._4
{
    public class PermMissingElemFinder_should_
    {
        [Test]
        public void find_missing_int()
        {
            var inputArray = new [] {2, 3, 1, 5};
            var pmef = new PermMissingElemFinder();
            var expectedInt = 4;
            var actualInt = pmef.FindMissingInt(inputArray);

            Assert.AreEqual(expectedInt, actualInt);
        }
    }
}
