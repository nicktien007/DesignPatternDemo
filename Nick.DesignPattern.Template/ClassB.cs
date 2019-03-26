using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Template
{
    class ClassB: AbstractClass
    {
        protected override void Action3()=> Console.WriteLine("DO ClassB Action3");


        protected override void Action4() => Console.WriteLine("DO ClassB Action4");
    }
}
