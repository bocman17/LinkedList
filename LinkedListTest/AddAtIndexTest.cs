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
    public class AddAtIndexTest
    {
        [Test]
        public void AddAtIndexHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddAtIndex(0, 0);
            Assert.That(list.Head!.Value, Is.EqualTo(0));
        }

        [Test]
        public void AddAtIndexIsLargerThanListCountTest()
        {
            int[] arr = { 1, 2, 3 };
            MyLinkedList<int> list = new MyLinkedList<int>(arr);
            list.AddAtIndex(4, 10);
            var result = list.ReturnValues();

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, result);
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void AddAtIndexMultiTest<T>(T[] arr, int index, T val, T[] expected)
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            list.AddAtIndex(val, index);
            var result = list.ReturnValues();

            CollectionAssert.AreEqual(expected, result);
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(
                new char[] { 'B', 'C', 'D', 'E', 'F' },
                0,
                'A',
                new char[] { 'A', 'B', 'C', 'D', 'E', 'F' }
                );
            yield return new TestCaseData(
                new char[] { 'A', 'B', 'C', 'D', 'E' },
                5,
                'F',
                new char[] { 'A', 'B', 'C', 'D', 'E', 'F' }
                );
            yield return new TestCaseData(
                new char[] { 'A', 'B', 'D', 'E', 'F' },
                2,
                'C',
                new char[] { 'A', 'B', 'C', 'D', 'E', 'F' }
                );
            yield return new TestCaseData(
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                0,
                0,
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
                );
            yield return new TestCaseData(
                new int[] { 0, 1, 2, 3, 4, 5, 6 },
                7,
                7,
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
                );
            yield return new TestCaseData(
                new int[] { 0, 1, 2, 3, 5, 6, 7 },
                4,
                4,
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
                );
            yield return new TestCaseData(
                new string[] { "Damien", "Dominic", "David" },
                0,
                "Daniel",
                new string[] { "Daniel", "Damien", "Dominic", "David" }
                );
            yield return new TestCaseData(
                new string[] { "Daniel", "Damien", "Dominic" },
                3,
                "David",
                new string[] { "Daniel", "Damien", "Dominic", "David" }
                );
            yield return new TestCaseData(
                new string[] { "Daniel", "Damien", "David" },
                2,
                "Dominic",
                new string[] { "Daniel", "Damien", "Dominic", "David" }
                );

        }
    }
}
