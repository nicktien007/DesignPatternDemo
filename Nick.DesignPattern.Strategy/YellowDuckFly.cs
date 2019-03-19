using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Strategy
{
    public class YellowDuckFly:IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("黃鴨子飛起來了!!!");
        }
    }
}
