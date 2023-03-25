using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialNamespace;
using MyNamespace;

namespace Task18._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Class3 class3 = new Class3();
            class3.PublicMethod3();

            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.a);
            Console.ReadKey();
        }
    }
}
