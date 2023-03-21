using System;

namespace EjercicioPracticoHerencia
{
    class Avion: Vehiculo
    {
        
        public void aterrizar()
        {

            Console.WriteLine("Aterrizando");

        }

        public void Despegar()
        {

            Console.WriteLine("Despegando");

        }

        public override void conducir()
        {
            //base.conducir();

            Console.WriteLine("Surcando los cielos");

        }

    }
}
