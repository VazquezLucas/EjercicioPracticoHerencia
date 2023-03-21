using System;

namespace EjercicioPracticoHerencia
{
    class Coche: Vehiculo
    {

        public void Acelerar() 
        {

            Console.WriteLine("Acelerando");

        }

        public void Frenar()
        {

            Console.WriteLine("Frenando");

        }

        public override void conducir()
        {
            //base.conducir();

            Console.WriteLine("Tomando las curvas");

        }

    }
}
