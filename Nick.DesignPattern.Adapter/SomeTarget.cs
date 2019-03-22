using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Adapter
{
    public class SomeTarget : ITarget
    {
        public void Request() => Console.WriteLine("從 SomeTarget來的 Request");
    }
}
