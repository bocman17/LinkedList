using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class HelperFuncs<T>
    {
        public static void PrintRecursive(Node<T>? head)
        {
            if (head == null)
            {
                return;
            }
            if (head.Next != null)
            {
                Console.Write(head.Value + " -> ");
            }
            else
            {
                Console.Write(head.Value);
            }
            PrintRecursive(head.Next);
        }

        public static List<T> Values(Node<T>? head)
        {
            List<T> values = new List<T>();
            if (head == null)
            {
                return values;
            }
            HelperValues(head, values);
            return values;
        }

        private static void HelperValues(Node<T>? head, List<T> values)
        {
            if (head == null)
            {
                return;
            }
            if (head.Value != null)
            {
                values.Add(head.Value);
            }
            HelperValues(head.Next, values);
        }
    }
}
