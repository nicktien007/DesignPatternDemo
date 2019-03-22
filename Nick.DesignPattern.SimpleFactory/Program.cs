using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.SimpleFactory\n");

            Pizza cheesePizza = SimplePizzaFactory.GetPizza(PizzaType.Cheese);
            Pizza vaggiePizza = SimplePizzaFactory.GetPizza(PizzaType.Veggie);

            cheesePizza.GetName();
            vaggiePizza.GetName();

            Console.WriteLine("");
        }
    }
}
