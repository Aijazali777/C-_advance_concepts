using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basics_1
{
    class MultiThreading
    {
        public static void fun1()
        {
            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Fun1: " + i);
            }
        }

        public static void fun2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Fun2: " + i);
            }
        }

        public static void fun3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Fun3: " + i);
            }
        }

      /*  static void Main(string[] args)
        {
            Thread t1 = new Thread(fun1);
            Thread t2 = new Thread(fun2);
            Thread t3 = new Thread(fun3);

            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();

          //  MultiThreading.fun1();
          //  MultiThreading.fun2();
          //  MultiThreading.fun3();
            Console.ReadKey();
        }*/
    }
}
