using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nick.DesignPattern.SimpleFactory;

namespace Nick.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Cheese 專賣店
    /// </summary>
    public class CheeseStore: IStore
    {
        public Pizza GetPizza()
        {
            return new CheesePizza();
        }

        public Chicken GetChicken()
        {
            return new CheeseChicken();
        }
    }
}
