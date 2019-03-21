using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("具體裝飾物件A 的操作!!");
        }
    }
}
