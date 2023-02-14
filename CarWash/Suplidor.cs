using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarWash
{
    public class Suplidor : Inventario
    {
        public string nombre
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

        public int telefono
        {
            get => default;
            set
            {
            }
        }

        public int horario
        {
            get => default;
            set
            {
            }
        }

        public string calidad
        {
            get => default;
            set
            {
            }
        }

        public string rapidez
        {
            get => default;
            set
            {
            }
        }

        public void EnviarPedido()
        {
            throw new System.NotImplementedException();
        }

        public void PrepararPedido()
        {
            throw new System.NotImplementedException();
        }

        public void AñadirOrden()
        {
            throw new System.NotImplementedException();
        }

        public void CobrarPedido()
        {
            throw new System.NotImplementedException();
        }
    }
}