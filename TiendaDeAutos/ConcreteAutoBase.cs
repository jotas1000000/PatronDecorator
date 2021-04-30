using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaDeAutos
{
    class ConcreteAutoBase : AbstractAuto
    {
        public ConcreteAutoBase()
        {
            this.peso = 1;
            this.precio = 200;
        }

        public override void caracteristicas()
        {
            throw new NotImplementedException();
        }

        public override double getPeso()
        {
            return peso;
        }

        public override int getPrecio()
        {
            return precio;
        }

        public override void mostrarAccesorios()
        {
            Console.WriteLine($"El auto es un modelo deportivo y cuenta con los siguientes accesorios:");
        }

    }
}
