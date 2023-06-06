using LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedListTest.ReverseListTest;

namespace LinkedListTest
{
    [TestFixture]
    public class ZipperListTest
    {
        [Test]
        public void ZipperListIterativeBothHeadsAreNullTest()
        {
            MyLinkedList<int> list1 = new MyLinkedList<int>();
            MyLinkedList<int> list2 = new MyLinkedList<int>();

            var result = ZipperList<int>.Iterative(list1.Head, list2.Head);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ZipperListIterativeHead1IsNullTest()
        {
            int[] arr = { 1, 2, 3 };
            MyLinkedList<int> list1 = new MyLinkedList<int>(arr);
            MyLinkedList<int> list2 = new MyLinkedList<int>();

            var head = ZipperList<int>.Iterative(list1.Head, list2.Head);
            MyLinkedList<int> resultList = new MyLinkedList<int>(head);
            var result = resultList.ReturnValues();

            CollectionAssert.AreEqual(result, arr);
        }

        [Test]
        public void ZipperListIterativeHead2IsNullTest()
        {
            int[] arr = { 1, 2, 3 };
            MyLinkedList<int> list1 = new MyLinkedList<int>();
            MyLinkedList<int> list2 = new MyLinkedList<int>(arr);

            var head = ZipperList<int>.Iterative(list1.Head, list2.Head);
            MyLinkedList<int> resultList = new MyLinkedList<int>(head);
            var result = resultList.ReturnValues();

            CollectionAssert.AreEqual(result, arr);
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void ZipperListIterativeMultiTest<T>(T[] arr1, T[] arr2, T[] expected)
        {
            MyLinkedList<T> list1 = new MyLinkedList<T>(arr1);
            MyLinkedList<T> list2 = new MyLinkedList<T>(arr2);

            var head = ZipperList<T>.Iterative(list1.Head, list2.Head);
            MyLinkedList<T> resultList = new MyLinkedList<T>(head);
            var result = resultList.ReturnValues();

            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void ZipperListRecursiveBothHeadsAreNullTest()
        {
            MyLinkedList<int> list1 = new MyLinkedList<int>();
            MyLinkedList<int> list2 = new MyLinkedList<int>();

            var result = ZipperList<int>.Recursive(list1.Head, list2.Head);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void ZipperListRecursiveHead1IsNullTest()
        {
            int[] arr = { 1, 2, 3 };
            MyLinkedList<int> list1 = new MyLinkedList<int>(arr);
            MyLinkedList<int> list2 = new MyLinkedList<int>();

            var head = ZipperList<int>.Recursive(list1.Head, list2.Head);
            MyLinkedList<int> resultList = new MyLinkedList<int>(head);
            var result = resultList.ReturnValues();

            CollectionAssert.AreEqual(result, arr);
        }

        [Test]
        public void ZipperListRecursiveHead2IsNullTest()
        {
            int[] arr = { 1, 2, 3 };
            MyLinkedList<int> list1 = new MyLinkedList<int>();
            MyLinkedList<int> list2 = new MyLinkedList<int>(arr);

            var head = ZipperList<int>.Recursive(list1.Head, list2.Head);
            MyLinkedList<int> resultList = new MyLinkedList<int>(head);
            var result = resultList.ReturnValues();

            CollectionAssert.AreEqual(result, arr);
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void ZipperListRecursiveMultiTest<T>(T[] arr1, T[] arr2, T[] expected)
        {
            MyLinkedList<T> list1 = new MyLinkedList<T>(arr1);
            MyLinkedList<T> list2 = new MyLinkedList<T>(arr2);

            var head = ZipperList<T>.Recursive(list1.Head, list2.Head);
            MyLinkedList<T> resultList = new MyLinkedList<T>(head);
            var result = resultList.ReturnValues();

            CollectionAssert.AreEqual(result, expected);
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(
                new int[] { 1, 3, 5 },
                new int[] { 2, 4, 6 },
                new int[] { 1, 2, 3, 4, 5, 6 });
            yield return new TestCaseData(
                new int[] { 1, 3, 5, 7, 8, 9 },
                new int[] { 2, 4, 6 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            yield return new TestCaseData(
                new int[] { 1, 3, 5 },
                new int[] { 2, 4, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            yield return new TestCaseData(
                new char[] { 'a', 'c', 'e' },
                new char[] { 'b', 'd', 'f' },
                new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
            yield return new TestCaseData(
                new char[] { 'a', 'c', 'e', 'g', 'h', 'i' },
                new char[] { 'b', 'd', 'f' },
                new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' });
            yield return new TestCaseData(
                new char[] { 'a', 'c', 'e' },
                new char[] { 'b', 'd', 'f', 'g', 'h', 'i' },
                new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' });
            yield return new TestCaseData(
                new string[] { "Daniel", "Damien", "David" },
                new string[] { "Diana", "Dita", "Dominika" },
                new string[] { "Daniel", "Diana", "Damien", "Dita", "David", "Dominika" });
            yield return new TestCaseData(
                new string[] { "Daniel", "Damien", "David", "Dalibor", "Don", "Dick" },
                new string[] { "Diana", "Dita", "Dominika" },
                new string[] { "Daniel", "Diana", "Damien", "Dita", "David", "Dominika", "Dalibor", "Don", "Dick" });
            yield return new TestCaseData(
                new string[] { "Daniel", "Damien", "David" },
                new string[] { "Diana", "Dita", "Dominika", "Duna", "Dakota", "Damari" },
                new string[] { "Daniel", "Diana", "Damien", "Dita", "David", "Dominika", "Duna", "Dakota", "Damari" });
        }
        //private static IEnumerable<TestCaseData> MyTestCases()
        //{
        //    yield return new TestCaseData(new TestData<int>(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 }));
        //    yield return new TestCaseData(new TestData<char>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f' }));
        //    yield return new TestCaseData(new TestData<string>(new string[] { "Daniel", "Dominic", "David", "Damien" }));
        //    yield return new TestCaseData(new TestData<double>(new double[] { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7 }));
        //}

        //public class TestData<T>
        //{
        //    public TestData(T[] array)
        //    {
        //        Array = array;
        //    }

        //    public T[] Array { get; }
        //}
    }
}
