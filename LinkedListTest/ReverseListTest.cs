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
    public class ReverseListTest
    {
        [Test]
        public void ReverseListIterativeHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            var result = ReverseList<int>.Iterative(list.Head);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ReverseListIterativeHeadDotNextIsNullTest()
        {
            Node<int> head = new(1);
            MyLinkedList<int> list = new MyLinkedList<int>(head);
            var result = ReverseList<int>.Iterative(list.Head);
            Assert.That(head, Is.EqualTo(result));
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void ReverseListIterativeMultiTest<T>(TestData<T> testData)
        {
            T[] arr = testData.Array;
            MyLinkedList<T> list = new MyLinkedList<T>(arr);
            var head = ReverseList<T>.Iterative(list.Head);

            MyLinkedList<T> reversedList = new MyLinkedList<T>(head);
            var arrResult = reversedList.ReturnValues();
            CollectionAssert.AreEqual(arrResult, arr.Reverse());
        }

        [Test]
        public void ReverseListRecursiveHeadIsNullTest()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            var result = ReverseList<int>.Recursive(list.Head);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ReverseListRecursiveHeadDotNextIsNullTest()
        {
            Node<int> head = new(1);
            MyLinkedList<int> list = new MyLinkedList<int>(head);
            var result = ReverseList<int>.Recursive(list.Head);
            Assert.That(head, Is.EqualTo(result));
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new TestData<int>(new int[] { 1, 2, 3, 4, 5, 6 }));
            yield return new TestCaseData(new TestData<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f' }));
            yield return new TestCaseData(new TestData<string>(new string[] { "Daniel", "Dominic", "David", "Damien" }));
            yield return new TestCaseData(new TestData<double>(new double[] { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7 }));
        }

        public class TestData<T>
        {
            public TestData(T[] array)
            {
                Array = array;
            }

            public T[] Array { get; }
        }
    }
}
