using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Basics_1
{
    public class Test_Generic1<T>
    {
        T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        // File Path
        string path = @"D:\test\data_97.xml";

        // Serialization
        public void serialization(List<Test_Generic<T>> T)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Test_Generic<T>>));
            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, T);
            }
        }

        // Deserialization
        List<object> deserialization()
        {
            List<object> desList = new List<object>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Test_Generic<T>>));
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    desList = (List<object>)serializer.Deserialize(reader);
                }
            }
            catch
            {
                Console.WriteLine("Deserialization failed: ");
            }

            return desList;
        }

        public void NewData(T newData)
        {
            List<Test_Generic<T>> dataDeserializedList = new List<Test_Generic<T>>();//deserialization();
            Test_Generic<T> newDataObj = new Test_Generic<T>();
            newDataObj.Data = newData;
            dataDeserializedList.Add(newDataObj);
            serialization(dataDeserializedList);
        }
    }

    class program2
    {
      /*  static void Main(string[] args)
        {
            Test_Generic<Customer> t1 = new Test_Generic<Customer>();
            Customer newCustomer = new Customer();
            newCustomer.Age = 20;
            t1.NewData(newCustomer);
            Console.WriteLine("Generic for Int: " + t1.Data);

            Test_Generic<Employee> t2 = new Test_Generic<Employee>();
            Employee newEmployee = new Employee();
            newEmployee.Age = 20;
            t2.NewData(newEmployee);
            Console.WriteLine("Generic for Int: " + t1.Data);

            // Test_Generic<string> t2 = new Test_Generic<string>();
            //  t2.NewData("Ali");
            //  Console.WriteLine("Generic for string: " + t2.Data);
            Console.ReadLine();
        }*/
    }
}
