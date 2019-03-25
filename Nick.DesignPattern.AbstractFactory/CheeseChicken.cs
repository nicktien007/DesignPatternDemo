using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.AbstractFactory
{
    public class CheeseChicken : Chicken
    {
        public override void GetName() => Console.WriteLine("我是 Cheese口味的 烤雞");

    }
}
