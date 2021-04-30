using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaDeAutos
{
    abstract class AbstractAuto
    {
        public double peso;
        public int precio;

        public abstract void mostrarAccesorios();
        public abstract void caracteristicas();
        public abstract int getPrecio();
        public abstract double getPeso();
    }
}
