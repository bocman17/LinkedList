using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class GetNodeValue<T>
    {
        public static T Iterative(Node<T>? head, int targetIndex)
        {
            if (head == null)
            {
                throw new ArgumentOutOfRangeException("Target Index is out of bounds.");
            }
            var current = head;
            var count = 0;
            while (count < targetIndex && current != null)
            {
                count++;
                current = current.Next;
            }
            if(current is null)
            {
                throw new ArgumentOutOfRangeException("Target Index is out of bounds.");
            }
            
            return current.Value;
        }

        public static T Recursive(Node<T>? head, int targetIndex)
        {
            if (head == null)
            {
                throw new ArgumentOutOfRangeException("Target Index is out of bounds.");
            }
            if (targetIndex == 0)
            {
                return head.Value;
            }
            return Recursive(head.Next, targetIndex - 1);
        }
    }
}
