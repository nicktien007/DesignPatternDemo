using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Decorator\n");

            ConcreteComponent concreteComponent = new ConcreteComponent();

            ConcreteDecoratorA dA = new ConcreteDecoratorA(concreteComponent);
            ConcreteDecoratorB dB = new ConcreteDecoratorB(dA);
            
            dB.Operation();
        }
    }
}
