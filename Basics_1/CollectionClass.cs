using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    class CollectionClass
    {
     /*   public static void Main(string[] args)
        {

            #region Non-Generic Collection ArrayList
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(5);
            #endregion

            #region Generic Collection List
            List<string> list = new List<string>();
            list.Add("Aijaz");

            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Orange");

            list.AddRange(fruits);
            list.Insert(0, "Banana");
            Console.WriteLine("\nList: ");
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            foreach (string l in list)
                Console.WriteLine(l);

            #endregion

            #region Generic Collection Dictionary
            Dictionary<int, string> dictFruits = new Dictionary<int, string>();
            dictFruits.Add(1, "Apple");
            dictFruits.Add(5, "Mango");
            Console.WriteLine("\nDictionary: ");
            foreach (object item in dictFruits)
                Console.WriteLine(item);
            foreach (string item in dictFruits.Values)
                Console.WriteLine(item);
            dictFruits.Remove(5);
            if(dictFruits.ContainsKey(1))
            {
                //success
            }
            if(dictFruits.ContainsValue("Mango"))
            {
                //success
            }
            if(dictFruits.TryGetValue(1,out string val))
            {
                //success
            }
            #endregion

            #region Generic Collection Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(8);
            stack.Push(5);
            stack.Push(7);
            Console.WriteLine("\nStack: ");
            foreach (int item in stack)
                Console.WriteLine(item);
            Console.WriteLine("\nStack Peek: " + stack.Peek());
            Console.WriteLine("\nStack Max: " + stack.Max());
            Console.WriteLine("\nStack Min: " + stack.Min<int>());
            Console.WriteLine("\nStack Average: " + stack.Average());
            Console.WriteLine("\nStack Contains: " + stack.Contains(8));
            Console.WriteLine("\nStack pop: " + stack.Pop());
            
            foreach (int item in stack)
                Console.WriteLine(item);

            #endregion

            #region Generic Collection Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ahmed");
            queue.Enqueue("Ali");
            queue.Enqueue("Aijaz");
            Console.WriteLine("\nQueue: ");
            foreach (string item in queue)
                Console.WriteLine(item);
            Console.WriteLine("\nQueue Peek: " + queue.Peek());
            Console.WriteLine("\nQueue Max: " + queue.Max());
            Console.WriteLine("\nQueue Min: " + queue.Min<string>());
            Console.WriteLine("\nQueue Contains: " + queue.Contains("Ali"));
            Console.WriteLine("\nQueue pop: " + queue.Dequeue());

            foreach (string item in queue)
                Console.WriteLine(item);
            #endregion

            Console.ReadLine();
        }*/
    }
}
