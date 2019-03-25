using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Bridge\n");

            Abstraction abstraction = new DerivedAbstraction();
            abstraction.Implementor = new ConcreteImplementA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementB();
            abstraction.Operation();

            Console.WriteLine("");
        }
    }
}
