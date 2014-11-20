using System;

namespace PracticaCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            const string nombre = "Juan";
            int ventas = 0;
            int sueldo = 0;

            Console.WriteLine("Inventario de Ventas");

            ventas = 15;

            if (ventas >= 15) {
                sueldo = 200;
                Console.WriteLine("El señor " + nombre + " vendio " + ventas + " por lo tanto: ");
                Console.WriteLine("Su sueldo es de " + sueldo + " pesos.");
            }

            Console.ReadLine();
        }
    }
}
