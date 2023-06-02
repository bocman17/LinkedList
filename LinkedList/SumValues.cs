using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class SumValues<T> where T : struct, 
        IComparable<T>, IEquatable<T>, IFormattable, IConvertible, IComparable
    {
        public static dynamic ReturnSumValues(Node<T>? head)
        {
            if (head is null)
            {
                return 0;
            }
            dynamic sum = 0;
            var current = head;
            while (current is not null)
            {
                sum += current.Value;
                current = current.Next;
            }
            return sum;
        }

        public static dynamic ReturnSumValuesRecursive(Node<T>? head)
        {
            if (head is null)
            {
                return 0;
            }
            return head.Value + ReturnSumValuesRecursive(head.Next);
        }
    }
}
