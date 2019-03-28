using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Builder\n");

            Director director = new Director();

            IBuilder builder1 = new ConcreteBuilder1();
            IBuilder builder2 = new ConcreteBuilder2();

            director.Build(builder1);
            director.Build(builder2);

            Console.WriteLine(builder1.GetProduct());
            Console.WriteLine(builder2.GetProduct());

            Console.WriteLine("");
        }
    }
}
