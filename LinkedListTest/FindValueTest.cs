using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    [TestFixture]
    public class FindValueTest
    {
        [Test]
        public void FindValueIterativeHeadIsNullTest()
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            var result = FindValue<int>.Iterative(myLinkedList.Head, 0);
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void FindValueIterativeMultipleTest<T>(T[] arr, T target, bool expected)
        {
            MyLinkedList<T> myLinkedList = new MyLinkedList<T>(arr);
            var result = FindValue<T>.Iterative(myLinkedList.Head, target);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FindValueRecursiveHeadIsNullTest()
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            var result = FindValue<int>.Recursive(myLinkedList.Head, 0);
            Assert.That(result, Is.False);
        }

        [Test]
        [TestCaseSource(nameof(MyTestCases))]
        public void FindValueRecursiveMultipleTest<T>(T[] arr, T target, bool expected)
        {
            MyLinkedList<T> myLinkedList = new MyLinkedList<T>(arr);
            var result = FindValue<T>.Recursive(myLinkedList.Head, target);
            Assert.That(result, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> MyTestCases()
        {
            yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5, 6 }, 5, true);
            yield return new TestCaseData(new int[] { -5, 58, 32, 24, -154 }, 154, false);
            yield return new TestCaseData(new char[] { 'a', 'g', 'o', 'p', 'e', 'g' }, 'g', true);
            yield return new TestCaseData(new string[] { "Jimmy", "Anne", "Jack", "Janice" }, "Mary", false);

        }
    }
}
