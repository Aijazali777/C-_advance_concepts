using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Basics_1
{
    public class SerializeClass
    {
        // File Path
        string path = @"D:\test\demo.xml";

        // Serialization
        public void serialization(List<object> dataList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<object>));
            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, dataList);
            }
        }

        public void NewData(object newData)
        {
            List<object> dataList1 = new List<object>();
         //   GenericClass<object> newDataObj = new GenericClass<object>();
          //  newDataObj.Data = newData;
         ///   dataList1.Add(newDataObj);
        //    serialization(dataList1);
        }
    }

    class program
    {
       /* static void Main(string[] args)
        {
            //  SerializeClass t1 = new SerializeClass();
            //  t1.NewData(5000);
            //  Console.WriteLine("Generic for Int:");

            SerializeClass t2 = new SerializeClass();
            t2.NewData("Ali");
            Console.WriteLine("Generic for string:");
            Console.ReadLine();
        }*/
    }
}
