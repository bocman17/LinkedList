using LinkedList;

int[] arr1 = { 0, 1, 2, 3, 5, 6 };

MyLinkedList<int> list1 = new MyLinkedList<int>(arr1);
list1.AddAtIndex(4, 4);
list1.AddAtIndex(7, 15);
list1.Print();

var list = list1.ReturnValues();

foreach (var item in list)
{
    Console.WriteLine(item);
}
