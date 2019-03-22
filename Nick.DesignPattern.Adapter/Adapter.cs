using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Adapter
{
    /// <summary>
    /// 轉接器：將SomeTarget.Request轉換為Adaptee.OtherRequest
    /// </summary>
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            OtherRequest();
        }
    }
}
