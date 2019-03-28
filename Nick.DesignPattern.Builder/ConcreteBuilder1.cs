using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Builder
{
    public class ConcreteBuilder1 : IBuilder
    {
        private readonly Product _product = new Product();
        public void BuilderParts()
        {
            var parts = new List<IPart>()
            {
                new ConcretePartA("Builder1.A"),
                new ConcretePartB("Builder1.B"),
                new ConcretePartA("Builder1.C"),
                new ConcretePartA("Builder1.D"),
                new ConcretePartB("Builder1.E"),
            };
            _product.AddParts(parts);
        }

        public Product GetProduct() => this._product;
    }
}
