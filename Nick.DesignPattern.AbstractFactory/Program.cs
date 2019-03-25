using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.AbstractFactory\n");

            IStore cheeseStore = new CheeseStore();
            IStore veggieStore = new VeggieStore();

            var pizza = cheeseStore.GetPizza();
            var chicken = veggieStore.GetChicken();

            pizza.GetName();
            chicken.GetName();

            Console.WriteLine("");
        }
    }
}
