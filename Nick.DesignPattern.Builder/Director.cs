using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Builder
{
    public class Director
    {
        public void Build(IBuilder builder) => builder.BuilderParts();
    }
}
