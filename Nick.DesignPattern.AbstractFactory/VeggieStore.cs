using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Nick.DesignPattern.SimpleFactory;

namespace Nick.DesignPattern.AbstractFactory
{
    /// <summary>
    /// 蔬菜專賣店
    /// </summary>
    public class VeggieStore : IStore
    {
        public Pizza GetPizza()
        {
            return new VeggiePizza();
        }

        public Chicken GetChicken()
        {
            return new VeggieChicken();
        }
    }
}
