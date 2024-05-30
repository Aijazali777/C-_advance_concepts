using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    class ExceptionClass
    {
        #region NullReference Exception
        int x;

        public ExceptionClass(int a)
        {
            x = a;
        }

        public int Add(ExceptionClass o)
        {
            try
            {
                return x + o.x;
            }
            catch(NullReferenceException ex_1)
            {
                Console.WriteLine("Message: " + ex_1.Message);
                Console.WriteLine("StackTrace: " + ex_1.StackTrace);
                Console.WriteLine("Target: " + ex_1.TargetSite);
                return 0;
            }
        }
        #endregion

        #region more catch blocks
        public void test()
        {
            int[] arr = new int[4];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = i;
                    Console.WriteLine("Array value {0} is at index {1}", arr[i], i);
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Array index is out of bound!");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Can not divided by zero!");
            }
            catch
            {
                Console.WriteLine("An error has been occurred");
            }
            finally
            {
                Console.WriteLine("Finally I ran!");
            }
        }
        #endregion

    /*    static void Main(string[] args)
        {
            
            /*ExceptionClass ex = new ExceptionClass(2);
              ExceptionClass ex1 = null;
              Console.WriteLine(ex.Add(ex1));
            

            ExceptionClass obj = new ExceptionClass(2);
            obj.test();
            Console.ReadLine();
        }*/
    }
}
