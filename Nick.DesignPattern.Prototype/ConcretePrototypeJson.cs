using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nick.DesignPattern.Prototype
{
    class ConcretePrototypeJson: Prototype
    {
        public override object Clone()
        {
            var qoo = JsonConvert.SerializeObject(this);

            return JsonConvert.DeserializeObject<ConcretePrototypeJson>(qoo);
        }
    }
}
