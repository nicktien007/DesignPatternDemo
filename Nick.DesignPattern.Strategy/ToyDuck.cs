using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Strategy
{
    /// <summary>
    /// 玩具鴨
    /// </summary>
    public class ToyDuck : DuckFamily
    {
        private readonly StrategyContext _context;
        public ToyDuck()
        {
            this._context = new StrategyContext();
        }
        public override void Fly()
        {
            _context.SetStrategy(new ToyDuckFly());
            _context.UpdateOnTick();
        }
    }
}
