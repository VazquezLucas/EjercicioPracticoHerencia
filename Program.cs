/*
    -Ejercicio practico-
-crecion de tres clases (Listo)
    *Vehiculo (Padre) (Listo)
    *Avion (Hija) (Listo)
    *Coche (Hija) (Listo)
-Metodos comunes a las tres clases (Listo)
    *Arrancar motor (Listo)
    *Parar motor (Listo)
-Metodo virtual (Listo)
    *Conducir (Listo)
*/
using System;

namespace EjercicioPracticoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Probando el avión");

            Avion miAvion = new Avion();

            miAvion.arrancarMotor("tracatratracatra");

            miAvion.Despegar();

            miAvion.conducir();

            miAvion.aterrizar();

            miAvion.pararMotor("plooooof");

            Console.WriteLine();

            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.arrancarMotor("Grrrum Grrrum");

            miCoche.Acelerar();

            miCoche.conducir();

            miCoche.Frenar();

            miCoche.pararMotor("bluuuuuuuf");

            Console.WriteLine();

            Console.WriteLine("Polimorfismo en accion!");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.conducir();

            miVehiculo = miAvion;

            miVehiculo.conducir();

        }
    }
}