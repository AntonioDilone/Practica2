﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWash
{
    public interface IServicio
    {
        Lavados Lavados { get; set; }

        void CobrarServicio();
    }
}