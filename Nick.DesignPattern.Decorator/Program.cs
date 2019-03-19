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

            ConcreteComponent concreteComponent = new ConcreteComponent();

            ConcreteDecoratorA dA = new ConcreteDecoratorA();
            ConcreteDecoratorB dB = new ConcreteDecoratorB();

            dA.SetComponent(concreteComponent);
            dB.SetComponent(dA);
            dB.Operation();

            Console.WriteLine("Nick.DesignPattern.Decorator");
        }
    }
}
