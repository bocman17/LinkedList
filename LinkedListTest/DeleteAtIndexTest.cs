using LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    [TestFixture]
    public class DeleteAtIndexTest
    {
        [Test]
        public void DeleteAtIndexHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteAtIndex(0));
        }

        [Test]
        public void DeleteAtIndexIndexIsOutOfRangeNullTest()
        {
            int[] arr = { 1, 2, 3 };
            MyLinkedList<int> list = new MyLinkedList<int>();

            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteAtIndex(3));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void DeleteAtIndexMultiTest<T>(T[] arr, int index, T[] expected)
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            list.DeleteAtIndex(index);
            var result = list.ReturnValues();

            CollectionAssert.AreEqual(expected, result);
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(
                new char[] { 'A', 'B', 'C', 'C', 'D', 'E', 'F' },
                3,
                new char[] { 'A', 'B', 'C', 'D', 'E', 'F' }
                );
            yield return new TestCaseData(
                new int[] { 0, 1, 2, 3, 4, 5, 6, 6, 7 },
                7,
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
                );
            yield return new TestCaseData(
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 7 },
                8,
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
                );
            yield return new TestCaseData(
                new string[] { "Daniel", "Daniel", "Damien", "Dominic", "David" },
                1,
                new string[] { "Daniel", "Damien", "Dominic", "David" }
                );
        }
    }
}
