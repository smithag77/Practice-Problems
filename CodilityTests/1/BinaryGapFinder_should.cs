using System.CodeDom;
using Codility._1;
using NUnit.Framework;

namespace CodilityTests._1
{
    public class BinaryGapFinder_should
    {
        [Test]
        public void convert_int_to_binary()
        {
            var expectedInt = 529;
            var expectedBinString = "1000010001";
            var bgf = new BinaryGapFinder();
            var actualBinString = bgf.GetBinaryStringForInt(expectedInt);

            Assert.AreEqual(expectedBinString, actualBinString);
        }

        [Test]
        public void get_largest_binary_gap()
        {
            var bgf = new BinaryGapFinder();
            Assert.AreEqual(0, bgf.GetLargestBinaryGap(15));
            Assert.AreEqual(4, bgf.GetLargestBinaryGap(529));
            Assert.AreEqual(1, bgf.GetLargestBinaryGap(20));
            Assert.AreEqual(5, bgf.GetLargestBinaryGap(1041));
        }
    }
}
