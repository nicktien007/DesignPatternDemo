using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nick.DesignPattern.SimpleFactory;

namespace Nick.DesignPattern.FactoryMethod
{
    /// <summary>
    /// 製造Cheese口味的Pizza 工廠
    /// </summary>
    public class CheesePizzaFactory: IPizzaFactory
    {
        public Pizza CreatePizza()
        {
            return new CheesePizza();
        }
    }
}
