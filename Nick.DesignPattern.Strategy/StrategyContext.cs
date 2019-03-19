using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Strategy
{
    public class StrategyContext
    {
        private IStrategy _selectStrategy;

        public void UpdateOnTick()
        {
            _selectStrategy.Execute();
        }
        public void SetStrategy(IStrategy strategy)
        {
            this._selectStrategy = strategy;
        }
    }
}
