using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWash
{
    public interface IDescuento
    {
        Pago Pago { get; set; }

        void CalcularDescuento();
    }
}