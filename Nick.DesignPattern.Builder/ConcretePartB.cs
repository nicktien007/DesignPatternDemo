using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Builder
{
    public class ConcretePartB: IPart
    {
        private string _name;
        public ConcretePartB(string name)
        {
            this._name = name;
        }
        public override string ToString() => $"{this.GetType().Name} [{_name}]\n";
    }
}
