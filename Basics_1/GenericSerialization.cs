using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Basics_1
{
    [Serializable]
    public class Test_Generic<T>
    {
        T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }

    [Serializable]
    public class Customer
    {
        int age;
        string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    [Serializable]
    public class Employee
    {
        int age;
        string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class SerializationClass
    {
        // Path
        string path = @"D:\test\data_92.xml";

        // Serialization
        public void Serialization(DemoClass demoObject)
        {
            var serializer = new XmlSerializer(typeof(DemoClass));
            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, demoObject);
            }
        }

        // Deserialization
        public DemoClass Deserialization()
        {
            var serializer = new XmlSerializer(typeof(DemoClass));
            using (StreamReader reader = new StreamReader(path))
            {
                return (DemoClass)serializer.Deserialize(reader);
            }
        }
    }

    public class DemoClass
    {
        public List<Test_Generic<Customer>> Customers = new List<Test_Generic<Customer>>();
        public List<Test_Generic<Employee>> Employees = new List<Test_Generic<Employee>>();

       /* static void Main(string[] args)
        {
            DemoClass demoObject = new DemoClass();
            demoObject.Customers.Add(new Test_Generic<Customer> { Data = new Customer { Age = 20, Name = "Ahmed" } });
            demoObject.Customers.Add(new Test_Generic<Customer> { Data = new Customer { Age = 27, Name = "Aijaz" } });
            demoObject.Employees.Add(new Test_Generic<Employee> { Data = new Employee { Age = 40, Name = "Ali" } });

            SerializationClass serilizer = new SerializationClass();
            serilizer.Serialization(demoObject);

            DemoClass deserializedDemoList = serilizer.Deserialization();

            Console.WriteLine("Customers List: ");
            foreach (var cust in deserializedDemoList.Customers)
                Console.WriteLine("Name: {0}, Age: {1}", cust.Data.Name, cust.Data.Age);

            Console.WriteLine("\nEmployees List: ");
            foreach (var emp in deserializedDemoList.Employees)
                Console.WriteLine("Name: {0}, Age: {1}", emp.Data.Name, emp.Data.Age);
            Console.ReadLine();
        }*/
    }
}
