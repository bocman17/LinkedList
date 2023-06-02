using LinkedList;
using System.Collections;

namespace LinkedListTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ReturnValuesHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            List<int> expected = new List<int>();
            var result = list.ReturnValues();

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void ReturnValuesTest<T>(T[] arr)
        {
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            var result = list.ReturnValues();

            CollectionAssert.AreEqual(arr.ToList(), result);
        }
        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new char[] { 'A', 'B', 'C', 'D', 'E', 'F' });
            yield return new TestCaseData(new int[] { 0, -5, 6, 8, 24 });
            yield return new TestCaseData(new double[] { 2.0, -3.5, 18.98, 4 });
            yield return new TestCaseData(new bool[] { true, false, true, true, false });
        }
    }
}