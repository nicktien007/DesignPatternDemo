using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Prototype");

            var concretePrototype = new ConcretePrototype()
            {
                Property1 = "Property1",
                Property2 = "Property2",
                Detail = new Detail()
                {
                    Id = 1,
                    Name = "Name"
                }
            };

            var clone = concretePrototype.Clone() as ConcretePrototype;

            Console.WriteLine(concretePrototype);
            Console.WriteLine(clone);

            Console.WriteLine(ReferenceEquals(concretePrototype, clone));

            //json prototype
            var concretePrototypeJson = new ConcretePrototypeJson()
            {
                Property1 = "Property1111",
                Property2 = "Property2222",
                Detail = new Detail()
                {
                    Id = 222,
                    Name = "Json"
                }
            };

            var cloneJson = concretePrototypeJson.Clone();
            Console.WriteLine(concretePrototypeJson);
            Console.WriteLine(cloneJson);
            Console.WriteLine(ReferenceEquals(concretePrototypeJson, cloneJson));

            Console.WriteLine("");
        }
    }
}
