using System;
using MisClases;

namespace PracticaCondicionales
{
    class CMenor
    {
        static void Main(string[] args)
        {
            float a, b, c, menor;

            Console.Write("a : ");
            a = Leer.datosFloat();
            Console.Write("b : ");
            b = Leer.datosFloat();
            Console.Write("c : ");
            c = Leer.datosFloat();

            if (a < b)
                if (a < c)
                    menor = a;
                else
                    menor = c;
            else
                if (b < c)
                    menor = b;
                else
                    menor = c;

            Console.WriteLine("Menor = " + menor);
        }
    }
}
