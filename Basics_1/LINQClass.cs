using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_1
{
    class EmployeeOfTrafix
    {
        string firstName;
        string lastName;
        int id;
        int age;
        string department;

        public string FName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        List<EmployeeOfTrafix> empList = new List<EmployeeOfTrafix>();

        #region Simple Loop Over Employee
        public void displayByLoop()
        {
            Console.WriteLine("Below are the employee's records using loop (without use of LINQ):\n");
            empList = GetData();
            foreach (EmployeeOfTrafix emp in empList)
                Console.WriteLine($"\tId: {emp.Id}. FirstName: {emp.FName}, LastName: {emp.LName}, Age: {emp.Age}, Department: {emp.Department}\n");
            Console.ReadKey();
        }
        #endregion

        #region Using LINQ to dislpay Employee records
        public void displayByLINQ()
        {
            Console.WriteLine("Below are the employee's records by using LINQ:\n");
            empList = GetData();
            empList.ForEach(emp => Console.WriteLine($"\tId: {emp.Id}. FirstName: {emp.FName}, LastName: {emp.LName}, Age: {emp.Age}, Department: {emp.Department}\n"));
            Console.ReadKey();
        }

        #endregion

        #region Filter operation using Method Syntax
        public void FilterOperation()
        {
            Console.WriteLine("Below are the employee's records Filter operation using Method Syntax in LINQ:\n");
            empList = GetData();
            empList = empList.Where(emp => emp.Department == "Dev" && emp.Age > 25).ToList();
            empList.ForEach(emp => Console.WriteLine($"\tId: {emp.Id}. FirstName: {emp.FName}, LastName: {emp.LName}, Age: {emp.Age}, Department: {emp.Department}\n"));
        }
        #endregion

        #region Filter operation using Query Syntax
        public void Filter()
        {
            Console.WriteLine("Below are the employee's records Filter operation using Query Syntax in LINQ:\n");
            empList = GetData();
            var query = (from rec in empList
                         where rec.Department == "Dev"
                         select rec).ToList();
            query.ForEach(emp => Console.WriteLine($"\tId: {emp.Id}. FirstName: {emp.FName}, LastName: {emp.LName}, Age: {emp.Age}, Department: {emp.Department}\n"));
        }
        #endregion

        #region Sorting operation
        public void SortOperation()
        {
            Console.WriteLine("Below are the employee's records using Sorting operation LINQ:\n");
            empList = GetData();
            empList = empList.OrderBy(emp => emp.Department).ThenBy(emp => emp.FName).ToList();
            empList.ForEach(emp => Console.WriteLine($"\tId: {emp.Id}. FirstName: {emp.FName}, LastName: {emp.LName}, Age: {emp.Age}, Department: {emp.Department}\n"));
        }
        #endregion

        #region Projection operation
        public void ProjectionOperation()
        {
            Console.WriteLine("Below are the employee's FirstName using Projection operation LINQ:\n");
            empList = GetData();
            List<string> empFirstNames = empList.Select(emp => emp.firstName).ToList();
            foreach (string item in empFirstNames)
                Console.WriteLine(item);
        }
        #endregion

        #region Aggregation operation
        public void Aggregation()
        {
            Console.WriteLine("Below are the employee's Id sum using Aggregation operation LINQ:\n");
            empList = GetData();
            int idSum  = empList.Sum(emp => emp.id);
            Console.WriteLine("Sum of all employee's id is "+idSum);
        }
        #endregion

        public void display()
        {
            Console.WriteLine("Below are the employee's records by LINQ:\n");
            empList = GetData();

            // EmployeeOfTrafix emp = empList.Single(employee => employee.Department == "Dev"); //Only use Single or SingleDefault when there is only one record of that condition.

            #region Quantifier Operaion
            // EmployeeOfTrafix emp = empList.FirstOrDefault(employee => employee.Department == "Dev" && employee.Age == 25);
            // EmployeeOfTrafix emp = empList.LastOrDefault(employee => employee.Department == "Dev");
            #endregion

            #region Partitioning
            // empList = empList.Skip(2).ToList();
            // empList = empList.Take(2).ToList();
            #endregion

            empList.ForEach(emp => Console.WriteLine($"\tId: {emp.Id}. FirstName: {emp.FName}, LastName: {emp.LName}, Age: {emp.Age}, Department: {emp.Department}\n"));
            Console.ReadKey();
        }

        public List<EmployeeOfTrafix> GetData()
        {
            return new List<EmployeeOfTrafix>
            {
                new EmployeeOfTrafix { FName = "Aijaz", LName = "Ali", Id = 1, Age = 26, Department = "Dev" },
                new EmployeeOfTrafix { FName = "Faraz", LName = "Ahmed", Id = 2, Age = 24, Department = "Dev" },
                new EmployeeOfTrafix { FName = "Ali", LName = "Taha", Id = 3, Age = 28, Department = "QA" },
                new EmployeeOfTrafix { FName = "Ali", LName = "Saeed", Id = 3, Age = 34, Department = "Dev" },
                new EmployeeOfTrafix { FName = "Aijaz", LName = "Ali", Id = 1, Age = 23, Department = "HR" },
                new EmployeeOfTrafix { FName = "Saad", LName = "Khan", Id = 4, Age = 30, Department = "HR" }
            };
        }

   /*     static void Main(string[] args)
        {
            EmployeeOfTrafix objEmployee = new EmployeeOfTrafix();
            //objEmployee.displayByLoop();
            // objEmployee.displayByLINQ();
            // objEmployee.FilterOperation();
            objEmployee.SortOperation();
            objEmployee.ProjectionOperation();
            objEmployee.Aggregation();
            objEmployee.Filter();
            // objEmployee.display();
            Console.ReadKey();
        }*/
    }
}
