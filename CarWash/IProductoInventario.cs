using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWash
{
    public interface IProductoInventario
    {
        int FechaVencimiento { get; set; }
        Inventario Inventario { get; set; }
    }
}