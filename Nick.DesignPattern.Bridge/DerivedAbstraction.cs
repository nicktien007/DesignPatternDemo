using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Bridge
{
    public class DerivedAbstraction : Abstraction
    {
        public override void Operation() => Implementor.DoAction();
    }
}
