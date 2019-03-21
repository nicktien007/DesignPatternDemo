using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Decorator
{
    public class Decorator : Component
    {
        protected Component Component;

        public Decorator(Component component)
        {
            this.Component = component;
        }

        public override void Operation() => Component?.Operation();
    }
}
