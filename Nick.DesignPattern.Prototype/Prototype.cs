using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Prototype
{
    abstract class  Prototype : ICloneable
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public Detail Detail { get; set; }

        public abstract object Clone();

        public override string ToString()
        {
            return $"Property1:{Property1},Property2:{Property2},Detail.Id:{Detail.Id},Detail.Name:{Detail.Name}";
        }
    }

    
}
