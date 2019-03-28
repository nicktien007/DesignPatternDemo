using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nick.DesignPattern.Facade
{
    public class Facade
    {
        private readonly ClassA _classA;
        private readonly ClassB _classB;
        private readonly ClassC _classC;

        public Facade()
        {
            this._classA = new ClassA();
            this._classB = new ClassB();
            this._classC = new ClassC();
        }

        public void DoUnifiedMethod()
        {
            _classA.DoActionA();
            _classB.DoActionB();
            _classC.DoActionC();
        }
    }
}
