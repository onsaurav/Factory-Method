﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class ConcreateCreatorB:Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreateProductB();
        }
    }
}
