using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ReverseList<T>
    {
        public static Node<T>? Iterative(Node<T>? head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }
            Node<T>? current = head;
            Node<T>? prev = null;

            while (current != null)
            {
                Node<T>? next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        public static Node<T>? Recursive(Node<T>? head)
        {
            if(head == null || head.Next == null)
            { return head; }

            Node<T>? reversedList = Recursive(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return reversedList;
        }
    }
}
