using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nick.DesignPattern.Prototype
{
    class ConcretePrototype: Prototype
    {
        public override object Clone()
        {
            return new ConcretePrototype()
            {
                Property1 = this.Property1,
                Property2 = this.Property2,
                Detail = new Detail()
                {
                    Id = this.Detail.Id,
                    Name = this.Detail.Name
                }
            };
        }
    }
}
