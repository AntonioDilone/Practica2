using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWash
{
    public class Cliente : Empleado
    {
        public string nombre
        {
            get => default;
            set
            {
            }
        }

        public int cedula
        {
            get => default;
            set
            {
            }
        }

        public int telefono
        {
            get => default;
            set
            {
            }
        }

        public string direccion
        {
            get => default;
            set
            {
            }
        }

        public string carro
        {
            get => default;
            set
            {
            }
        }

        public int edad
        {
            get => default;
            set
            {
            }
        }

        public void pagar()
        {
            throw new System.NotImplementedException();
        }

        public void traerVehiculo()
        {
            throw new System.NotImplementedException();
        }

        public void paquearse()
        {
            throw new System.NotImplementedException();
        }

        public void seleccionarLavado()
        {
            throw new System.NotImplementedException();
        }
    }
}