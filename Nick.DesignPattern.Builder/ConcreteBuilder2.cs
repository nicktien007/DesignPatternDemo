using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Builder
{
    public class ConcreteBuilder2 : IBuilder
    {
        private readonly Product _product = new Product();
        public void BuilderParts(){

            var parts = new List<IPart>()
            {
                new ConcretePartB("Builder2.A"),
                new ConcretePartB("Builder2.B"),
                new ConcretePartA("Builder2.C"),
            };
            _product.AddParts(parts);
        }

        public Product GetProduct() => this._product;
    }
}
