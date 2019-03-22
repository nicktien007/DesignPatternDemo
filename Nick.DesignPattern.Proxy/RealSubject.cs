using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Proxy
{
    /// <summary>
    /// 實際操作者
    /// </summary>
    public class RealSubject : ISubject
    {
        public void Request() => Console.WriteLine("RealSubject.Request");
    }
}
