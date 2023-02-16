using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrestamoLibros
{
    public interface IRetrasado
    {
        Prestamo Prestamo { get; set; }

        void cobrarMora();
    }
}