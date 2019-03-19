using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckFamily yellowDuck = new YellowDuck();
            DuckFamily redDuck = new RedDuck();
            DuckFamily toyDuck = new ToyDuck();

            toyDuck.Fly();
            yellowDuck.Fly();
            redDuck.Fly();
        }
    }
}
