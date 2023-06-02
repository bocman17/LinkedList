using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T>
    {
        public Node<T>? Head { get; set; }

        public MyLinkedList(Node<T>? head = null)
        {
            Head = head;
        }

        public MyLinkedList(T[] values)
        {
            MakeLinkedListFromArray(values);
        }

        private void MakeLinkedListFromArray(T[] values)
        {
            Head = new Node<T>(values[0]);
            var current = Head;
            for (int i = 1; i < values.Length - 1; i++)
            {
                current.Next = new Node<T>(values[i]);
                current = current.Next;
            }
            current.Next = new Node<T>(values[^1]);
        }

        public List<T> ReturnValues()
        {
            List<T> values = new List<T>();

            var current = Head;
            while (current != null)
            {
                if (current.Value != null)
                {
                    values.Add(current.Value);
                }
                current = current.Next;
            }
            return values;
        }

        public void Print()
        {
            if (Head is null)
            {
                return;
            }
            var current = Head;
            while (current.Next != null)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            if (current is not null)
            {
                Console.Write(current.Value);
            }
        }
    }
}
