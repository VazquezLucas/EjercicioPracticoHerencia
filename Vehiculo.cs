using System;

namespace EjercicioPracticoHerencia
{
    class Vehiculo
    {
        //Metodo arrancar motor
        public void arrancarMotor(string sonidoAlArrancar)
        {
            Console.WriteLine($"Arranca el motor: {sonidoAlArrancar}");
        }

        //Metodo parar motor
        public void pararMotor(string sonidoAlParar)
        {
            Console.WriteLine($"Motor apagado: {sonidoAlParar}");
        }

        //Metodo virtual de conducir
        public virtual void conducir()
        {
            Console.WriteLine("Moviento Vehiculo basico");
        }
    }
}