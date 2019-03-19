using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Strategy
{
    public class YellowDuck:DuckFamily
    {
        private readonly StrategyContext _context;

        public YellowDuck()
        {
            this._context = new StrategyContext();
        }

        public override void Fly()
        {
            _context.SetStrategy(new YellowDuckFly());
            _context.UpdateOnTick();
        }
    }
}
