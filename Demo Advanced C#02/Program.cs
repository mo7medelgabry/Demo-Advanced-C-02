using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo_Advanced_C_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArrayList arrayList = new ArrayList();
            //  Console.WriteLine($"Count Of Array List = {arrayList.Count} , Capacity Of Array List = {arrayList.Capacity}");
            //  arrayList.Add( 1 );
            //  arrayList.Add( 2 );
            //  Console.WriteLine($"After ADD - Count Of Array List = {arrayList.Count} , Capacity Of Array List = {arrayList.Capacity}");
            //  arrayList.AddRange( new int[] { 3,4} );

            //ArrayList arrayList = new ArrayList(5) { 1,2,3,4,5};
            // Console.WriteLine($"Count Of Array List = {arrayList.Count} , Capacity Of Array List = {arrayList.Capacity}");
            // arrayList.Add(6);
            // Console.WriteLine($"After ADD - Count Of Array List = {arrayList.Count} , Capacity Of Array List = {arrayList.Capacity}");
            // arrayList.TrimToSize();
            // Console.WriteLine($"Count Of Array List = {arrayList.Count} , Capacity Of Array List = {arrayList.Capacity}");

            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");
            //Numbers.Add( 1 );
            //Console.WriteLine($"After ADD - Count Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");
            //Numbers.AddRange(new[] { 3, 4});
            //Numbers.Add(5);
            //Numbers.Add(2);
            //Console.WriteLine($"After ADD - Count Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");
            //Numbers.TrimExcess();
            //Console.WriteLine($"After Trim  - Count Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");

            //List<int> Numbers = new List<int>(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");
            //Numbers.Add(6);
            //Console.WriteLine($"After ADD - Count Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");

            //#region List Methods

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4};
            //Console.WriteLine($"Count Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");
            //Numbers.Add(5);
            //Numbers.AddRange(new int[] { 6, 7 });
            //foreach(int item in Numbers)
            //{
            //    Console.Write(item);
            //}

            //Numbers.Insert(6, 8);
            //Console.WriteLine("\n=======================");
            //foreach (int item in Numbers)
            //{
            //    Console.Write($"{item}");
            //} 
            //Numbers.InsertRange(4, new  int[] { 9,10 });
            //Console.WriteLine("\n=======================");
            //foreach (int item in Numbers)
            //{
            //    Console.Write($"{item}");
            //}
            //Console.WriteLine($"\nCount Of List = {Numbers.Count}, Capacity Of List = {Numbers.Capacity}");

            //int index = Numbers.IndexOf(1);
            //Console.WriteLine(index);
            //int x = Numbers.LastIndexOf(1);
            //Console.WriteLine(x);


            //#endregion 

            #region Linked List
            //LinkedList<int> linkedList = new LinkedList<int>();
            //Console.WriteLine(linkedList.Count);
            //linkedList.AddFirst(1);
            //linkedList.AddLast(2);
            //LinkedListNode<int> AfterNode = linkedList.Find(1);
            //linkedList.AddAfter(AfterNode, 5);
            //LinkedListNode<int> BeforNode = linkedList.Find(2);
            //linkedList.AddBefore(BeforNode, 10);
            
            //foreach(int i in linkedList)
            //{
            //    Console.WriteLine(i);
            //} 


            #endregion 

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Peek();
            Console.WriteLine(stack.Peek()); 
            Console.WriteLine("===================");
            foreach(int i in stack)
            {

            Console.WriteLine(i); 
            }





















        }
    }
}
