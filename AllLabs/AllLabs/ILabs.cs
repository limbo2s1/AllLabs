﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabsProject
{
    internal interface ILabs
    {
        void Demo();
        string Name();
        string Description();
        int Id();
    }
}