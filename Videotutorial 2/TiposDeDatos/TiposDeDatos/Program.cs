using System;

namespace Fase_basica {
    class TiposDeDatos {
        static void Main(String[] args) {
            String sCadena = "Lenguaje C#";
            char[] cMatriz = { 'a', 'b', 'c' };
            int dato_int = 4;
            long dato_long = long.MinValue;
            float dato_float = float.MaxValue;
            double dato_double = Math.PI;
            bool dato_bool = true;

            Console.WriteLine(sCadena);
            Console.WriteLine(cMatriz);
            Console.WriteLine(dato_int);
            Console.WriteLine(dato_long);
            Console.WriteLine(dato_float);
            Console.WriteLine(dato_double);
            Console.WriteLine(dato_bool);

            Console.ReadLine();
        }
    }
}