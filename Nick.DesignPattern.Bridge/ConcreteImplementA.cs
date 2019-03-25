using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Bridge
{
    public class ConcreteImplementA: IImplementor
    {
        public void DoAction() => Console.WriteLine("ConcreteImplementA.DoAction()");
    }
}
