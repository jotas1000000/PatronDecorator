using System;

namespace TiendaDeAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractAuto autoBase = new ConcreteAutoBase();
            AbstractAutoDecorator autoDecorado;
            //Decoradores
            autoDecorado = new ConSistemaDePropulsion(autoBase);
            autoDecorado = new ConChasisReforzado(autoDecorado);
            autoDecorado = new ConRuedasTodoTerreno(autoDecorado);
            autoDecorado = new ConSuspensionPremium(autoDecorado);
            autoDecorado.mostrarAccesorios();
            autoDecorado.caracteristicas();

        }
    }
}
