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
    public class AddAtHeadTest
    {
        [Test]
        public void AddAtHeadHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddAtHead(0);

            var result = list.ReturnValues();
            CollectionAssert.AreEqual(result, new int[] { 0 });
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void AddAtHeadMultiTest<T>(T[] arr, T head, T[] expected)
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            list.AddAtHead(head);

            var result = list.ReturnValues();
            CollectionAssert.AreEqual(result, expected);
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(
                new char[] { 'B', 'C', 'D', 'E', 'F' },
                'A',
                new char[] { 'A', 'B', 'C', 'D', 'E', 'F' }
                );
            yield return new TestCaseData(
                new int[] { 1, 2, 3, 4, 5, 6, 7 },
                0,
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
                );
            yield return new TestCaseData(
                new double[] { 2.0, -3.5, 18.98, 4 },
                1.0,
                new double[] { 1.0, 2.0, -3.5, 18.98, 4 }
                );
            yield return new TestCaseData(
                new string[] { "Damien", "Dominic", "David" },
                "Daniel",
                new string[] { "Daniel", "Damien", "Dominic", "David" }
                );
        }
    }
}
