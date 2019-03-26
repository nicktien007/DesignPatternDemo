using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Template
{
    public abstract class AbstractClass
    {
        protected void Action1() => Console.WriteLine("Do AbstractClass Action1");
        protected void Action2() => Console.WriteLine("Do AbstractClass Action2");
        protected abstract void Action3();
        protected abstract void Action4();

        public void TemplateMethod()
        {
            Action1();
            Action2();
            Action3();
            Action4();
        }
    }
}
