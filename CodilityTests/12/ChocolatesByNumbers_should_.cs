using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility._12;
using NUnit.Framework;

namespace CodilityTests._12
{
    public class ChocolatesByNumbers_should_
    {
        [Test]
        public void find_gcd()
        {
            var cbn = new ChocolatesByNumbers();
            Assert.AreEqual(5, cbn.CountChocolates(10, 4));
        }
    }
}
