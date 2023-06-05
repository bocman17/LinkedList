using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class FindValue<T>
    {
        public static bool Iterative(Node<T>? head, T val)
        {
            if (head is null) return false;
            var current = head;
            while (current is not null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, val))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public static bool Recursive(Node<T>? head, T val)
        {
            if(head is null) return false;
            if (EqualityComparer<T>.Default.Equals(head.Value, val))
            {
                return true;
            }
            return Recursive(head.Next, val);
        }
    }
}
