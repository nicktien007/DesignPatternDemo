using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Bridge
{
    public class Abstraction
    {
        public IImplementor Implementor { get; set; }
        public virtual void Operation() => Implementor.DoAction();
    }
}
