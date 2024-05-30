using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    #region Interface
    public interface A
    {
        void Fun();
    }

    #endregion

    #region Abstract class
    abstract class B
    {
        int intvalue;
        public int IntValue
        {
            get { return intvalue; }
            set { intvalue = value; }
        }

        public B()
        {
            Console.WriteLine("I am abstract class B's constuctor!");
        }

        public abstract void Fun();
    }
    #endregion

    class C : B, A
    {
        public C()
        {
            Console.WriteLine("I am class C's constuctor! (a subclass of A and B)");
        }

        public override void Fun()
        {
            Console.WriteLine("I am Fun of C, that is declared in abstract class B");
        }

      /*  static void Main(string[] args)
        {
            C c = new C();
            c.Fun();
            Console.ReadLine();
        }*/
    }
}
