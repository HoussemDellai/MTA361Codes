using System;
using System.Collections.Generic;


namespace QueueStackLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                3,2,
            }; // 3, 2

            list.Add(5); // 3, 2, 5
            list.Add(6); // 3, 2, 5, 6
            list.Remove(5); // 3, 2, 6

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(3);// 3
            queue.Enqueue(8);// 3, 8
            queue.Dequeue(); // 8

            Stack<int> stack = new Stack<int>();
            stack.Push(2); // 2
            stack.Push(7); // 7, 2
            stack.Push(8); // 8, 7, 2
            stack.Pop();   // 7, 2

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(9); // 9
            linkedList.AddAfter(linkedList.Find(9), 5); // 9, 5
            linkedList.Remove(9); // 5

            Console.ReadLine();
        }
    }
}
