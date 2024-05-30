using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
    }

    class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
    }

    class TestJoin
    {

       /* static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Aijaz", AddressId = 01 },
                new Student(){ Id = 2, Name = "Ali", AddressId = 02 },
                new Student(){ Id = 3, Name = "Fahad", AddressId = 01 },
                new Student(){ Id = 4, Name = "Saad", AddressId = 03 }
            };

            List<Address> addresses = new List<Address>()
            {
                new Address(){ Id = 01, AddressLine = "Line 1"},
                new Address(){ Id = 02, AddressLine = "Line 2"},
                new Address(){ Id = 03, AddressLine= "Line 4"},
                new Address(){ Id = 04, AddressLine= "Line 3"},
            };


            #region GroupJoin
            var ms = addresses.GroupJoin(students, address => address.Id, std => std.AddressId,
                (address, std) => new
                {
                    address,
                    std
                }
           );

           
            Console.WriteLine("Group Join:\n");

            foreach(var item in ms)
            {
                Console.WriteLine("{0}: ", item.address.AddressLine);
                foreach(var s in item.std)
                    Console.WriteLine("{0}: ", s.Name);
            }

            #endregion

            #region InnerJoin
            Console.WriteLine("\nInner Join:\n");
            var query = (from student in students
                         join address in addresses
                         on student.AddressId equals address.Id
                         select new
                         {
                             studentName = student.Name,
                             studentAddress = address.AddressLine
                         }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine("{0},{1}", item.studentName, item.studentAddress);
            }

            #endregion
            Console.ReadKey();
        }*/
    }
}
