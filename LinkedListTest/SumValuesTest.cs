using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    [TestFixture]
    public class SumValuesTest
    {
        [Test]
        public void IterativeHeadIsNull()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            var result = SumValues<int>.Iterative(list.Head);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void IterativeTest<T>(T[] arr, T expected) where T : struct,
        IComparable<T>, IEquatable<T>, IFormattable, IConvertible, IComparable
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            var result = SumValues<T>.Iterative(list.Head);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void RecursiveHeadIsNull()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            var result = SumValues<int>.Recursive(list.Head);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void RecursiveTest<T>(T[] arr, T expected) where T : struct,
        IComparable<T>, IEquatable<T>, IFormattable, IConvertible, IComparable
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            var result = SumValues<T>.Recursive(list.Head);

            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new int[] { 0, -5, 6, 8, 24 }, 33);
            yield return new TestCaseData(new double[] { 2.0, -3.5, 18.98, 4 }, 21.48);
            yield return new TestCaseData(new decimal[] { 10.10m, 20.20m, 30.30m, 3.05m }, 63.65m);
            yield return new TestCaseData(new long[] {
                1000000000000L, 2000000000000L, 3000000000000L, 4000000000000L, 5000000000000 }, 15000000000000L);
        }
    }
}
