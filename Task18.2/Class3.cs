using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task18._2;

namespace SpecialNamespace
{
    public class Class3
    {
        public Class2 class2 = new Class2();

        public void PublicMethod3()
        {
            class2.PublicMethod2();
            Console.WriteLine("І навіть у класі Class3 простору імен SpecialNamespace");
        }
    }
}
