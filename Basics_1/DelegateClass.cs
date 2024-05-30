using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    #region Delegates
    public delegate void TestDelegate();
    public delegate void TestDelegateWithParams(string msg);

    public class DelegateClass
    {
        public static void ExecuteDelegate1(TestDelegate del)
        {
            del();
        }

        public static void ExecuteDelegate2(TestDelegateWithParams del)
        {
            del("Hello");
        }
    }
    #endregion

    class DelegateDemo
    {
        #region Methods that assigned to different delegats
        private static void print1()
        {
            Console.WriteLine("Method1");
        }

        private static void print2(string msg)
        {
            Console.WriteLine(msg+" Method2");
        }

        public static string GetMessage1()
        {
            return "Message1";
        }

        public static string GetMessage2(int num)
        {
            return ("Message " + num);
        }

        public static void GetNumber1()
        {
            Console.WriteLine("I am Action delegate!");
        }

        public static void GetNumber2(int a)
        {
            Console.WriteLine("I am Action delegate!");
        }
        #endregion

        #region Events
        public delegate string eventDelegate();
        event eventDelegate myEvent;

        public DelegateDemo()
        {
            this.myEvent = EventExample;
        }

        private string EventExample()
        {
            return "Event";
        }
        #endregion

        #region Main Method
        /*
        static void Main(string[] args)
        {

            Console.WriteLine("Delegates");
            TestDelegate del1 = print1;
            TestDelegateWithParams del2 = print2;
            DelegateClass.ExecuteDelegate1(del1);
            DelegateClass.ExecuteDelegate2(del2);

            DelegateDemo d = new DelegateDemo();
            Console.WriteLine(d.myEvent());

        #region Func<> delegate
        // Func delegate
            Func<string> fun1 = GetMessage1;
            Console.WriteLine(fun1());

        // Func delegate with parameters
            Func<int, string> fun2 = GetMessage2;
            Console.WriteLine(fun2(5));
        #endregion

        #region Action<> delegate
            Action<int> act = GetNumber2;
            act(2);
        #endregion

            Console.ReadLine();
        }*/
        #endregion
    }
}
