using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaDeAutos
{
    class ConSistemaDePropulsion:AbstractAutoDecorator
    {
        public ConSistemaDePropulsion(AbstractAuto autos):base(autos)
        {
        }

        public override void caracteristicas()
        {
            Console.WriteLine($"peso:{this.getPeso()}Kg");
            Console.WriteLine($"precio:{this.getPrecio()}$");
        }

        public override double getPeso()
        {
            return this.auto.getPeso() + 1;
        }

        public override int getPrecio()
        {
            return this.auto.getPrecio() + 100;
        }

        public override void mostrarAccesorios()
        {
            this.auto.mostrarAccesorios();            
            Console.WriteLine("Cuenta con sistema de propulsion");
        }


    }
}
