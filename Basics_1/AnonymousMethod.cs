using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    class AnonymousMethod
    {
        public delegate string del(int a);
       /* static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Method Example:\n");

            #region Anonymous method
            del method1 = delegate (int x)
            {
                Console.WriteLine("I am Anonymous Method "+x);
                return "AnonymousMethod";
            };
            string anonymousMeth = method1(3);
            Console.WriteLine(anonymousMeth);
            #endregion

            #region Lambda expression
            del method = (x) =>
            {
                return "LambdaExpression";
            };
            string lambdaExp = method.Invoke(5);
            Console.WriteLine(lambdaExp);
            Console.ReadLine();
            #endregion
        }*/
    }
}
