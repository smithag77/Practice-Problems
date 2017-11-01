using Codility._4;
using NUnit.Framework;

namespace CodilityTests._4
{
    public class MaxCounters_should_
    {
        private MaxCounters _mc;
        private int _N = 5;
        [SetUp]
        public void SetUp()
        {
            _mc = new MaxCounters();
        }

        [Test]
        public void increase_counter_when_K_lt_N()
        {
            var A = new[] {1, 2, 3, 4, 5};
            var expectedCounters = new[] {1, 1, 1, 1, 1};
            var actualCounters = _mc.GetCounters(_N, A);

            CollectionAssert.AreEqual(expectedCounters, actualCounters);
        }

        [Test]
        public void not_increase_counter_when_K_lt_0()
        {
            var A = new[] {1, -1};
            var expectedCounters = new[] { 1, 0, 0, 0, 0 };
            var actualCounters = _mc.GetCounters(_N, A);

            CollectionAssert.AreEqual(expectedCounters, actualCounters);
        }

        [Test]
        public void max_counters_when_K_eq_Nplus1()
        {
            var A = new[] { 3, 4, 4, 6};
            var expectedCounters = new[] {2, 2, 2, 2, 2};
            var actualCounters = _mc.GetCounters(_N, A);

            CollectionAssert.AreEqual(expectedCounters, actualCounters);
        }

        [Test]
        public void do_stuff()
        {
            var A = new[] {3, 4, 4, 6, 1, 4, 4, 7};
            var expectedCounters = new[] {3, 2, 2, 4, 2};
            var actualCounters = _mc.GetCounters(_N, A);

            CollectionAssert.AreEqual(expectedCounters, actualCounters);

        }
    }
}
