using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ZipperList<T>
    {
        public static Node<T>? Iterative(Node<T>? head1, Node<T>? head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            if (head2 == null)
            {
                return head1;
            }

            Node<T> tail = head1;
            Node<T>? current1 = head1.Next;
            Node<T>? current2 = head2;
            int count = 0;

            while (current1 != null && current2 != null)
            {
                if(count % 2 == 0)
                {
                    tail.Next = current2;
                    current2 = current2.Next;
                }
                else
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                tail = tail.Next;
                count++;
            }
            if(current1 != null)
            {
                tail.Next = current1;
            }
            if(current2 != null)
            {
                tail.Next = current2;
            }

            return head1;
        }

        public static Node<T>? Recursive(Node<T>? head1, Node<T>? head2)
        {
            if (head1 == null && head2 == null)
            {
                return null;
            }
            if(head1 == null)
            {
                return head2;
            }
            if(head2 == null)
            {
                return head1;
            }

            Node<T>? next1 = head1.Next;
            Node<T>? next2 = head2.Next;

            head1.Next = head2;
            head2.Next = Recursive(next1, next2);

            return head1;
        } 
    }
}
