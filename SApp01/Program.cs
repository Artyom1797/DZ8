using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{

    public class MyClass
    {
        public int MyProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.MyProperty = 15;

            MyClass myClass2 = new MyClass();
            myClass2.MyProperty = 30;

            Type type01 = typeof(MyClass);
            Type type02 = myClass1.GetType();

            PropertyInfo propertyInfo01 = type01.GetProperty("MyProperty");
            if (propertyInfo01.CanRead)
            {
                var propertyValue = propertyInfo01.GetValue(myClass2);
                Console.WriteLine($"{myClass1.GetType()} -> MyProperty: {propertyValue}");
            }
            if (propertyInfo01.CanWrite)
            {
                propertyInfo01.SetValue(myClass2, 35);
                var propertyValue = propertyInfo01.GetValue(myClass2);
                Console.WriteLine($"{myClass1.GetType()} -> MyProperty: {propertyValue}");
            }


            Console.ReadLine();


        }
    }
}
