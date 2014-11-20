using System;

namespace MisClases 
{
    public class Leer
    {
        public static short datoShort()
        {
            try
            {
                return Int16.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int16.MinValue;
            }
        }

        public static int datosInt()
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int32.MinValue;
            }
        }

        public static long datosLong()
        {
            try
            {
                return Int64.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int64.MinValue;
            }
        }

        public static float datosFloat()
        {
            try
            {
                return Single.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Single.NaN;
            }
        }
    }
}