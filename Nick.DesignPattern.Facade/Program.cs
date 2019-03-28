using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Facade\n");

            Facade facade = new Facade();
            facade.DoUnifiedMethod();

            Console.WriteLine("");
        }
    }
}
