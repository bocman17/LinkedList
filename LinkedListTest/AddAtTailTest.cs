using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    [TestFixture]
    public class AddAtTailTest
    {
        [Test]
        public void AddAtTailHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddAtTail(0);

            var result = list.ReturnValues();
            CollectionAssert.AreEqual(result, new int[] { 0 });
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void AddAtHeadMultiTest<T>(T[] arr, T tail, T[] expected)
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            list.AddAtTail(tail);

            var result = list.ReturnValues();
            CollectionAssert.AreEqual(result, expected);
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(
                new char[] { 'A', 'B', 'C', 'D', 'E' },
                'F',
                new char[] { 'A', 'B', 'C', 'D', 'E', 'F' }
                );
            yield return new TestCaseData(
                new int[] { 0, 1, 2, 3, 4, 5, 6 },
                7,
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }
                );
            yield return new TestCaseData(
                new double[] { 1.0, 2.0, -3.5, 18.98 },
                4,
                new double[] { 1.0, 2.0, -3.5, 18.98, 4 }
                );
            yield return new TestCaseData(
                new string[] { "Daniel", "Damien", "Dominic" },
                "David",
                new string[] { "Daniel", "Damien", "Dominic", "David" }
                );
        }
    }
}
