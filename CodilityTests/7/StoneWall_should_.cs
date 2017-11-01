using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility._7;
using NUnit.Framework;

namespace CodilityTests._7
{
    public class StoneWall_should_
    {
        [Test]
        public void get_stones()
        {
            var sw = new StoneWall();
            var H = new[] {8, 8, 5, 7, 9, 8, 7, 4, 8};
            Assert.AreEqual(7, sw.solution(H));
        }
    }
}
