using System;
using Codility._3;
using NUnit.Framework;

namespace CodilityTests._3
{
    public class ArrayRotater_should
    {
        [Test]
        public void rotate_array_by_1()
        {
            var rotater = new ArrayRotater();
            var inputArray = new [] {3, 8, 9, 7, 6};
            var expectedRotation = new[] {6, 3, 8, 9, 7};
            var actualRotation = rotater.Rotate(inputArray, 1);

            CollectionAssert.AreEqual(expectedRotation,actualRotation);
        }

        [Test]
        public void rotate_array_by_N()
        {
            var rotater = new ArrayRotater();
            var inputArray = new[] { 3, 8, 9, 7, 6 };
            var expectedRotation = new[] { 9, 7, 6, 3, 8 };
            var actualRotation = rotater.Rotate(inputArray, 3);

            CollectionAssert.AreEqual(expectedRotation, actualRotation);
        }
    }
}
