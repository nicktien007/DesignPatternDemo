using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Proxy
{
    /// <summary>
    /// 代理者：代理 RealSubject
    /// </summary>
    public class ProxySubject : ISubject
    {
        private readonly Lazy<RealSubject> _realSubject = new Lazy<RealSubject>();
        public void Request() => _realSubject.Value.Request();
    }
}
