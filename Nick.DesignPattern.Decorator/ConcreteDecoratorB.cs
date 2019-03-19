using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();

            DoSoming();
            
            Console.WriteLine("具體裝飾物件B 的操作!!");
        }

        private void DoSoming()
        {
            Console.WriteLine("具體裝飾物件B 做一些事");
        }
    }
}
