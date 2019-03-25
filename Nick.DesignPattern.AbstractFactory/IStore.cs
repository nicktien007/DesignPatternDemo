﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nick.DesignPattern.SimpleFactory;

namespace Nick.DesignPattern.AbstractFactory
{
    interface IStore
    {
        Pizza GetPizza();
        Chicken GetChicken();
    }
}
