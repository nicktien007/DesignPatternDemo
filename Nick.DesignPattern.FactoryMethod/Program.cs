using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nick.DesignPattern.SimpleFactory;

namespace Nick.DesignPattern.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.FactoryMethod\n");

            IPizzaFactory cheesePizzaFactory = new CheesePizzaFactory();
            IPizzaFactory veggiePizzaFactory = new VeggiePizzaFactory();

            Pizza cheesePizza = cheesePizzaFactory.CreatePizza();
            Pizza veggiePizza = veggiePizzaFactory.CreatePizza();

            cheesePizza.GetName();
            veggiePizza.GetName();

        }
    }
}
