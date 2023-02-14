using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWash
{
    public interface IPagable
    {
        Lavados Lavados { get; set; }
        Orden Orden { get; set; }

        void Cobrar();
    }
}