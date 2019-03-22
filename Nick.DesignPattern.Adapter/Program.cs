using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Adapter\n");

            ITarget t1 = new SomeTarget();
            t1.Request();

            ITarget t2 = new Adapter();
            t2.Request();

            Console.WriteLine("");
        }
    }
}
