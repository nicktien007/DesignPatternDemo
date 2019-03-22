using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nick.DesignPattern.Proxy\n");

            //呼叫代理人執行操作，實際執行操作的是 RealSubject
            ISubject subject = new ProxySubject();
            subject.Request();

            Console.WriteLine("");
        }
    }
}
