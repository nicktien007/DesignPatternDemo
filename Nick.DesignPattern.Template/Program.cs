using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Template\n");

            AbstractClass classA=new ClassA();
            classA.TemplateMethod();

            Console.WriteLine("============================");

            AbstractClass classB = new ClassB();
            classB.TemplateMethod();

            Console.WriteLine("");
        }
    }
}
