using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Adapter
{
    public class Adaptee : IOtherTarget
    {
        public void OtherRequest() => Console.WriteLine("從 Adaptee來的 OtherRequest");
    }
}
