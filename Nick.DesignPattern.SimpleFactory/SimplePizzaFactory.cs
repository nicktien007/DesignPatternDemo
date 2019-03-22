using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.SimpleFactory
{
    public static class SimplePizzaFactory
    {
        public static Pizza GetPizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                    
                case PizzaType.Veggie:
                    return new VeggiePizza();
                default:
                    return new CheesePizza();
            }
        }
    }
}
