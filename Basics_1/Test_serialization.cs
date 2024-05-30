using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Basics_1
{
    class Test_serialization
    {
        //XML File Path
        string path = @"D:\test\account_deatils_99.xml";

        // SERILIZATION
        void serilization(List<Customer> customers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, customers);
            }
        }

        // DESERILIZATION
        List<Customer> deserilization()
        {
            List<Customer> desCust = new List<Customer>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamReader reader = new StreamReader(path))
            {
                desCust = (List<Customer>)serializer.Deserialize(reader);
            }
            return desCust;
        }

        public void NewUser()
        {
            List<Customer> customer = new List<Customer>();//deserilization();
            Customer newCustomer = new Customer();
            newCustomer.Name = "Ali";
            newCustomer.Age = 40;
            customer.Add(newCustomer);
            serilization(customer);

            Customer a = new Customer();
            a.Name = "Az";
            a.Age = 66;
            customer.Add(a);
            serilization(customer);

        }

    /*    static void Main(string[] args)
        {
            Test_serialization t1 = new Test_serialization();
            t1.NewUser();
        }*/
    }
}
