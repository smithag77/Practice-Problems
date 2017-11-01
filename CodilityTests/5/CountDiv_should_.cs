using Codility._5;
using NUnit.Framework;

namespace CodilityTests._5
{
    public class CountDiv_should_
    {
        [Test]
        public void count_divs()
        {
            var cd = new CountDiv();
            Assert.AreEqual(3, cd.solution(6,11,2));
        }
    }
}
