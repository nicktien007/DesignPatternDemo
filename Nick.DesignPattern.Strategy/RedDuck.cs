using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Strategy
{
    public class RedDuck: DuckFamily
    {
        private readonly StrategyContext _context;

        public RedDuck()
        {
            this._context=new StrategyContext();
        }
        public override void Fly()
        {
            _context.SetStrategy(new RedDuckFly());
            _context.UpdateOnTick();
        }
    }
}
