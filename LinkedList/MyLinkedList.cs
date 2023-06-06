using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
            if (values.Length <= 0)
            {
                return;
            }
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
                values.Add(current.Value);
                current = current.Next;
            }
            return values;
        }

        public void ReverseList()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }
            Node<T>? current = Head;
            Node<T>? prev = null;

            while (current != null)
            {
                Node<T>? next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
        }

        public void AddAtHead(T val)
        {
            Node<T> first = new Node<T>(val);
            first.Next = Head;
            Head = first;
        }

        public void AddAtTail(T val)
        {
            Node<T> tail = new Node<T>(val);
            Node<T>? current = Head;
            if (current is null)
            {
                Head = tail;
                return;
            }
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = tail;
        }

        public void AddAtIndex(T val, int index)
        {
            Node<T> node = new Node<T>(val);
            var current = Head;
            Node<T>? prev = null;
            int count = 0;
            while (current != null && count < index)
            {
                count++;
                Node<T> temp = current;
                current = current.Next;
                prev = temp;
            }
            if (prev != null)
            {
                prev.Next = node;
            }
            else
            {
                Head = node;
                Head.Next = current;
            }
            node.Next = current;
        }

        public void DeleteAtIndex(int index)
        {
            var current = Head;
            Node<T>? prev = null;
            int count = 0;
            while(current != null && count < index)
            {
                count++;
                Node<T> temp = current;
                current = current.Next;
                prev = temp;
            }
            if(current is not null && count == 0)
            {
                Head = current.Next;
            }
            else if(current != null && prev != null)
            {
                prev.Next = current.Next;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range of Linked List.");
            }
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
