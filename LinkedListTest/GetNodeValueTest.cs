using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    [TestFixture]
    public class GetNodeValueTest
    {
        [Test]
        public void IterativeHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() => GetNodeValue<int>.Iterative(list.Head, 0));
        }

        [Test]
        public void IterativeIndexIsOutOfBoundsTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>(new int[] { 1, 2, 3, 4 });
            Assert.Throws<ArgumentOutOfRangeException>(() => GetNodeValue<int>.Iterative(list.Head, 4));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void IterativeIndexMultipleTest<T>(T[] arr, int index, T expected)
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            var result = GetNodeValue<T>.Iterative(list.Head, index);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void RecursiveHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() => GetNodeValue<int>.Recursive(list.Head, 0));
        }

        [Test]
        public void RecursiveIndexIsOutOfBoundsTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>(new int[] { 1, 2, 3, 4 });
            Assert.Throws<ArgumentOutOfRangeException>(() => GetNodeValue<int>.Recursive(list.Head, 4));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void RecursiveIndexMultipleTest<T>(T[] arr, int index, T expected)
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            var result = GetNodeValue<T>.Recursive(list.Head, index);
            Assert.That(result, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new int[] { -12, 20, 412, 23, 7 }, 4, 7);
            yield return new TestCaseData(new char[] { 'a', 'b', 'c', 'd', 'e', 'f' }, 0, 'a');
            yield return new TestCaseData(new string[] { "Daniel", "Dominic", "David", "Damien"}, 2, "David");
            yield return new TestCaseData(new bool[] { true, false }, 1, false);
        }

    }
}
