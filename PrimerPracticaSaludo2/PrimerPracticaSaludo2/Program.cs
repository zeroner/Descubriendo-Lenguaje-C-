//Aqui importamos el namespace System a nuestro programa
using System;

//Aqui creamos un namespace para nuestras clases y metodos
namespace saludo
{
    //Creamos la clase
    class Program
    {
        //Declaramos el metodo principal
        static void Main(string[] args)
        {
            int edad;
            edad = 16;
            /*Utilizamos los metodos Writeline y Readline,
             sin tene que escribir la palabra System de referencia
             a el namespace System*/
            Console.WriteLine("Hola, saludos desde 13mandamientos.com y mi edad es: " + edad + " años.");
            Console.ReadLine();
        }
    }
}