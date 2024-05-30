using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    sealed class SingletonClass
    {
        private static SingletonClass instance = null;
        private static object lockObj = new object();

        private SingletonClass()
        {
            Console.WriteLine("I am private constructor");
        }

        public static SingletonClass Instance
        {
            get
            {
                lock(lockObj)
                {
                    if (instance == null)
                        instance = new SingletonClass();
                }
                return instance;
            }
        }

        public void disp(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
            SingletonClass.Instance.disp("Hello It is first time request!");
            SingletonClass anotherInstance = SingletonClass.Instance;
            anotherInstance.disp("It is second time request for instance!");
            Console.ReadLine();
        }*/
    }
}
