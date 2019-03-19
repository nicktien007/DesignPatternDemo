using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Strategy
{
    public class ToyDuckFly:IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("玩具鴨不會飛!!!!!");
        }
    }
}
