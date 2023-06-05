using LinkedList;

Console.WriteLine("Hello");

int[] arr = { 1, 2, 3, 4, 5, 6 };
MyLinkedList<int> list = new MyLinkedList<int>(arr);
var result1 = GetNodeValue<int>.Iterative(list.Head, 5);
Console.WriteLine(result1);
var result2= GetNodeValue<int>.Recursive(list.Head, 6);
Console.WriteLine(result2);
