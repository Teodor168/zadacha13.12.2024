using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace zadacha13._12._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //da se napravi spisuchna struktura s edni i sushti elementi
            //da se vuvedechislo ot chovek i da se postavi na treto mqsto
            //AddInArrayList, AddInLinkedList, AddInStack
            Console.Write("Give number to add in third place: ");
            int number = int.Parse(Console.ReadLine());
            int[] numbers = { 10, -15, 100, 0, -200 };

            ArrayList arrayList = new ArrayList(numbers);
            AddInArrayList(arrayList, number);

            LinkedList<int> list = new LinkedList<int>(numbers);
            AddInLinkedList(list, number);

            Stack<int> stack = new Stack<int>(numbers);
            AddInStack(stack, number);

            Print(arrayList);
            PrintList(list);
            PrintStack(stack);
        }

        private static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine("stack");
            foreach (int i in stack)
            {
                Console.WriteLine(string.Join(" ", i));
            }
        }

        private static void PrintList(LinkedList<int> list)
        {
            Console.WriteLine("linked list");
            foreach (int i in list)
            {
                Console.WriteLine(string.Join(" ", i));
            }
        }

        private static void Print(ArrayList arrayList)
        {
            Console.WriteLine("array list");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }


        private static void AddInStack(Stack<int> stack, int number)
        {
            int first = stack.Pop();
            int second = stack.Pop();
            int third = stack.Pop();
            stack.Push(number);
            stack.Push(third);
            stack.Push(second);
            stack.Push(first);
        }


        private static void AddInLinkedList(LinkedList<int> list, int number)
        {
            LinkedListNode<int> node = list.First;
            node = node.Next;
            list.AddAfter(node, number);

        }

        private static void AddInArrayList(ArrayList arrayList, int number)
        {
            arrayList.Insert(2, number);
        }
    }
}