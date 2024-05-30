using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    public class Employee1
    {
        string name;
        int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Employee1()
        {

        }

        public Employee1(string n, int a)
        {
            this.name = n;
            this.age = a;
        }
    }
}
