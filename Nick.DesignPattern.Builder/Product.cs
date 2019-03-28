using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Builder
{
    public class Product
    {
        private List<IPart> _parts=new List<IPart>();

        public void AddParts(List<IPart> parts) => _parts.AddRange(parts);
        public override string ToString() => $"Product Parts:\n{string.Join("", _parts)}";
    }
}
