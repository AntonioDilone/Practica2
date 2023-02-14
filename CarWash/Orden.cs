using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWash
{
    public class Orden : Pago
    {
        public int fecha
        {
            get => default;
            set
            {
            }
        }

        public int servicio
        {
            get => default;
            set
            {
            }
        }

        public int costoTotal
        {
            get => default;
            set
            {
            }
        }

        public string cliente
        {
            get => default;
            set
            {
            }
        }

        public string empleados
        {
            get => default;
            set
            {
            }
        }

        public int numeroOrden
        {
            get => default;
            set
            {
            }
        }

        public void MostrarOrden()
        {
            throw new System.NotImplementedException();
        }

        public void MostrarTotal()
        {
            throw new System.NotImplementedException();
        }

        public void MostrarCliente()
        {
            throw new System.NotImplementedException();
        }

        public void MostrarEmpleados()
        {
            throw new System.NotImplementedException();
        }
    }
}