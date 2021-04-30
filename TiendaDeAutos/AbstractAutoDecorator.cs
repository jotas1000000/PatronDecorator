using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaDeAutos
{
    abstract class AbstractAutoDecorator : AbstractAuto
    {
        protected AbstractAuto auto;

        public AbstractAutoDecorator(AbstractAuto auto)
        {
            this.auto = auto;
        }

        public override void caracteristicas()
        {
            Console.WriteLine("Sin nada");
        }

    }
}
