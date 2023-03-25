using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18._2
{
    public class Class2
    {
        Class1 class1 = new Class1();
        public void PublicMethod2()
        {
            class1.PublicMethod1();
            Console.WriteLine("Доступний у класі Class2 простору імен Task18._2");
        }
    }
}
